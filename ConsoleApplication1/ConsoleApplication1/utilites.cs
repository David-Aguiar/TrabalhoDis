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
        private static string Inicialpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments)+"/NovaPasta/";

        public static string _Inicialpath
        {
            get { return Inicialpath; }
        }

        public utilites()
        {
            try
            {
                //criação do folder principal
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
        // função para criar os folder das disciplinas + dos alunos;
        public void IgetPath(string _Iddisciplina, int _Idaluno)
        {
            if (!Directory.Exists(Inicialpath + _Iddisciplina +"/"+ _Idaluno) == true)
            {
                Directory.CreateDirectory(Inicialpath+ _Iddisciplina + "/" + _Idaluno);
            }
        }

    }
}
