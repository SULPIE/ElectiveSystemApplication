﻿
using MySql.Data.MySqlClient;
using System.Data;

namespace ElectiveApp.MenuItems
{
    abstract internal class MenuItem
    {
        protected string _nameofitem = "";

        protected string _selectquery = "";
        protected string _deletequery = "";
        protected string _updatequery = "";
        protected string _insertquery = "";

        protected string[] _columnsname = [""];
        protected string[] _columnsnameInTable = [""];

        protected MySqlConnection? _connection;
        protected DataGridView? _dataGridView;

        public string GetName => _nameofitem;

        public abstract void Init(params string[] args);
        public abstract void Delete(params string[] args);
        public abstract bool Update(params string[] args);
        public abstract void Insert(params string[] args);

        protected void InitDataFromDB()
        {
            if (_connection == null || _dataGridView == null) return;

            MySqlDataAdapter MyDA = new()
            {
                SelectCommand = new MySqlCommand(_selectquery, _connection)
            };

            DataTable table = new();
            MyDA.Fill(table);

            BindingSource bSource = new()
            {
                DataSource = table
            };

            _dataGridView.DataSource = bSource;

            for(int i = 0; i < _columnsname.Length; i++)
            {
                _dataGridView.Columns[i].HeaderCell.Value = _columnsname[i];
            }

            _dataGridView.Columns[0].ReadOnly = true;
        }

        protected void DeleteDataFromBD(string id)
        {
            if (_connection == null || _dataGridView == null) return;

            MySqlCommand command = _connection.CreateCommand();

            command.CommandText = "DELETE FROM " + _nameofitem + " WHERE id=@ID";
            command.Parameters.AddWithValue("@ID", id);

            command.ExecuteNonQuery();
        }

        protected void AddDataIntoBD()
        {
            if (_connection == null || _dataGridView == null) return;

            MySqlCommand command = _connection.CreateCommand();

            command.CommandText = "INSERT INTO " + _nameofitem + "()" + " VALUES()";
            command.ExecuteNonQuery();

            InitDataFromDB();
        }

        protected void UpdateDataInDB(string id, string columnid, string Text)
        {
            if (_connection == null || _dataGridView == null) return;

            MySqlCommand command = _connection.CreateCommand();

            command.CommandText = "UPDATE " + _nameofitem + " SET " +
                _columnsnameInTable[Convert.ToInt32(columnid)].ToString() +
                "=@Param" + " WHERE id=" + id;
            command.Parameters.AddWithValue("@Param", Text);
            command.ExecuteNonQuery();
        }
    }
}
