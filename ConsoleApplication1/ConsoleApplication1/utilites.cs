using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public class utilites
    {
        private string Inicialpath = @"D:\Documents\Nova pasta";
        public utilites()
        {
            try
            {
                if (!Directory.Exists(Inicialpath))
                {
                    Directory.CreateDirectory(Inicialpath);
                }
            }
            catch
            {
                MessageBox.Show("Problema ao criar a pasta");
            }
        }
        public void directoryaluno(int IdAluno ,string disciplinaNome )
        {
            if (!Directory.Exists(Inicialpath + "\\"+ IdAluno + disciplinaNome))
            {
                Directory.CreateDirectory(Inicialpath + "\\" + IdAluno + disciplinaNome);
            }
            
        }

}
}
