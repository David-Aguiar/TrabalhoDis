using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class FunctionsFiles
    {
        public static string Inicialpath { get; private set; }

        private string[] Ifiles = Directory.GetFiles(Inicialpath + "\\");

        public FunctionsFiles()
        {

        }

        public void showFiles()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("teste");
                for (int i = 0; i < Ifiles.Length; i++)
                {
                    FileInfo file = new FileInfo(Ifiles[i]);
                    table.Rows.Add(file.Name);
                }
            }
            catch
            {
                MessageBox.Show("Eroo ao Display dos files");
            }

        } 
    }
}
