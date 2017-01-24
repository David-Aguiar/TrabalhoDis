using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class LoginState
    {
        private static String State;

        public static String Conection_State()
        {

            if (Conection.sqlconnection.State != ConnectionState.Open)
            {
                State = "On";
            }

            else
            {
                State = "Off";
            }

            return State;

        }
    }
}
