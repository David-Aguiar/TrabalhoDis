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

        public void Istorefiles(string file, string _Iddisciplina, int _Idaluno)
        {
            fl.Store(file, _Iddisciplina, _Idaluno);
        }

        public bool Iexists (string file, string _Iddisciplina, int _Idaluno)
        {
            return fl.Exists(file, _Iddisciplina, _Idaluno);
        }


    }
}
