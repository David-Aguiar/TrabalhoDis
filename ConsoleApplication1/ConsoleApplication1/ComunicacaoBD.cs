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

    public class ComunicacaoBD
    {
		private static ComunicacaoBD instance;
		
		private ComunicacaoBD() {}
		
		public static ComunicacaoBD Instance
		{
			get
			{
				if(instance == null)
				{
					instance = new ComunicacaoBD();
				}
				return instance;
			}
		}
		
		private ComunicaBD BD = new ComunicaBD();
		
		
		public DataTable NovaQuery(String query)
		{
			return BD.Query(query);
		}
		
		
	}
}