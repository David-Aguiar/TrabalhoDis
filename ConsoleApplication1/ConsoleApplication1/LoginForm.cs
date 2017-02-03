using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.ComponentModel;

namespace ConsoleApplication1
{
    public partial class LoginForm : Form
    {
        public static string passtext;

        public LoginForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            Login.iemail = textBox1.Text;
            Login.ipassword = textBox2.Text;
            Login.LoginAluno();
            MainFormStudent mfs = new MainFormStudent();
            this.Hide();
            mfs.Show();
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}