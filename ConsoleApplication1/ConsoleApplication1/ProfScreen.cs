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
    public partial class ProfScreen : Form
    {
        private static string getCellProf;
        private static ProfDisciplinasScreen pds = new ProfDisciplinasScreen();

        public static string IgetCellProf
        {
            get { return getCellProf; }
            set { getCellProf = value; }
        }
        public ProfScreen()
        {
            InitializeComponent();
        }

        private void ProfScreen_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = ComunicacaoBD.Instance.QueryInnerJoin(Login.iresult);
            dataGridView1.Columns[1].Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                getCellProf = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                getUtilities.Instance.IcreateDirectory(getCellProf, Login.iresult);
                this.Hide();
                pds.ShowDialog(this);
            }
        }
    }
}
