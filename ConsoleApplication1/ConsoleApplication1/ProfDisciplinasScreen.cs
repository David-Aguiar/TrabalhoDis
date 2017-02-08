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
            vgv.GetdataGrid(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            //if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    pathtrabalho = dataGridView2.CurrentRow.Cells["path_file"].Value.ToString();
            //    _OpenFIles.Instance.NotRead(pathtrabalho);
            //}
        }
    }
}
