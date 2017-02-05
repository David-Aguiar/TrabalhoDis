using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class ItensFrame : Form
    {
        private MainFormStudent mfs = new MainFormStudent();
        public static string Inicialpath { get; private set; }
        private string[] Ifiles = Directory.GetFiles(Inicialpath + "\\");
        public ItensFrame()
        {
            InitializeComponent();
        }

        private void ItensFrame_Load(object sender, EventArgs e)
        {
            //GetFunctionsFiles.Instance.Ishowfiles();
            DataTable table = new DataTable();
            table.Columns.Add("teste");
            for (int i = 0; i < Ifiles.Length; i++)
            {
                FileInfo file = new FileInfo(Ifiles[i]);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mfs.Show();
            this.Hide();

        }
    }
}
