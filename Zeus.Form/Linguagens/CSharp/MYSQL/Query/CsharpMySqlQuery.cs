﻿using System.Text;
using Zeus.Core;
using Zeus.Linguagens.Base;

namespace Zeus.Linguagens.CSharp.MYSQL.Query
{
    public class CsharpMySqlQuery : BaseMySqlDAO
    {
        public CsharpMySqlQuery(string nomeTabela) : base(nomeTabela)
        {
        }

        public string IsNullabe(string aceitaNull)
        {
            return aceitaNull == "Y" ? "?" : "";
        }

        public string GetTypeAtribute(string tipoAttr, string aceitaNull)
        {
            switch (tipoAttr)
            {
                case "DATE":
                    return "DateTime" + IsNullabe(aceitaNull);
                case "NUMBER":
                    return "long" + IsNullabe(aceitaNull);
                default:
                    return "string";
            }
        }

        public StringBuilder GerarInterfaceSharProc()
        {
            var nomeProcBase = NomeTabela.TratarNomeTabela();

            var classe = new StringBuilder();
            classe.Append("using System;" + N + N);
            classe.Append("namespace MeuProjeto" + N);
            classe.Append("{" + N);
            classe.Append($"    public interface {nomeProcBase.ToLowerInvariant()}RequestRepository : IADORepository" +
                          N);
            classe.Append("    {" + N + N);
            classe.Append(GetInterfacesMethod());
            classe.Append("    }" + N);
            classe.Append("}" + N);

            return classe;
        }

        private StringBuilder GetInterfacesMethod()
        {
            var assinatura = new StringBuilder();
            assinatura.Append($"        RequestMessage<{NomeTabela}> GetById(long ID);" + N + N);
            assinatura.Append(
                $"        RequestMessage<string> Add({NomeTabela} entidade, bool commit = false);" + N + N);
            assinatura.Append($"        RequestMessage<string> Update({NomeTabela} entidade, bool commit = false);" +
                              N + N);
            return assinatura;
        }


        #region CLASSE 

        public StringBuilder GerarBodyCSharpProc()
        {
            var nomeProcBase = NomeTabela.TratarNomeTabelaMySql();

            var classe = new StringBuilder();
            classe.Append("using System.Net;" + N);
            classe.Append("using System;" + N + N);
            classe.Append("namespace MeuProjeto" + N);
            classe.Append("{" + N);
            classe.Append($"    public class {nomeProcBase.ToLowerInvariant()}RequestRepository : ADORepository" + N);
            classe.Append("    {" + N + N);
            classe.Append(GetById(nomeProcBase));
            classe.Append(Add(nomeProcBase));
            classe.Append(Update(nomeProcBase));

            classe.Append("    }" + N);
            classe.Append("}" + N);

            return classe;
        }

        #region ::: Enum Procedures :::

        private StringBuilder Procedures(string nomeProcBase)
        {
            var proc = new StringBuilder();
            proc.Append(N);
            proc.Append("        private enum Procedures" + N);
            proc.Append("        {" + N);
            proc.Append($"            S_{nomeProcBase}," + N);
            proc.Append($"            {nomeProcBase}," + N);
            proc.Append($"            {nomeProcBase}" + N);
            proc.Append("        }" + N + N);
            return proc;
        }

        #endregion

        #region ::: Get By ID :::

        private StringBuilder GetById(string nomeProcedure)
        {
            var methodo = new StringBuilder();
            methodo.Append(N);
            methodo.Append($"        public RequestMessage<{NomeTabela}> GetById(long ID)" + N);
            methodo.Append("        {" + N);
            methodo.Append($"            var result = new RequestMessage<{NomeTabela}>" + N);
            methodo.Append("            {" + N);
            methodo.Append($"                Procedure = $\"{{PackageName}}.{{Procedures.S_{nomeProcedure}}}\"," + N);
            methodo.Append($"                MethodApi = GetClass.GetMethod()" + N);
            methodo.Append("            };" + N);
            methodo.Append(N);
            methodo.Append("            BeginNewStatement(result.Procedure);" + N);
            methodo.Append("            AddParameter(\"ID\", ID);" + N);
            methodo.Append(N);
            methodo.Append("            OpenConnection();" + N);
            methodo.Append("            using (var reader = ExecuteReader())" + N);
            methodo.Append("            {" + N);
            methodo.Append("                if (reader.Read())" + N);
            methodo.Append($"               {{" + N);
            methodo.Append($"                    result.Content = new {NomeTabela}" + N);
            methodo.Append("                    {" + N);
            methodo.Append(GetListaItensGetById());
            methodo.Append("                    };" + N);
            methodo.Append("                return result;" + N);
            methodo.Append($"               }}" + N);
            methodo.Append("            }" + N);
            methodo.Append(N);
            methodo.Append("            result.Message = $\"O request de {ID} não foi encontrada.\";" + N);
            methodo.Append("            result.StatusCode = HttpStatusCode.NoContent;" + N);
            methodo.Append($"            result.Content = new {NomeTabela}();" + N);
            methodo.Append(N);
            methodo.Append("            return result;" + N);
            methodo.Append("       }" + N);
            methodo.Append(N);
            return methodo;
        }

        private StringBuilder GetListaItensGetById()
        {
            var atributoText = new StringBuilder();
            foreach (var item in ListaAtributosTabela)
                atributoText.Append(
                    $"                        {item.COLUMN_NAME} = \"{item.COLUMN_NAME}\".GetValueOrDefault<{GetTypeAtribute(item.DATA_TYPE, item.IS_NULLABLE)}>(reader)," +
                    N);
            return atributoText;
        }

        #endregion

        #region ::: ADD :::

        private StringBuilder Add(string nomeProcedure)
        {
            var methodo = new StringBuilder();
            methodo.Append(N);
            methodo.Append($"        public RequestMessage<string> Add({NomeTabela} entidade, bool commit = false)" +
                           N);
            methodo.Append("        {" + N + N);

            methodo.Append($"            BeginNewStatement(PackageName, Procedures.{nomeProcedure});" + N);

            methodo.Append(N);
            methodo.Append("            AddResult();" + N);
            methodo.Append(GetListaItensAdd());
            methodo.Append(N + "            return RequestProc(GetClass.GetMethod(), commit);" + N);
            methodo.Append("        }" + N);
            methodo.Append(N);
            return methodo;
        }

        private StringBuilder GetListaItensAdd()
        {
            var atributoText = new StringBuilder();
            foreach (var item in ListaAtributosTabela)
                atributoText.Append($"            AddParameter(\"{item.COLUMN_NAME}\", entidade.{item.COLUMN_NAME});" +
                                    N);
            return atributoText;
        }

        #endregion

        #region ::: UPDATE :::

        private StringBuilder Update(string nomeProcedure)
        {
            var methodo = new StringBuilder();
            methodo.Append(N);
            methodo.Append($"        public RequestMessage<string> Update({NomeTabela} entidade, bool commit = false)" +
                           N);
            methodo.Append("        {" + N + N);

            methodo.Append($"            BeginNewStatement(PackageName, Procedures.{nomeProcedure});" + N);

            methodo.Append(N);
            methodo.Append("            AddResult();" + N);
            methodo.Append(GetListaItensAdd());
            methodo.Append(N + "            return RequestProc(GetClass.GetMethod(), commit);" + N);
            methodo.Append("        }" + N);
            methodo.Append(N);
            return methodo;
        }

        #endregion

        #endregion
    }
}