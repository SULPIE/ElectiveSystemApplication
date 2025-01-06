using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

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
