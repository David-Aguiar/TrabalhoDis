using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class valuesgridview
    {
        private static int values = 0;

        public static int Ivalues
        {
            get { return values; }
            set { values = value; }
        }

        internal void GetdataGrid(DataGridView dataGridView1)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = ComunicacaoBD.Instance.gettrabalhos(Login.iresult);
            dataGridView1.Columns[3].Visible = false;
        }

        internal void GetdataGrid2(DataGridView dataGridView2)
        {
            
        }
    }
}
