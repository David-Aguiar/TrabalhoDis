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
        private static getUtilities instance;
        public string Inicialpath { get; private set; }
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

        public void IcreateDirectory(string aluno)
        {
            ult.IgetPath(aluno);
        }
    }
}
