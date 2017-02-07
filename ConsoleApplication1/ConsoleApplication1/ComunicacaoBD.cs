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
		//query para obter o id e o nome do utilizador quando entra na app
		public DataTable QueryInnerJoin(int id)
		{
			return BD.Query("Select disciplinas.nome, disciplinas.id From utilizador_disciplinas inner join disciplinas Where utilizador_disciplinas.utilizador_id = " +id+" and utilizador_disciplinas.disciplinas_id = disciplinas.id");	
		}
		//query para o login
		public DataTable QueryLogin(string email, string password)
		{
			return BD.Query("SELECT id, email, password, tipo_utilizador_id FROM utilizador WHERE email='"+email+"' AND password='"+password+"'");
		}
		
		//public DataTable QueryGeral(String tabela, String coluna, int id)
		//{
		//	return BD.Query("SELECT "+coluna+" FROM "+tabela+" WHERE ID="+id);
		//}
		
        public void Insere(String Tabela, String Colunas, String Valores)
        {
            BD.Query("INSERT INTO "+Tabela+" ("+Colunas+") VALUES ("+Valores+")");
        }

        // Fazer query para ir buscar os trabalhos da disciplina correcta

        public DataTable Trabalhos_Disciplina(int utilizador, int disciplina)
        {
            return BD.Query("Select trabalhos_utilizador.path_file From trabalhos_utilizador inner join trabalhos Where trabalhos_utilizador.utilizador_id = "+utilizador+" and trabalhos.disciplinas_id = "+disciplina+"");
        }
        //query para obter os trabalhos 
        public DataTable gettrabalhos(int disciplina)
        {
            return BD.Query("Select trabalhos.descricao, trabalhos.data_inicio_entrega, trabalhos.data_fim_entrega From trabalhos Where trabalhos.disciplinas_id = " + disciplina + "");
        }
        //query para inserir novos os trabalhos
        public void InsereDataTrabalho(string Idescricao, string dataInicio, string datafim, int idisciplina)
        {
            BD.Query("Insert Into trabalhos (descricao, data_inicio_entrega, data_fim_entrega, disciplinas_id) Values ('" + Idescricao+"','"+ dataInicio +"', '"+ datafim +"', '"+ idisciplina+"')");
        }

    //    public void DeleteTrabalho()
    }
}