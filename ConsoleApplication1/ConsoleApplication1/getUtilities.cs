using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class getUtilities
    {
        private static getUtilities instance;
        private getUtilities() { }
        public static getUtilities Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new getUtilities();
                }
                return instance;
            }
        }
        private utilites ult = new utilites();
    }
}
