using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class FunctionsFiles
    {
        public static string Inicialpath { get; }
        //public static string IgetCell { get; private set;  }

        //private string Ifiles = @"D:\Documents\NovaPasta\";
        //private string[] I_files = Directory.GetFiles(@"D:\Documents\NovaPasta\" + IgetCell);

        public FunctionsFiles()
        {

        }

        public DataTable showFiles(string idaluno)
        {
            DataTable itable = new DataTable();
            string[] I_files = Directory.GetFiles(Inicialpath + @"\NovaPasta\" + @"\"+ idaluno);
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
