﻿using System;
using System.Linq;
using System.Text;
using Zeus.Core;
using Zeus.Core.SGBD.MySql;
using Zeus.Linguagens.Base;

namespace Zeus.Linguagens.Node.MySql.Procedure
{
    public class NodeMySqlProcedure : BaseMySqlDAO
    {
        private string baseDb = ParamtersInput.ConnectionString.TratarNomeBase();

        public NodeMySqlProcedure(string nomeTabela) : base(nomeTabela)
        {
        }
        private StringBuilder Imports()
        {
            var connection = new MySqlConnectionStringModel(ParamtersInput.ConnectionString);
            var imports = new StringBuilder();
            imports.Append($"const mysql = require('jano-mysql')({{{N}" +
                           $"        host: '{connection.host}',{N}" +
                           $"        user: '{connection.user}',{N}" +
                           $"        database: '{connection.database}',{N}" +
                           $"        password: '{connection.password}',{N}" +
                           $"        port: {connection.port}{N}" +
                           $"}});{N}{N}");

            return imports;
        }

        private StringBuilder GetById()
        {
            var get = new StringBuilder();
            get.Append($"        getById: (id) => {{{N}");
            get.Append($"                return mysql.readProcedure(`{NomeTabela.TratarNomeProcedure(OperationProcedure.Search)}(${{{ListaAtributosTabela.First().COLUMN_NAME}}})`);{N}");
            get.Append($"        }},{N}");
            return get;
        }

        private StringBuilder GetAll()
        {
            var get = new StringBuilder();
            get.Append($"        getAll: () => {{{N}");
            get.Append($"                return mysql.readProcedure(`{NomeTabela.TratarNomeProcedure(OperationProcedure.List)}`);{N}");
            get.Append($"        }},{N}");
            return get;
        }

        private StringBuilder Add()
        {
            var get = new StringBuilder();
            get.Append($"        insert: (body) => {{ {N}");
            get.Append($"                return mysql.readProcedure(`{NomeTabela.TratarNomeProcedure(OperationProcedure.Insert)}`, {parametrosQuery(false)});{N}");
            get.Append($"        }},{N}");
            return get;
        }

        private StringBuilder Update()
        {

            var get = new StringBuilder();
            get.Append($"        update: (body) => {{ {N}");
            get.Append($"                return mysql.readProcedure(`{NomeTabela.TratarNomeProcedure(OperationProcedure.Update)}`, {parametrosQuery(true)});{N}");
            get.Append($"        }},{N}");
            return get;
        }
        private StringBuilder Delete()
        {
            var get = new StringBuilder();
            get.Append($"        delete: (id) => {{ {N}");
            get.Append($"                return mysql.readProcedure(`{NomeTabela.TratarNomeProcedure(OperationProcedure.Delete)}(${{{ListaAtributosTabela.First().COLUMN_NAME}}})`);{N}");
            get.Append($"        }}{N}");
            return get;
        }

        public StringBuilder GerarClasse()
        {
            var classe = new StringBuilder();
            classe.Append(Imports());
            classe.Append($"module.exports = {{{N}");
            classe.Append(GetById());
            classe.Append(GetAll());
            classe.Append(Add());
            classe.Append(Update());
            classe.Append(Delete());
            classe.Append($"}};{N}");
            return classe;
        }

        private string parametrosQuery(bool full)
        {
            if (full == false)
            {
                var semit = ListaAtributosTabela.Where(x => x.COLUMN_NAME != ListaAtributosTabela.First().COLUMN_NAME);
                return "{ " + String.Join(", ", semit.Select(e => e.COLUMN_NAME + ": " + "body." + e.COLUMN_NAME)) + " }";

            }
            return "{ " + String.Join(", ", ListaAtributosTabela.Select(e => e.COLUMN_NAME + ": " + "body." + e.COLUMN_NAME)) + " }";
        }
    }
}
