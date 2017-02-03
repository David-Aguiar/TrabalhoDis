using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class MainFormStudent : Form
    {
        public static MainFormStudent Instance { get; private set; }

        public MainFormStudent()
        {
            InitializeComponent();
        }

        private utilites ult = new utilites();


        private static int resultadoId = 0;
        private static string  getCell;
        private static ItensFrame ifs = new ItensFrame();

        public static int IresultadoId
        {
            get { return resultadoId; }
            set { resultadoId = value; }
        }

        public static string IgetCell
        {
            get { return getCell; }
            set { getCell = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }
        private void MainFormStudent_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = ComunicacaoBD.Instance.QueryInnerJoin(Login.iresult);
            dataGridView1.Columns[1].Visible = false;        
        }
        //private void selectforder_Click(object sender, EventArgs e)
        //{
        //        FolderBrowserDialog fbd = new FolderBrowserDialog();
        //        fbd.RootFolder = Environment.SpecialFolder.Desktop;
        //        fbd.Description = "Selecione Pasta";
        //        fbd.ShowNewFolderButton = true;
        //    if (fbd.ShowDialog() == DialogResult.OK)
        //    {
        //        ult.Igetpath = fbd.SelectedPath;
        //        MessageBox.Show(ult.Igetpath);
        //    }
        //    else
        //    {
        //        selectforder.Enabled = false;
        //    }
        //}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                getCell = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                Console.Write(getCell);
                //getUtilities.Instance.IcreateDirectory(IresultadoId, getCell);
                getUtilities.Instance.
                ifs.Show();
                this.Hide();
            }
        }

    }
    }

