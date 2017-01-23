using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LoginState
    {
        #region Singleton - usage: LoginState.GetInstance()

        private static readonly LoginState Instance = new LoginState();

        static LoginState()
        {
        }

        private LoginState()
        {
        }

        public static LoginState GetInstance()
        {
            return Instance;
        }

        #endregion

        public static void LoginUser()
        {
            LoginConection.CheckConection();
        }
    }
}
