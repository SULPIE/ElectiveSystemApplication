using ElectiveApp.DataBase;
using MySql.Data.MySqlClient;

namespace ElectiveApp.MenuItems
{
    internal class PlanItem : MenuItem
    {
        public PlanItem(MySqlConnection connection, DataGridView dataGridView) 
        {
            _nameofitem = "plan";
            _selectquery = "SELECT * FROM plan";
            _columnsname = ["Идентификатор", "Оценка", "Предмет", "Студент", "Семестр"];
            _columnsnameInTable = ["id", "report", "subjectid", "studentid", "semesterid"];

            _connection = connection;
            _dataGridView = dataGridView;

            this.Init();
        }

        public override bool Delete(params string[] args)
        {
            if(DeleteDataFromBD(args[0]))
            {
                return true;
            }
            return false;
        }

        public override bool Init(params string[] args)
        {
            if (InitDataFromDB())
            {
                return true;
            }
            return false;
        }

        public override bool Insert(params string[] args)
        {
            if(AddDataIntoBD())
            {
                return true;
            }
            return false;
        }

        public override bool Update(params string[] args)
        {
            if (args[1] == "2" && !SubjectPerforms.IsSubjectExist(args[2]))
            {
                MessageBox.Show("Такого предмета не существует!");
                return false;
            }
            if (args[1] == "3" && !StudentPerforms.IsStudentExist(args[2]))
            {
                MessageBox.Show("Такого студента не существует!");
                return false;
            }

            UpdateDataInDB(args[0], args[1], args[2]);
            return true;
        }
    }
}
