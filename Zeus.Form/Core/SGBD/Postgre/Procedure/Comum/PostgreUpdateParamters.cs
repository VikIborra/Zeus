﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeus.Core.SGBD.Postgre.Procedure.Comum
{
    public class PostgreUpdateParamters
    {
        private string N => Environment.NewLine;

        public StringBuilder Init(string nomeTabela, List<PostgreEntidadeTabela> listaAtributos)
        {
            var param = new StringBuilder();
            var count = listaAtributos.Count;
            if (count == 0)
                return param;

            param.Append($"	     UPDATE {nomeTabela}" + N);
            param.Append($"   		   SET {listaAtributos[0].COLUMN_NAME}     = P_{listaAtributos[0].COLUMN_NAME},{N}");
            for (var i = 1; i < count - 1; i++)
                param.Append(
                    $"               {listaAtributos[i].COLUMN_NAME}     = P_{listaAtributos[i].COLUMN_NAME},{N}");
            param.Append(
                $"               {listaAtributos[count - 1].COLUMN_NAME}     = P_{listaAtributos[count - 1].COLUMN_NAME}{N}");
            param.Append(
                $"     	   WHERE {listaAtributos.First().COLUMN_NAME} =  P_{listaAtributos.First().COLUMN_NAME};{N}{N}");

            return param;
        }
    }
}