using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ConsoleApplication1
{

    class Login
    {
        private static string email, password;
        private static int result = 0;

        public static string iemail
        {
            get { return email; }
            set { email = value; }
        }

        public static string ipassword
        {
            get { return password; }
            set { password = value;}
        }
        public static int iresult
        {
            get { return result;}
            set { result = value; }
        }
        public static void LoginAluno()
        {

            utilites link = new utilites();
            MySqlConnection Con = new MySqlConnection("host=127.0.0.1; user=root; database=mydb");
            MySqlCommand sql = new MySqlCommand("Select email, password From aluno where email=@email and password=@password", Con);
            sql.CommandText ="Select id From aluno where email=@email and password=@password";
            sql.Parameters.AddWithValue("@email", email);
            sql.Parameters.AddWithValue("@password", password);
            Con.Open();
            //sdasdasd
            result = ((int)sql.ExecuteScalar());
            MySqlDataAdapter adapt = new MySqlDataAdapter(sql);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            Con.Close();
            int count = ds.Tables[0].Rows.Count;
			
			//DataTable DT = ComunicacaoBD.Instance.QueryLogin(email, password);
			//count  = DT.Rows[0].Count;
            if (count == 1)
            {
                MessageBox.Show("Login Successful!");
                MainFormStudent f2 = new MainFormStudent();
                Console.WriteLine(result);
                f2.Show();

            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }

    }
    }
