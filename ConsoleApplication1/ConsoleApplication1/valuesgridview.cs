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
        private static int values, idtrabalho;
        private static string pathtrabalho;

        public static int Ivalues
        {
            get { return values; }
            set { values = value; }
        }

        public static int _idtrabalho
        {
            get { return idtrabalho; }
            set { idtrabalho = value; }
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
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Columns[2].Visible = false;

        }

        internal void getinfocell(DataGridView dataGridView1, DataGridView dataGridView2, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                idtrabalho = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    dataGridView2.DataSource = ComunicacaoBD.Instance.getTrabalhosProf(idtrabalho);
                    GetdataGrid2(dataGridView2);
                }
            }
        }

        internal void removetrabalho(DataGridView dataGridView1)
        {
            if (idtrabalho == 0)
            {
                MessageBox.Show("Por favor Selecione o Trabalho primeiro");
            }
            else
            {
                ComunicacaoBD.Instance.DeleteTrabalho(idtrabalho);
                dataGridView1.DataSource = ComunicacaoBD.Instance.gettrabalhos(Login.iresult);
            }
        }

        internal void OpenFiles(DataGridView dataGridView2, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value != null)
            {
                pathtrabalho = dataGridView2.CurrentRow.Cells["path_file"].Value.ToString();
                _OpenFIles.Instance.NotRead(pathtrabalho);
            }
        }
    }
}
