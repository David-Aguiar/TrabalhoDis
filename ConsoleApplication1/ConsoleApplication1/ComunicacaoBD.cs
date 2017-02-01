using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ConsoleApplication1
{

    public class ComunicacaoBD
    {
		private static ComunicacaoBD instance;
		
		private ComunicacaoBD() {}
		
		public static ComunicacaoBD Instance
		{
			get
			{
				if(instance == null)
				{
					instance = new ComunicacaoBD();
				}
				return instance;
			}
		}
		
		private ComunicaBD BD = new ComunicaBD();
		
		
		public DataTable NovaQuery(String query)
		{
			return BD.Query(query);
		}
		
		public DataTable QueryInnerJoin(int id)
		{
			return BD.Query("Select disciplinas.nome, disciplinas.id From aluno_disciplinas inner join disciplinas Where aluno_disciplinas.Aluno_id = " + id+" and aluno_disciplinas.Disciplinas_id = disciplinas.id");	
		}
		
		public DataTable QueryLogin(string email, string password)
		{
			return BD.Query("SELECT id, email, password FROM aluno WHERE email="+email+" AND password="+password+"");
		}
		
		public DataTable QueryGeral(String tabela, String coluna, int id)
		{
			return BD.Query("SELECT "+coluna+" FROM "+tabela+" WHERE ID="+id);
		}
		
	}
}