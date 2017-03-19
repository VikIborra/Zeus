﻿using System;
using System.IO;
using System.Windows.Forms;
using Zeus.Core;
using Zeus.Utilidade;

namespace Zeus.Linguagens.CSharp.Firebird.Entidade
{
    public class CSharpFirebirdOrquestraEntidade
    {
        public RequestMessage<string> CSharp(FolderBrowserDialog salvar)
        {
            try
            {
                int max = ParamtersInput.NomeTabelas.Count;
                var i = 0;

                foreach (var nomeTabela in ParamtersInput.NomeTabelas)
                {
                    i++;
                    Util.Barra((int)((((decimal)i / max) * 100)));
                    Util.Status($"Processando tabela: {nomeTabela}");
                    var classe = new CSharpFirebirdEntidade().GerarBody(nomeTabela);
                    File.WriteAllText($"{salvar.SelectedPath}\\{nomeTabela}Model.cs", classe);
                }
                return new RequestMessage<string>()
                {
                    Message = "Processamento concluído com sucesso!",
                    StatusCode = System.Net.HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new RequestMessage<string>()
                {
                    Message = "Falha no sistema!",
                    TechnicalMessage = ex.Message,
                    StatusCode = System.Net.HttpStatusCode.InternalServerError
                };
            }
        }
    }
}