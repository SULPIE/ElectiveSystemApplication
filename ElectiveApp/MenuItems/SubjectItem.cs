using MySql.Data.MySqlClient;

namespace ElectiveApp.MenuItems
{
    internal class SubjectItem : MenuItem
    {

        public SubjectItem(MySqlConnection connection, DataGridView dataGridView) 
        {
            _nameofitem = "subjects";
            _selectquery = "SELECT * FROM subjects";
            _columnsname = ["Идентификатор", "Название"];
            _columnsnameInTable = ["id", "name"];

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
            UpdateDataInDB(args[0], args[1], args[2]);
            return true;
        }
    }
}
