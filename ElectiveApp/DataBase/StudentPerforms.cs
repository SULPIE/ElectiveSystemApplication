using MySql.Data.MySqlClient;

namespace ElectiveApp.DataBase
{
    internal static class StudentPerforms
    {
        public static bool IsStudentExist(string name)
        {
            MySqlCommand command = DataBaseIntializer.GetHashConnection().CreateCommand();
            command.CommandText = "SELECT * FROM students WHERE nsp=@param LIMIT 1";
            command.Parameters.AddWithValue("@param", name);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                return reader.HasRows;
            }
        }

        public static List<string?> Get()
        {
            List<string?> subjects = new List<string?>();
            subjects.Add("Не указан");

            MySqlCommand command = DataBaseIntializer.GetHashConnection().CreateCommand();
            command.CommandText = "SELECT nsp FROM students";

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    subjects.Add(reader["nsp"].ToString());
                }
            }

            return subjects;
        }
    }
}
