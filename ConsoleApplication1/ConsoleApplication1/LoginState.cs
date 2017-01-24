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

        public static bool  Conection_State()
        {

            //switch(Conection.sqlconnection.State != ConnectionState.Open)
            //{
            //    case true: State = true;
            //        break;
            //    case false: State = false;
            //        break;
            //}

            return Conection.sqlconnection.State == ConnectionState.Open;

        }
    }
}
