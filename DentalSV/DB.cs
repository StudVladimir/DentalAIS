using System;
using MySql.Data.MySqlClient;

namespace DentalSV
{
	public class DB
	{
        
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=bogomol2003;database=DentalSV");
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}