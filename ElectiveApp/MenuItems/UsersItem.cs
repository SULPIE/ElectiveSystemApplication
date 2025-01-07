using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectiveApp.MenuItems
{
    internal class UsersItem : MenuItem
    {
        public UsersItem(MySqlConnection connection, DataGridView dataGridView)
        {
            _nameofitem = "users";
            _selectquery = "SELECT * FROM users";
            _columnsname = ["Идентификатор", "Логин", "Пароль", "Роль"];
            _columnsnameInTable = ["id", "login", "password", "role"];

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
