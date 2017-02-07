using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class FunctionsFiles
    {
        ItensFrame its =  new ItensFrame();
        private string file_path;

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

        public string filePath
        {
            get { return file_path; }
        }

        //guardar o path dos files
        public void Store(string file, string _Iddisciplina, int _Idaluno)
        {
            string destination = utilites._Inicialpath + _Iddisciplina + "/" + _Idaluno;
            file_path = destination + "/" + Path.GetFileName(file);
            if (!File.Exists(file_path))
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
