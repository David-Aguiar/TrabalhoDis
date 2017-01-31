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
        public MainFormStudent()
        {
            InitializeComponent();
        }

        private utilites ult = new utilites();

        private static List<int> items = new List<int>();

        private static int resultadoId = 0;
        private static string getCell;

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
            dataGridView1.DataSource = alunoInfo();
        }

        private DataTable alunoInfo()
        {
            //MySqlConnection Con = new MySqlConnection("host=127.0.0.1; user=root; database=mydb");
            //Con.Open();
            ComunicacaoBD.Instance.
            //MySqlCommand sql = new MySqlCommand("Select disciplinas.nome From aluno_disciplinas inner join disciplinas Where aluno_disciplinas.Aluno_id = @id and aluno_disciplinas.Disciplinas_id = disciplinas.id ", Con);
            //sql.CommandText = "Select disciplinas.nome FROM disciplinas WHERE disciplinas.id = 1 ";
            sql.Parameters.AddWithValue("@id", Login.iresult);
            //MySqlDataAdapter datapdater = new MySqlDataAdapter(sql);
            //DataTable datatable = new DataTable();
            //datapdater.Fill(datatable);
            DataTable dt = ComunicaBD.
            MySqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }
            Con.Close();
            return datatable;
        }
        private void selectforder_Click(object sender, EventArgs e)
        {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                fbd.Description = "Selecione Pasta";
                fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                ult.Igetpath = fbd.SelectedPath;
                MessageBox.Show(ult.Igetpath);
            }
            else
            {
                selectforder.Enabled = false;
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ItensFrame isf = new ItensFrame();
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                getCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                MessageBox.Show(ult.Igetpath);
            }
            isf.MdiParent = this;
            isf.Show();
        }
    }
    }

