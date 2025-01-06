using MySql.Data.MySqlClient;

namespace ElectiveApp.DataBase
{
    internal static class UserPerforms
    {
        public static bool IsUserExist(string login, string password)
        {
            MySqlCommand command = DataBaseIntializer.GetHashConnection().CreateCommand();
            command.CommandText = "SELECT login FROM users WHERE login=@login AND password=@password LIMIT 1";
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                return reader.HasRows;
            }
        }
    }
}
