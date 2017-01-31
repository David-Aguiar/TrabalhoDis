using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class utilites
    {
        private string SqlString, disciplinaquery, getpath;


        public string getSqlConnection
        {
            get { return SqlString; }
            set { SqlString = "host=127.0.0.1; user=root; database=mydb"; }
        }

        public string getdisciplinaquery
        {
            get { return disciplinaquery; }
            set { disciplinaquery = "SELECT `disciplinas`.`nome` FROM `disciplinas`, `aluno` WHERE `aluno`.`id`=`disciplinas`.`id`"; }
        }

        public string Igetpath
        {
            get { return getpath; }
            set { getpath = value; }
        }

}
}
