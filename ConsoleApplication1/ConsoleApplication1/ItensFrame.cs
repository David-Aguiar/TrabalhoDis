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
            fillListBox();
            fillDataGridView2();
            fillDataGridView1();
        }

        private void fillListBox()
        {
            DataTable DT = GetFunctionsFiles.Instance.Ishowfiles(MainFormStudent.IgetCell, Login.iresult);
            foreach (DataRow row in DT.Rows)
            {
                listBox1.Items.Add(row[0]);
            }
        }

        private void fillDataGridView2()
        {
            DataTable DT2 = ComunicacaoBD.Instance.QueryTrabalhos("trabalhos", "*", "disciplinas_id", MainFormStudent.IgetCell);
            dataGridView2.DataSource = null;
            if (DT2.Rows.Count > 0)
            {
                dataGridView2.DataSource = DT2;
                dataGridView2.RowHeadersVisible = false;
                dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[4].Visible = false;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.Rows[0].Selected = false;
            }
        }

        private void fillDataGridView1()
        {
            DataTable DT3 = ComunicacaoBD.Instance.QueryAlunos(Login.iresult, MainFormStudent.IgetCell);
            dataGridView1.DataSource = null;
            if (DT3.Rows.Count > 0)
            {
                dataGridView1.DataSource = DT3;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Rows[0].Selected = false;
            }
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
            if(datagrid.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
                        int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                        string trabalho_id = Convert.ToString(selectedRow.Cells["id"].Value);
                        string path = GetFunctionsFiles.Instance.Ifilepath();
                        string escapedPath = path.Replace(@"\", @"\\").Replace("'", @"\'");
                        string valores = "NULL, '" + trabalho_id + "', '" + Login.iresult + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '"+escapedPath+"'";
                        ComunicacaoBD.Instance.Insere("trabalhos_utilizador", colunas, valores);
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
                MessageBox.Show("Por favor, selecione um trabalho a entregar antes de arrastar o ficheiro");
                
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
            //
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

    }
}
