
using MySql.Data.MySqlClient;

namespace ElectiveApp.DataBase
{
    static class SubjectPerforms
    {
        public static bool IsSubjectExist(string name)
        {
            MySqlCommand command = DataBaseIntializer.GetHashConnection().CreateCommand();
            command.CommandText = "SELECT * FROM subjects WHERE name=@param LIMIT 1";
            command.Parameters.AddWithValue("@param", name);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                return reader.HasRows;
            }
        }
    }
}
