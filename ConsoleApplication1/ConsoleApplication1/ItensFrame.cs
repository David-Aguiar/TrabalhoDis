using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class ItensFrame : Form
    {
        private MainFormStudent mfs = new MainFormStudent();
        //public static string Inicialpath { get; private set; }
        //private string[] Ifiles = Directory.GetFiles(Inicialpath + "\\");
        public ItensFrame()
        {
            InitializeComponent();
        }

        private void ItensFrame_Load(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                dataGridView1.DataSource = GetFunctionsFiles.Instance.Ishowfiles(MainFormStudent.IgetCell);
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
            //DataTable table = new DataTable();
            //table.Columns.Add("teste");
            //for (int i = 0; i < Ifiles.Length; i++)
            //{
            //    FileInfo file = new FileInfo(Ifiles[i]);

            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            mfs.Show();
            this.Hide();

        }
    }
}
