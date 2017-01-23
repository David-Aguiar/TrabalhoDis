using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ConsoleApplication1
{
    class LoginConection
    {
        public static void CheckConection()
        {
            MySqlConnection sqlconnection = new MySqlConnection("host=127.0.0.1; user=root;database=mydb");
            MySqlCommand sqlQuery = new MySqlCommand("select email From aluno Where Curso_id = 1", sqlconnection);
            MySqlDataAdapter myadapter = new MySqlDataAdapter();
            myadapter.SelectCommand = sqlQuery;
            MySqlDataReader reader = sqlQuery.ExecuteReader();
            
            
            try
            {
                sqlconnection.Open();
                System.Windows.Forms.MessageBox.Show(reader.GetInt32(0));

            }
             catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }  
        }
    }
}
