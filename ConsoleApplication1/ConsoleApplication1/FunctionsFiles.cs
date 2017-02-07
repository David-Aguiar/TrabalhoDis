using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class FunctionsFiles
    {
        ItensFrame its =  new ItensFrame();
        public FunctionsFiles()
        {

        }
        //Display dos files, nas pastas das disciplinas
        public DataTable showFiles(string _Iddisciplina, int _Idaluno)
        {
            DataTable itable = new DataTable();
            string[] I_files = Directory.GetFiles(utilites._Inicialpath + _Iddisciplina + "/" + _Idaluno);
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
            return itable;

        }
        //guardar o path dos files
        public void Store(string file, string _Iddisciplina, int _Idaluno)
        {
            string destination = utilites._Inicialpath + _Iddisciplina + "/" + _Idaluno;
            if (!File.Exists(destination + "/" + Path.GetFileName(file)))
            {
                File.Copy(file, Path.Combine(destination, Path.GetFileName(file)));
            }
        }

        public bool Exists(string file, string _Iddisciplina, int _Idaluno)
        {
            string destination = utilites._Inicialpath + _Iddisciplina + "/" + _Idaluno;
            if (File.Exists(destination + "/" + Path.GetFileName(file)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
