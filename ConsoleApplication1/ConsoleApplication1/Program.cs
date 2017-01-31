using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Conection.connect();

            if (LoginState.Conection_State () == true)
            {
                Application.Run(new LoginForm());
            }
            else
            {
                Application.Run(new MainForm());
            }
            
        }
    }
}
