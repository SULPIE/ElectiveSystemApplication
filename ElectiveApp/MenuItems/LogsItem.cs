using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectiveApp.MenuItems
{
    internal class LogsItem: MenuItem
    {
        public LogsItem(MySqlConnection connection, DataGridView dataGridView)
        {
            _nameofitem = "logs";
            _selectquery = "SELECT * FROM logs";
            _columnsname = ["Идентификатор", "Таблица", "Автор", "Действие", "Дата"];
            _columnsnameInTable = ["id", "table", "author", "action", "date"];

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
            return false;
        }
        public override bool Update(params string[] args)
        {
            return false;
        }
    }
}
