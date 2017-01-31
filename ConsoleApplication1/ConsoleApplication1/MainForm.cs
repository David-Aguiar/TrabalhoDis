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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { Conection.connect(); }
            catch { }
            if(LoginState.Conection_State() == true)
            {
                //Application.Run(new LoginForm());
                LoginForm lf = new LoginForm();
                this.Hide();
                lf.Show();
                //this.Close();

            }
            else
            {
                MessageBox.Show("Don't Exit Connection");
            }
        }
    }
}
