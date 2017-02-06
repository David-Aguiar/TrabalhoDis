using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class FunctionsFiles
    {
        //public static string Inicialpath { get; private set; }
        //public static string IgetCell { get; private set;  }

        //private string Ifiles = @"D:\Documents\NovaPasta\";
        //private string[] I_files = Directory.GetFiles(@"D:\Documents\NovaPasta\" + IgetCell);

        public FunctionsFiles()
        {

        }

        public DataTable showFiles(string idaluno)
        {
            DataTable itable = new DataTable();
            Console.WriteLine("Ruben");
            Console.WriteLine(utilites._Inicialpath);
            Console.WriteLine("Ruben 2");
            string[] I_files = Directory.GetFiles(utilites._Inicialpath +"/"+idaluno);
            Console.WriteLine(I_files);
            string teste = @"D:\Documents\NovaPasta\" + idaluno;
            try
            {

                itable.Columns.Add("teste");
                for (int i = 0; i < I_files.Length; i++)
                {
                    FileInfo file = new FileInfo(I_files[i]);
                    itable.Rows.Add(file.Name);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao Display dos files");
            }
            Console.WriteLine(teste);
            return itable;

        }
    }
}
