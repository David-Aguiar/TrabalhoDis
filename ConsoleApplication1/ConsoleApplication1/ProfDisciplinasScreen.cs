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
        private ProfScreen ps = new ProfScreen();
        private FormularioTrabalho ft = new FormularioTrabalho();
        private valuesgridview vgv = new valuesgridview();

        public ProfDisciplinasScreen()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ft.Show();
        }

        private void ProfDisciplinasScreen_Load(object sender, EventArgs e)
        {
            vgv.GetdataGrid(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ps.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vgv.getinfocell(dataGridView1, dataGridView2, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vgv.removetrabalho(dataGridView1);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            vgv.OpenFiles(dataGridView2, e);
        }
        
    }
}
