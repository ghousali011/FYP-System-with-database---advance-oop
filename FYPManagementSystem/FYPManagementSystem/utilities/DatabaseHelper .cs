using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class DatabaseHelper
    {
        //private String serverName = "192.168.100.10"; // wifi
        //private String serverName = "10.59.67.48"; // phone
        private String serverName = "localhost"; // root
        private String port = "3306";
        private String databaseName = "middb26_2025cs1";
        //private String databaseUser = "middb26_2025cs1";
        //private String databasePassword = "Ghous12345";

        private String databaseUser = "root";
        private String databasePassword = "Ghous$011218$";

        private DatabaseHelper() { }

        private static DatabaseHelper _instance;
        public static DatabaseHelper Instance //built by maam hafsa
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseHelper();
                return _instance;
            }
        }

        public MySqlConnection getConnection()
        {
            string connectionString =
                $"server={serverName};port={port};user={databaseUser};database={databaseName};password={databasePassword};SslMode=Preferred;";

            var connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }

        public MySqlDataReader getData(string query)
        {
            var connection = getConnection();
            var command = new MySqlCommand(query, connection);

            return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        public int Update(string query)
        {
            using (var connection = getConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                return command.ExecuteNonQuery();
            }
        }

    }
}
