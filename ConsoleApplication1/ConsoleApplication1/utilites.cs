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
        //private static bool CheckCreateDirectory = false;
        private string Inicialpath = @"D:\Documents\Nova pasta\";
        private string getPath;

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
        
        //public bool CheckDirectory(string IPath)
        //{
        //    if (!File.Exists(IPath))
        //    {
        //        CheckCreateDirectory = true;

        //    }
        //    else
        //    {
        //        CheckCreateDirectory = false;
        //    }
        //    return CheckCreateDirectory;
        //}
        public void IgetPath(string _IdAluno)
        {
            if (!Directory.Exists(Inicialpath+_IdAluno)== true)
            {
                Directory.CreateDirectory(Inicialpath+_IdAluno);
            }
        }

    }
}
