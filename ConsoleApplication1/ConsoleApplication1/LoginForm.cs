using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

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

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

    }
}
