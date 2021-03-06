﻿#pragma warning disable 1587
///.........CLASSE PARA ACESSO A DADOS UTILIZANDO ADO..........
/// ...........................................................
/// Os metodos implementados na region 'Metodos' estão na ordem 
/// ....em que devem ser executados para chamar alguma proc mas
/// ....isso não quer dizer que voce precise usar todos........
/// ...........................................................
#pragma warning restore 1587

using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Runtime.CompilerServices;

namespace Zeus.Core.SGBD.Microsoft_SQL
{
    public abstract class SQLRepository
    {
        #region ••• Construtor •••

        protected SQLRepository()
        {
            P_RESULT = "P_RESULT";
            _command = new SqlCommand();
        }

        #endregion

        /// <summary>
        ///     Parametriza qual é o nome do parametro de Resposta
        /// </summary>
        public string P_RESULT { get; set; }

        #region ••• Propriedades •••

        private readonly SqlCommand _command;
        private bool _closeConnectionAfterExecution;
        private SqlConnection _connection;
        private SqlTransaction _transaction;

        #endregion

        #region ••• Metodos •••

        protected void BeginNewStatement(string comando)
        {
            _command.CommandType = CommandType.Text;
            _command.CommandText = comando;
            _command.Parameters.Clear();
        }

        protected void BeginNewStatement(string packageName, string procedureName)
        {
            _command.CommandType = CommandType.StoredProcedure;
            _command.CommandText = packageName + "." + procedureName;
            _command.Parameters.Clear();
        }

        protected void BeginNewStatement(string packageName, object procedureName)
        {
            _command.CommandType = CommandType.StoredProcedure;
            _command.CommandText = packageName + "." + procedureName;
            _command.Parameters.Clear();
        }


        public SqlConnection Connection()
        {
            return _connection;
        }

        public void SetConnection(SqlConnection conexao)
        {
            if (conexao.State != ConnectionState.Open)
                throw new ArgumentException("Não foi possível setar a conexão, pois a mesma foi encerrada!");
            _connection = conexao;
            _command.Connection = conexao;
        }


        protected void AddParameter(string name, object value)
        {
            _command.Parameters.AddWithValue("P_" + name, value);
        }


        protected void OpenConnection(bool closeAfterExecution = true)
        {
            if (_connection == null)
                _connection = new SqlConnection(ParamtersInput.ConnectionString);

            if (_connection.State == ConnectionState.Broken && _connection.State == ConnectionState.Closed)
                throw new ArgumentException("Falha na conexão com o banco de dados:" + _connection.State +
                                    _connection.ConnectionString);

            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            _closeConnectionAfterExecution = closeAfterExecution && _transaction == null;
            _command.Connection = _connection;
        }


        public void BeginTransaction()
        {
            OpenConnection(false);

            if (_transaction == null)
                _transaction = _connection.BeginTransaction();

            _command.Transaction = _transaction;
        }


        protected int ExecuteStatement()
        {
            try
            {
                var response = _command.ExecuteNonQuery();
                if (_closeConnectionAfterExecution)
                    _connection.Close();

                return response;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Falha na conexão com o banco de dados" + "\n" + _command.CommandText + "\n" +
                                    "\n" + ex.Message + "\n" + _connection.ConnectionString);
            }
        }

        public void BeginTransaction(IsolationLevel isolationLevel)
        {
            OpenConnection(false);

            if (_transaction == null)
                _transaction = _connection.BeginTransaction(isolationLevel);

            _command.Transaction = _transaction;
        }


        public void EndTransaction(bool commit, bool closeConnection = true)
        {
            try
            {
                if (_transaction == null)
                    return;
                if (commit)
                    _transaction.Commit();
                else
                    _transaction.Rollback();
                _command.Transaction = _transaction = null;
                if (closeConnection)
                    _connection.Close();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Falha na conexão com o banco de dados" + "\n" + _command.CommandText + "\n" +
                                    ex.Message + "\n" + _connection.ConnectionString);
            }
        }


        protected object GetOutputParameter(string name)
        {
            return _command.Parameters["P_" + name].Value;
        }

        protected IDataReader ExecuteReader()
        {
            try
            {
                var retorno = _command.ExecuteReader(_closeConnectionAfterExecution
                    ? CommandBehavior.CloseConnection
                    : CommandBehavior.Default);
                return retorno;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Falha na conexão com o banco de dados" + "\n" + _command.CommandText + "\n" +
                                    ex.Message + "\n" + _connection.ConnectionString);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="caminho"></param>
        /// <param name="fecharConexao">Usar false quando usar Transaction</param>
        /// <returns></returns>
        public RequestMessage<string> RequestProc(string caminho, bool fecharConexao = true)
        {
            /* Validar se existe uma transaction*/
            if (fecharConexao && _command.Transaction != null)
                throw new ArgumentException(
                    $"A aplicação não está finalizando uma transaction.\nVerifique o método: {caminho}\nProcedure: {_command.CommandText}");

            OpenConnection(fecharConexao);
            ExecuteStatement();

            var result = _command.Parameters[P_RESULT].Value;

            return new RequestMessage<string>
            {
                Procedure = _command.CommandText,
                StatusCode = result.ToString() == "0" || result.ToString().Contains("ORA-")
                    ? HttpStatusCode.BadRequest
                    : HttpStatusCode.OK,
                Message = result.ToString().Contains("ORA-") ? result.ToString() : "",
                Content = result.ToString().Contains("ORA-") ? "" : result.ToString(),
                MethodApi = caminho,
                Parameter = P_RESULT
            };
        }

        #endregion
    }

    public static class NullSafeGetter
    {
        public static T GetValueOrDefault<T>(this IDataRecord r, string columnName,
            [CallerFilePath] string sourceFilePath = "")
        {
            try
            {
                return r[columnName] == DBNull.Value ? default(T) : (T) r[columnName];
            }
            catch (Exception ex) when (ex.Message == "Unable to find specified column in result set")
            {
                throw new ArgumentException(
                    $"{ex.Message}\nNão foi possível encontrar o paramêtro: [{columnName}] da procedure\nClasse: {sourceFilePath}");
            }
            catch (Exception ex)
            {
                if (default(T) == null)
                    throw new ArgumentException(
                        $"{ex.Message}\nFalha ao converter parametro: [{columnName}] da procedure. onde deveria ser: {r[columnName].GetType().Name}\nClasse: {sourceFilePath}");
                throw new ArgumentException(
                    $"{ex.Message}\nFalha ao converter parametro: [{columnName}] da procedure, para o tipo: {default(T).GetType().Name} / Onde deveria ser: {r[columnName].GetType().Name}\nClasse: {sourceFilePath}");
            }
        }
    }
}