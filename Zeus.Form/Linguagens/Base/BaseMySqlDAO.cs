﻿using System;
using System.Collections.Generic;
using Zeus.Core.SGBD.MySql;

namespace Zeus.Linguagens.Base
{
    public class BaseMySqlDAO
    {
        public BaseMySqlDAO(string nomeTabela)
        {
            NomeTabela = nomeTabela;
        }

        protected static string N => Environment.NewLine;
        public string NomeTabela { get; set; }
        public List<MySqlEntidadeTabela> ListaAtributosTabela => new MySqlTables().ListarAtributos(NomeTabela);
    }
}