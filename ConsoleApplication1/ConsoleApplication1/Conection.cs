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

    class  Conection
    {
        public static MySqlConnection sqlconnection = new MySqlConnection("host=127.0.0.1; user=root; database=mydb");

        public static ConnectionState Open { get; private set; }

        public static void connect()
        {
            while (sqlconnection.State != Open)
            {
                sqlconnection.Open();
            }
            //try
            //{
            //    sqlconnection.Open();
            //}
            //catch { }

        }

    }
}
