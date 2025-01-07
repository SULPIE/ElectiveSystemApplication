using MySql.Data.MySqlClient;

namespace ElectiveApp.MenuItems
{
    internal class StudentsItem : MenuItem
    {
        public StudentsItem(MySqlConnection connection, DataGridView dataGridView)
        {
            _nameofitem = "students";
            _selectquery = "SELECT * FROM students";
            _columnsname = ["Идентификатор", "ФИО", "Адрес", "Телефон"];
            _columnsnameInTable = ["id", "nsp", "address", "phone"];

            _connection = connection;
            _dataGridView = dataGridView;

            this.Init();
        }

        public override bool Delete(params string[] args)
        {
            if (DeleteDataFromBD(args[0]))
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
            if (AddDataIntoBD())
            {
                return true;
            }
            return false;
        }

        public override bool Update(params string[] args)
        {
            if (UpdateDataInDB(args[0], args[1], args[2]))
            {
                return true;
            }
            return false;
        }
    }
}
