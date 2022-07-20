using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Organiser.classes
{
    static class DatabaseConnectionClass
    {
        public static SqlConnection GetConnection()
        {
            return GetConnection("");
        }

        private static SqlConnection GetConnection(string v)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["Organiser"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(stringConnection);
            return sqlConnection;
        }
    }
}

