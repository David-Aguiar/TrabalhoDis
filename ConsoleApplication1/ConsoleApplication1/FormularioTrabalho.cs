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
    public partial class FormularioTrabalho : Form
    {

        public FormularioTrabalho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComunicacaoBD.Instance.InsereDataTrabalho(this.textBox1.Text, this.dateTimePicker1.Text, this.dateTimePicker2.Text , Convert.ToInt32(ProfScreen.IgetCellProf));
            this.Hide();
        }
    }
}
