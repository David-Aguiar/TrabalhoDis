using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class ItensFrame : Form
    {
        private MainFormStudent mfs = new MainFormStudent();
        public ItensFrame()
        {
            InitializeComponent();
        }

        private void ItensFrame_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = GetFunctionsFiles.Instance.Ishowfiles(MainFormStudent.IgetCell);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataBindings.Clear();
            mfs.Show();
            this.Hide();
            this.Close();

        }
    }
}
