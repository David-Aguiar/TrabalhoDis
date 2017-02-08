using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class ProfDisciplinasScreen : Form
    {
        private static ProfScreen ps = new ProfScreen();
        private static FormularioTrabalho ft = new FormularioTrabalho();
        private static valuesgridview vgv = new valuesgridview();
        private static int idtrabalho;
        private static string pathtrabalho;

        public ProfDisciplinasScreen()
        {
            InitializeComponent();
        }
        public static int _idtrabalho
        {
            get { return idtrabalho; }
            set { idtrabalho = value; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ft.Show();
            this.Hide();
        }

        private void ProfDisciplinasScreen_Load(object sender, EventArgs e)
        {
            vgv.GetdataGrid(dataGridView1);
            vgv.GetdataGrid2(dataGridView2);
            ////dataGridView2.AllowUserToAddRows = false;
            //dataGridView2.RowHeadersVisible = false;
            //dataGridView2.Columns[2].Visible = false;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ps.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                idtrabalho = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (this.dataGridView1.SelectedRows.Count == 1)
                {
                    dataGridView2.DataSource = ComunicacaoBD.Instance.getTrabalhosProf(idtrabalho);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(idtrabalho == 0)
            {
                MessageBox.Show("Por favor Selecione o Trabalho primeiro");
            }
            else
            {
                ComunicacaoBD.Instance.DeleteTrabalho(idtrabalho);
                dataGridView1.DataSource = ComunicacaoBD.Instance.gettrabalhos(Login.iresult);
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                pathtrabalho = dataGridView2.CurrentRow.Cells["path_file"].Value.ToString();
                Console.WriteLine(pathtrabalho);
                _OpenFIles.Instance.NotRead(pathtrabalho);
            }
        }
    }
}
