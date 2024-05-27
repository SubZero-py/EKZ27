using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condi
{
    public static class Databasehelper
    {
        private static string connectionString = @"Data Source=DESKTOP-J6F7HUS\SQLEXPRESS; Initial Catalog=Condi;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
