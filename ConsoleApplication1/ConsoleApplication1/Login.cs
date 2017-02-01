using System;
using System.Data;
using System.Windows.Forms;

namespace ConsoleApplication1
{

    class Login
    {
        private static string email, password;
        private static int count, result = 0;

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
            if (email == "" || password  == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }

            DataTable DT = ComunicacaoBD.Instance.QueryLogin(email, password);
            result = DT.Rows[0].Field<Int32>("id");
            count = DT.Rows.Count;
            if (count == 1)
            {
                MessageBox.Show("Login Successful!");
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }

    }
    }
