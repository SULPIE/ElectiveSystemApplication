using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectiveApp.DataBase
{
    internal class DataBaseIntializer
    {
        private static MySqlConnection connection = new();

        public DataBaseIntializer() {}

        public static MySqlConnection GetHashConnection()
        {
            return connection;
        }

        public static void InitConnection()
        {
            string SQLconnection = $"SERVER={Utils.Host}; DATABASE = {Utils.Base}; UID = {Utils.User}; PASSWORD = {Utils.Pass}";
            connection = new MySqlConnection(SQLconnection);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Не удается подключиться к базе данных");
                return;
            }
        }
    }
}
