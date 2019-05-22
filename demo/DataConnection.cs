using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=N11_T3_QUANLYKHOBANHKEO;Integrated Security=True";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
