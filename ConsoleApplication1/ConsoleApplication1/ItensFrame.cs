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
    public partial class ItensFrame : Form
    {
        private MainFormStudent mfs = new MainFormStudent();
        public ItensFrame()
        {
            InitializeComponent();
        }

        private void ItensFrame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mfs.Show();
            this.Hide();

        }
    }
}
