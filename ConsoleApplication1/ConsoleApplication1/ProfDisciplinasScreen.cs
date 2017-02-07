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

        public ProfDisciplinasScreen()
        {
            InitializeComponent();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ps.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
