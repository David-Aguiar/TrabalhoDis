using System;
using System.Data;
using System.Windows.Forms;

namespace ConsoleApplication1
{

    class Login
    {
        private static string email, password;
        private static int count, result = 0;
        public static bool correct = false;

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
        public static bool LoginAluno()
        {

            DataTable DT = ComunicacaoBD.Instance.QueryLogin(email, password);
            count = DT.Rows.Count;

            if (email == "" || password  == "")
            {
                MessageBox.Show("Please provide UserName and Password");
            }
            else
            {
                if (count == 1)
                {
                    result = DT.Rows[0].Field<Int32>("id");
                    correct = true;
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                    correct = false;
                }
            }

            return correct;
        }

    }
    }
