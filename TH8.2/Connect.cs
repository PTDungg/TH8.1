using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TH8._2
{
    internal class Connect
    {
        public static string strSql = "Data Source=HUNG;Initial Catalog=qli_sv;Integrated Security=True";

        public static SqlConnection getCon()
        {
            return new SqlConnection(strSql);
        }
    }  
}
