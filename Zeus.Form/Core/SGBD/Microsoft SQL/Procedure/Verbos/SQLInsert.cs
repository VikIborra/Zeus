﻿using System;
using System.Collections.Generic;
using System.Text;
using Zeus.Core.SGBD.Microsoft_SQL.Procedure.Comum;

namespace Zeus.Core.SGBD.Microsoft_SQL.Procedure.Verbos
{
    public class SQLInsert
    {
        private string N => Environment.NewLine;

        /// <summary>
        ///     Adiciona no header da procedure o comando para dropar caso exista a procedure -
        ///     Também adicionar o sumário
        /// </summary>
        /// <param name="nomeProcedure"></param>
        /// <param name="nomeTabela"></param>
        /// <param name="listaAtributos"></param>
        /// <returns></returns>
        public StringBuilder Init(string nomeProcedure, string nomeTabela, List<SQLEntidadeTabela> listaAtributos)
        {
            var desc = new StringBuilder();
            desc.Append(new SQLSumario().Init(nomeProcedure, nomeTabela, Paramters(listaAtributos)));
            desc.Append("	BEGIN" + N + N);
            desc.Append(new SQLInsertParamters().Init(nomeTabela, listaAtributos));
            desc.Append("	END" + N + N);
            desc.Append("GO" + N + N + N + N);
            return desc;
        }

        private StringBuilder Paramters(List<SQLEntidadeTabela> parametro)
        {
            var count = parametro.Count;
            var desc = new StringBuilder();
            if (count == 1)
                return desc;

            for (var i = 1; i < count - 1; i++)
                desc.Append($"	@{parametro[i].COLUMN_NAME}        {parametro[i].DATA_TYPE},{N}");
            desc.Append($"	@{parametro[count - 1].COLUMN_NAME}        {parametro[count - 1].DATA_TYPE}{N}");
            return desc;
        }
    }
}