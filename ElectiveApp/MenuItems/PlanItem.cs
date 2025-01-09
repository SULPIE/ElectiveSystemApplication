using ElectiveApp.DataBase;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Windows.Forms;

namespace ElectiveApp.MenuItems
{
    internal class PlanItem : MenuItem
    {
        public PlanItem(MySqlConnection connection, DataGridView dataGridView) 
        {
            _nameofitem = "plan";
            _selectquery = "SELECT id, report, semesterid, subjectid, studentid FROM plan";
            _columnsname = ["Идентификатор", "Оценка", "Семестр", "Предмет", "Студент"];
            _columnsnameInTable = ["id", "report", "semesterid", "subjectid", "studentid"];

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
            if (_dataGridView == null) return false;

            if (InitDataFromDB())
            {
                DataGridViewComboBoxColumn comboBoxColumnSubjects = new()
                {
                    HeaderText = "Предмет", 
                    Name = "subjecttest", 
                    DataSource = SubjectPerforms.Get(), 
                };

                DataGridViewComboBoxColumn comboBoxColumnStudents = new()
                {
                    HeaderText = "Студент", 
                    Name = "studentidtest", 
                    DataSource = StudentPerforms.Get(), 
                };

                _dataGridView.Columns.Add(comboBoxColumnSubjects);
                _dataGridView.Columns.Add(comboBoxColumnStudents);

                foreach (DataGridViewRow row in _dataGridView.Rows)
                {
                    row.Cells["subjecttest"].Value = row.Cells["subjectid"].Value.ToString();
                    row.Cells["studentidtest"].Value = row.Cells["studentid"].Value.ToString(); 
                }

                _dataGridView.Columns.RemoveAt(3);
                _dataGridView.Columns.RemoveAt(3);

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
            UpdateDataInDB(args[0], args[1], args[2]);
            return true;
        }
    }
}
