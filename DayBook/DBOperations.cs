using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DayBook
{
    class DBOperations
    {
        public void DBAddNewItem(string date, string data)
        {
            SqlConnection connection = DBConn.Connection;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"INSERT INTO (Date, Task) VALUES ('{date}', '{data}')";
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Problem with database");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
