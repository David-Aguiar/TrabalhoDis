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
        //private string Inicialpath = @"D:\Documents\Nova pasta\";
        private string Inicialpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

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

        public void IgetPath(string _IdAluno)
        {
            if (!Directory.Exists(Inicialpath+_IdAluno)== true)
            {
                //Directory.CreateDirectory(Inicialpath+"\\"+Nova Pasta+"\\"+_IdAluno);
                Console.WriteLine(Inicialpath + _IdAluno);
            }
        }

    }
}
