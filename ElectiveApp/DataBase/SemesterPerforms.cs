using MySql.Data.MySqlClient;

namespace ElectiveApp.DataBase
{
    internal static class SemesterPerforms
    {
        public static void ChangeCurrentSemester(int semester)
        {
            MySqlConnection _connection = DataBaseIntializer.GetHashConnection();

            if (_connection == null) return;

            MySqlCommand command = _connection.CreateCommand();

            command.CommandText = "UPDATE semesters SET numofsemester=@Param WHERE id=1";
            command.Parameters.AddWithValue("@Param", semester);
            command.ExecuteNonQuery();
        }
        
        public static int GetCurrentSemester()
        {
            MySqlConnection connection = DataBaseIntializer.GetHashConnection();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT numofsemester FROM semesters WHERE id=1";

            using MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                return reader.GetInt32("numofsemester");
            }
            else
            {
                return 0;
            }
        }
    }
}
