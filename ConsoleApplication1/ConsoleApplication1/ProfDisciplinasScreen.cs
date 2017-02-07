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
        private static int idtrabalho; 

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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = ComunicacaoBD.Instance.gettrabalhos(Login.iresult);
            dataGridView1.Columns[3].Visible = false;
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
    }
}
