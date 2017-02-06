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
            dataGridView1.MouseClick +=new MouseEventHandler(DataGridView1_MouseClick);
            dataGridView1.DataSource = GetFunctionsFiles.Instance.Ishowfiles(MainFormStudent.IgetCell, Login.iresult);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataBindings.Clear();
            this.Close();
            mfs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip popmenu = new ContextMenuStrip();
                int positionTeste = dataGridView1.HitTest(e.X, e.Y).RowIndex;


                if (positionTeste >= 0)
                {
                    popmenu.Items.Add("Send").Name = "Send";
                }

                popmenu.Show(dataGridView1, new System.Drawing.Point(e.X, e.Y));
            }
        }

    }
}
