using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace ConsoleApplication1
{
    class OpenFiles
    {
        public OpenFiles(){}

        Application application = new Application();

        public void OpFilesNotRead(string path)
        {
            Document docNR = application.Documents.Open(path);
        }

        public void OpFilesRead(string path)
        {
            Document docR = application.Documents.Open(path, ReadOnly:true);
        }
    }
}
