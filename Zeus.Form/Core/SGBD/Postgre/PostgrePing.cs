﻿using System.Collections.Generic;
using System.Net;

namespace Zeus.Core.SGBD.Postgre
{
    public class PostgrePing : PostgreRepository
    {
        public RequestMessage<List<string>> ConnectaPostgre()
        {
            var ping = Ping();
            if (!ping.IsError) ping.Content = new PostgreTables().ListaSchema();
            return ping;
        }

        public RequestMessage<List<string>> Ping()
        {
            using (var r = ExecuteReader("select now()"))
            {
                if (r.Read())
                    return new RequestMessage<List<string>>
                    {
                        StatusCode = HttpStatusCode.OK,
                        Message = "Conexão com POSTGRE efetuada com sucesso!"
                    };
            }

            return new RequestMessage<List<string>>
            {
                StatusCode = HttpStatusCode.InternalServerError,
                Message = "Não foi possível connectar!"
            };
        }
    }
}