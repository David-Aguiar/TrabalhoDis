using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Diagnostics;
using System.IO;

namespace ConsoleApplication1
{
    class OpenFiles
    {
        public OpenFiles(){}

        Application application = new Application();
        object objMissing = System.Reflection.Missing.Value;


        //abrir ficheiro só em modo de leitura
        public void OpFilesNotwrite(string path)
        {
            //Document docNR = application.Documents.Open(path, ref objMissing, true, ref objMissing, ref objMissing, ref objMissing,
            //    ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing,
            //    ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing);
            //application.Quit();

            FileInfo finfo = new FileInfo(path);
            finfo.Attributes = FileAttributes.ReadOnly;
            Process.Start(path);
        }

        //abrir os ficheiros
        public void OpFileswrite(string path)
        {
            //Document docR = application.Documents.Open(path);
            //application.Visible = true;
            //docR.Activate();

            Process.Start(path);
        }
    }
}
