using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class _OpenFIles
    {
        private static _OpenFIles instance;

        private _OpenFIles() { }

        public static _OpenFIles Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new _OpenFIles();
                }
                return instance;
            }
        }

        private OpenFiles of = new OpenFiles();

        public void OnlyRead(string path)
        {
            of.OpFilesRead(path);
        }

        public void NotRead(string path)
        {
            of.OpFilesNotRead(path);
        }
    }
}
