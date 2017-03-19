﻿using System.Linq;
using System.Text;
using Zeus.Core;
using Zeus.Linguagens.Base;

namespace Zeus.Linguagens.CSharp.Firebird.Direct
{
    public class CSharpFirebirdDirect : BaseFirebirdDAO
    {

        public CSharpFirebirdDirect(string nomeTabela) : base(nomeTabela)
        {
        }

        private StringBuilder Imports()
        {
            var imports = new StringBuilder();
            imports.Append($"using System.Windows.Forms;{N}{N}");
            return imports;
        }

        private StringBuilder GetById()
        {
            var get = new StringBuilder();
            get.Append($"    	public IDataReader GetById(int ID){N}");
            get.Append($"    	{{{N}");
            get.Append($"    	 	var sql = $\"SELECT * FROM {NomeTabela} WHERE {ListaAtributosTabela.First().FIELD_NAME} = {{ ID }}\";{N}");
            get.Append($"    	 	return ExecuteReader(sql);{N}");
            get.Append($"    	}}{N}");
            return get;
        }

        private StringBuilder GetAll()
        {
            var get = new StringBuilder();
            get.Append($"    	public DataTable GetAll(){N}");
            get.Append($"    	{{{N}");
            get.Append($"    	 	var datatable = new DataTable();{N}");
            get.Append($"    	 	var sql = $\"SELECT * FROM {NomeTabela}\";{N}");
            get.Append($"    	 	return ExecuteReaderDt(sql);{N}");
            get.Append($"    	}}{N}");
            return get;
        }

        private StringBuilder Add()
        {
            var get = new StringBuilder();
            get.Append($"    	public void Insert({NomeTabela}Model entidade){N}");
            get.Append($"    	{{{N}");
            get.Append($"    	 	var sql = $\"INSERT INTO {NomeTabela} VALUES\"{N}");
            get.Append(AddParams());
            get.Append($"    	 	ExecuteNonResult(sql); {N}");
            get.Append($"    	 	MessageBox.Show(\"Registro inserido com sucesso !!!\"); {N}");
            get.Append($"    	}}{N}");
            return get;
        }
        private StringBuilder AddParams()
        {
            var param = new StringBuilder();
            var count = ListaAtributosTabela.Count;
            if (count == 0)
                return param;

            param.Append($"    		+$\"({{entidade.{ListaAtributosTabela[0].FIELD_NAME}}}\"+{N}");
            for (int i = 1; i < count - 1; i++)
            {
                param.Append($"    		+$\"{{entidade.{ListaAtributosTabela[i].FIELD_NAME}}},\"+{N}");
            }
            param.Append($"    		+$\"{{entidade.{ListaAtributosTabela[count - 1].FIELD_NAME}}})\";{N}");
            return param;
        }

        private StringBuilder Update()
        {
            var get = new StringBuilder();
            get.Append($"    	public void Update({NomeTabela}Model entidade){N}");
            get.Append($"    	{{{N}");
            get.Append($"    	 	var sql = $\"UPDATE {NomeTabela} SET\" + {N}");
            foreach (var item in ListaAtributosTabela)
            {
                get.Append($"    		+\"{item.FIELD_NAME} = \"+{item.FIELD_NAME}" + N);
            }
            get.Append($"    	 	+$\"WHERE {ListaAtributosTabela.First().FIELD_NAME} = {{ entidade.{ListaAtributosTabela.First().FIELD_NAME}}};\" {N}");
            get.Append($"    	 	ExecuteNonResult(sql); {N}");
            get.Append($"    	 	MessageBox.Show(\"Registro gravado com sucesso !!!\");{N}");
            get.Append($"    	}}{N}");
            return get;
        }
        private StringBuilder Delete()
        {
            var get = new StringBuilder();
            get.Append($"    	public void Delete(int ID){N}");
            get.Append($"    	{{{N}");
            get.Append($"    	 	var sql = $\"DELETE FROM {NomeTabela} WHERE {ListaAtributosTabela.First().FIELD_NAME} = {{ ID }}\"{N}");
            get.Append($"    	 	ExecuteNonResult(sql); {N}");
            get.Append($"    	 	MessageBox.Show(\"Registro excluído com sucesso !!!\"); {N}");
            get.Append($"    	}}{N}");
            return get;
        }

        public StringBuilder GerarClasse()
        {
            var classe = new StringBuilder();
            classe.Append(Imports());
            classe.Append($"namespace meuprojeto{N}{{{N}");
            classe.Append($"    public class {NomeTabela.ToFirstCharToUpper()}Dao : FirebirdRepository {{ {N}{N}");
            classe.Append(GetById());
            classe.Append(N);
            classe.Append(GetAll());
            classe.Append(N);
            classe.Append(Add());
            classe.Append(N);
            classe.Append(Update());
            classe.Append(N);
            classe.Append(Delete());
            classe.Append($"    }}{N}");
            classe.Append($"}}");
            return classe;
        }
    }
}