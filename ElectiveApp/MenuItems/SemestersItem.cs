using ElectiveApp.DataBase;
using MySql.Data.MySqlClient;

namespace ElectiveApp.MenuItems
{
    internal class SemestersItem : MenuItem
    {
        public SemestersItem(MySqlConnection connection, DataGridView dataGridView)
        {
            _nameofitem = "subjectsemesters";
            _selectquery = "SELECT id, semesterid, countoflectures, countofpractice, countoflabs, subjectid FROM subjectsemesters";
            _columnsname = ["Идентификатор", "Семестр", "Количество лекций", "Количество практик", "Количество лабораторных", "Предмет"];
            _columnsnameInTable = ["id", "semesterid", "countoflectures", "countofpractice", "countoflabs", "subjectid"];

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
                if (_dataGridView == null) return false;

                DataGridViewComboBoxColumn comboBoxColumnSubjects = new()
                {
                    HeaderText = "Предмет",
                    Name = "subjecttest",
                    DataSource = SubjectPerforms.Get(),
                };

                _dataGridView.Columns.Add(comboBoxColumnSubjects);

                foreach (DataGridViewRow row in _dataGridView.Rows)
                {
                    row.Cells["subjecttest"].Value = row.Cells["subjectid"].Value.ToString();
                }

                _dataGridView.Columns.RemoveAt(5);

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
            UpdateDataInDB(args[0], args[1], args[2]);
            return true;
        }
    }
}
