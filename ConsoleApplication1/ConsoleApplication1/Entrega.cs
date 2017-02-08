using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ConsoleApplication1
{
    class Entrega
    {
        internal void GetDataGrid2(DataGridView dataGridView2, DragEventArgs e, ListBox listBox1)
        {
            //Take dropped items and store in array
            String[] droppedFiles = (String[])e.Data.GetData(DataFormats.FileDrop);
            String colunas = "id, trabalhos_id, utilizador_id, data_entrega, path_file";
            //LOOP THROUGH ITEMS AND DISPLAY THEM
            foreach (String file in droppedFiles)
            {
                String filename = getFileName(file);
                if (!GetFunctionsFiles.Instance.Iexists(file, MainFormStudent.IgetCell, Login.iresult))
                {
                    MessageBox.Show("Ficheiro largado " + filename);
                    listBox1.Items.Add(filename);
                    GetFunctionsFiles.Instance.Istorefiles(file, MainFormStudent.IgetCell, Login.iresult);
                    int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                    string trabalho_id = Convert.ToString(selectedRow.Cells["id"].Value);
                    string path = GetFunctionsFiles.Instance.Ifilepath();
                    string escapedPath = path.Replace(@"\", @"\\").Replace("'", @"\'");
                    string valores = "NULL, '" + trabalho_id + "', '" + Login.iresult + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + escapedPath + "'";
                    ComunicacaoBD.Instance.Insere("trabalhos_utilizador", colunas, valores);
                }
                else
                {
                    MessageBox.Show("O ficheiro " + filename + " já existe.");
                }
            }
        }

        private string getFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }
    }

    
}
