using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class GetFunctionsFiles
    {
        private static GetFunctionsFiles instance;

        private GetFunctionsFiles() {}

        public static GetFunctionsFiles Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GetFunctionsFiles();
                }
                return instance;
            }
        }
        private FunctionsFiles fl = new FunctionsFiles();

        public DataTable Ishowfiles(string disciplina, int aluno)
        {
            return fl.showFiles(disciplina, aluno);
        }
    }
}
