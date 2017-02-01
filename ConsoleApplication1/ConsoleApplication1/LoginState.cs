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
            return Conection.sqlconnection.State == ConnectionState.Open;
        }
    }
}
