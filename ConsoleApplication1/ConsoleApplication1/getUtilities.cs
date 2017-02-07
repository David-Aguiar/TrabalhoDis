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

        //chamada da função IgetPath
        public void IcreateDirectory(string disciplina, int idaluno)
        {
            ult.IgetPath(disciplina, idaluno);
        }
    }
}
