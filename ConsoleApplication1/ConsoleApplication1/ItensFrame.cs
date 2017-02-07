using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace ConsoleApplication1
{
    public partial class ItensFrame : Form
    {

        private MainFormStudent mfs = new MainFormStudent();
        public ItensFrame()
        {
            InitializeComponent();
        }

        private void ItensFrame_Load(object sender, EventArgs e)
        {
                DataTable DT = GetFunctionsFiles.Instance.Ishowfiles(MainFormStudent.IgetCell, Login.iresult);
                foreach (DataRow row in DT.Rows)
                {
                    listBox1.Items.Add(row[0]);
                }

            //checkedListBox1.Items.Clear();
            //    DataTable DT2 = ComunicacaoBD.Instance.QueryTrabalhos("trabalhos", "*", "disciplinas_id", MainFormStudent.IgetCell);
            //    foreach (DataRow row2 in DT2.Rows)
            //    {
            //        checkedListBox1.Items.Add(row2[2]);

            //    }
            DataTable DT2 = ComunicacaoBD.Instance.QueryTrabalhos("trabalhos", "*", "disciplinas_id", MainFormStudent.IgetCell);
            DT2.Columns.Add(new DataColumn("Selected", typeof(bool)));
            dataGridView2.DataSource = DT2;
            dataGridView2.Columns["Selected"].DisplayIndex = 0;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.AllowUserToAddRows = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            this.Close();
            mfs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
 
        }

        //Get file name
        private string getFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        private bool isAnySelected(DataGridView datagrid)
        {
            foreach(DataGridViewRow row in datagrid.Rows)
            {
                DataGridViewCheckBoxCell cbxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                if(cbxCell != null && (bool)cbxCell.Value==true)
                {
                    return true;
                }

            }
            return false;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {

            //bool isAnySelected = checkedListBox1.SelectedIndex != -1;
            Console.WriteLine(isAnySelected(dataGridView2));
            if (isAnySelected(dataGridView2) == true)
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
                        //foreach(object item in dataGridView2.CheckedItems)
                        //{
                        //    string temp = item.ToString();
                        //    Console.WriteLine(temp);
                        //}
                        //String valores = "'NULL', ";
                        //ComunicacaoBD.Instance.Insere("trabalhos_utilizador", colunas, );
                    }
                    else
                    {
                        MessageBox.Show("O ficheiro " + filename + " já existe.");
                    }
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
