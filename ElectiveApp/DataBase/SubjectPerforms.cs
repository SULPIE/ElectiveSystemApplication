
using MySql.Data.MySqlClient;
using System.Xml.Linq;

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

        public static List<string?> Get()
        {
            List<string?> subjects = new List<string?>();
            subjects.Add("Не указан");

            MySqlCommand command = DataBaseIntializer.GetHashConnection().CreateCommand();
            command.CommandText = "SELECT name FROM subjects";

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    subjects.Add(reader["name"].ToString());
                }
            }

            return subjects;
        }
    }
}
