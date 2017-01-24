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
        

        public LoginForm()
        {
            InitializeComponent();
            Conection.connect();
        }

        String cs = @"host=127.0.0.1; user=root; database=mydb";

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

            MySqlConnection Con = new MySqlConnection(cs);
            MySqlCommand sql = new MySqlCommand("Select email, password From aluno where email=@email and password=@password", Con);
            sql.Parameters.AddWithValue("@email", textBox1.Text);
            sql.Parameters.AddWithValue("@password", textBox2.Text);
            Con.Open();
            MySqlDataAdapter adapt = new MySqlDataAdapter(sql);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            Con.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                MessageBox.Show("Login Successful!");
                MainFormStudent f2 = new MainFormStudent();
                this.Hide();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //private void LoginStateIcon_Click(object sender, EventArgs e)
        //{

         //    if (LoginState.Conection_State() == true)
         //    {
         //        LoginStateIcon.Image = new Bitmap(Properties.Resources.On);
         //        LoginStateIcon.SizeMode = PictureBoxSizeMode.StretchImage;
         //    }
         //    else
         //    {
         //        LoginStateIcon.Image = Properties.Resources.off;
         //    }

         //}

        private void ILoginStateIcon(object sender, AsyncCompletedEventArgs e)
        {
            if (LoginState.Conection_State() == true)
            {
                LoginStateIcon.Image = Properties.Resources.On;

            }
            else
            {
                LoginStateIcon.Image = Properties.Resources.off;
            }
        }
    }
}
