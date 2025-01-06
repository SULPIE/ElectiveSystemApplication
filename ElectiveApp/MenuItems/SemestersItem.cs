using ElectiveApp.DataBase;
using MySql.Data.MySqlClient;

namespace ElectiveApp.MenuItems
{
    internal class SemestersItem : MenuItem
    {
        public SemestersItem(MySqlConnection connection, DataGridView dataGridView)
        {
            _nameofitem = "subjectsemesters";
            _selectquery = "SELECT * FROM subjectsemesters";
            _columnsname = ["Идентификатор", "Семестр", "Предмет", "Количество лекций", "Количество практик", "Количество лабораторных"];
            _columnsnameInTable = ["id", "semesterid", "subjectid", "countoflectures", "countofpractice", "countoflabs"];

            _connection = connection;
            _dataGridView = dataGridView;

            this.Init();
        }

        public override void Delete(params string[] args)
        {
            DeleteDataFromBD(args[0]);
        }

        public override void Init(params string[] args)
        {
            InitDataFromDB();
        }

        public override void Insert(params string[] args)
        {
            AddDataIntoBD();
        }

        public override bool Update(params string[] args)
        {
            if (args[1] == "2" && !SubjectPerforms.IsSubjectExist(args[2]))
            {
                MessageBox.Show("Такого предмета не существует!");
                return false;
            }

            UpdateDataInDB(args[0], args[1], args[2]);
            return true;
        }
    }
}
