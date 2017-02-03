using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class getUtilities
    {
        private static bool Icheck;
        private static getUtilities instance;
        public string Inicialpath { get; }
        private getUtilities() { }
        public static getUtilities Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new getUtilities();
                }
                return instance;
            }
        }

        private utilites ult = new utilites();

        public void IcreateDirectory(int idaluno, string disciplinaNome)
        {
            if(ult.CheckDirectory(idaluno, disciplinaNome) == false)
            {
                Directory.CreatsubDirectory("asda");
            }
            else
            {
                MessageBox.Show("Foi creado");
            }
        }
    }
}
