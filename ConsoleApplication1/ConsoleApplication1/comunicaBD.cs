using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ConsoleApplication1
{
    class comunicaBD
    {
        private MySqlConnection Conexao = new MySqlConnection("host=127.0.0.1; user=root; database=mydb");

        public comunicaBD()
        {
            try
            {
                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro na ligação à base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FechaConexao()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro ao se desligar da base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}