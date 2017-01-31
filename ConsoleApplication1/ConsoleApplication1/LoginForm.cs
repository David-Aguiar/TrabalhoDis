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
            //Conection.connect();
            MainForm mf = new MainForm();
            mf.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            Login.iemail = textBox1.Text;
            Login.ipassword = textBox2.Text;
            Login.LoginAluno();
            this.Hide();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
