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
        private static MainFormStudent mfs = new MainFormStudent();
        private static ProfScreen profs = new ProfScreen();

        public LoginForm()
        {
            InitializeComponent();

        }
        //função que faz o login e onde faz a vericação se o utilizador é aluno ou docente
        private void button1_Click(object sender, EventArgs e)
        {
            Login.iemail = textBox1.Text;
            Login.ipassword = textBox2.Text;
            Login.LoginAluno();
            if (Login.correct == true)
            {
                if (Login.iresult == 2)
                {
                    mfs.Show();
                    this.Hide();
                }
                else
                {
                    profs.Show();
                    this.Hide();
                }

            }
        }
        //Função para sair da app
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}