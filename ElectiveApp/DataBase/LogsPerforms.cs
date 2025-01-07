using MySql.Data.MySqlClient;

namespace ElectiveApp.DataBase
{
    internal static class LogsPerforms
    {
        public static void Add(string table, string author, string action)
        {
            MySqlConnection _connection = DataBaseIntializer.GetHashConnection();

            if (_connection == null) return;

            MySqlCommand command = _connection.CreateCommand();

            command.CommandText = "INSERT INTO logs(`table`, `author`, `action`) VALUES (@Param1, @Param2, @Param3)";

            command.Parameters.AddWithValue("@Param1", table);
            command.Parameters.AddWithValue("@Param2", author);
            command.Parameters.AddWithValue("@Param3", action);

            command.ExecuteNonQuery();
        }
    }
}
