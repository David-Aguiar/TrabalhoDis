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
		
		public DataTable QueryGeral(String tabela, String coluna, int id)
		{
			return BD.Query("SELECT "+coluna+" FROM "+tabela+" WHERE ID="+id);
		}

        public DataTable QueryTrabalhos(String tabela, String coluna1, String coluna2, string id)
        {
            return BD.Query("SELECT " + coluna1 + " FROM " + tabela + " WHERE "+ coluna2 +"=" + id);
        }

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
            return BD.Query("Select trabalhos.descricao, trabalhos.data_inicio_entrega, trabalhos.data_fim_entrega, trabalhos.id From trabalhos Where trabalhos.disciplinas_id = " + disciplina + "");
        }
        //query para inserir novos os trabalhos
        public void InsereDataTrabalho(string Idescricao, string dataInicio, string datafim, int idisciplina)
        {
            BD.Query("Insert Into trabalhos (descricao, data_inicio_entrega, data_fim_entrega, disciplinas_id) Values ('" + Idescricao+"','"+ dataInicio +"', '"+ datafim +"', '"+ idisciplina+"')");
        }

         public void DeleteTrabalho(int idtrabalho)
        {
            BD.Query("DELETE FROM trabalhos WHERE trabalhos.id = " + idtrabalho);
        }

        public DataTable getTrabalhosProf()
        {
            return BD.Query("Select trabalhos_utilizador.utilizador_id, trabalhos_utilizador.data_entrega, trabalhos_utilizador.path_file  From trabalhos_utilizador");
        }

        public DataTable QueryAlunos(int id_aluno,string disciplina)
        {
            return BD.Query("SELECT utilizador.id, utilizador.nome FROM utilizador INNER JOIN utilizador_disciplinas WHERE utilizador_disciplinas.id=" + disciplina + " AND utilizador.tipo_utilizador_id='2' AND utilizador.id!="+id_aluno+"");
        }
    }
}