using MySqlConnector;
using SheckSheck_Kiosk.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.Util
{
    class DBConnection
    {
        private MySqlConnection connection = null;
        private MySqlCommand command = null;

        public void Connect()
        {
            string strDBConnection = DBConfig.GetDBConnectionString();
            Console.WriteLine(strDBConnection);
            connection = new MySqlConnection(strDBConnection);
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void SetCommand(string strCommand)
        {
            command = new MySqlCommand(strCommand, connection);
        }

        public int Execute()
        {
            return command.ExecuteNonQuery();
        }

        public MySqlDataReader ExecuteQuery()
        {
            return command.ExecuteReader();
        }
    }
}
