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
        private static Entrega entrega = new Entrega();

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
            if (isAnySelected(dataGridView2) == true)
            {
                entrega.GetDataGrid2(dataGridView2, e, listBox1);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("clicked");
            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            dataGridView1.Rows[e.RowIndex].Selected = true;
            dataGridView1.Focus();
        }


    }
}
