using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DayBook
{
    public class DBConn
    {
        public static SqlConnection Connection { get; private set; }
        private DBConn() { }
        public static void SetConnection(string connStr)
        {
            if(Connection == null)
                Connection = new SqlConnection(connStr);
        }
    }
}
