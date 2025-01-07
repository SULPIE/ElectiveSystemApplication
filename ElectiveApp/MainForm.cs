using ElectiveApp.DataBase;
using ElectiveApp.MenuItems;

namespace ElectiveApp
{
    public partial class MainForm : Form
    {
        private MenuItem? menuItem;
        private string _userlogin = "";
        private string? prevtext = null;

        private Semester? _semester;

        public MainForm(string userlogin)
        {
            InitializeComponent();

            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _userlogin = userlogin;

            _semester = new Semester();
            currentSemesterTB.Text = "Текущий семестр: " + _semester.GetCurrentSemester.ToString();

            if (UserPerforms.GetAdminLevel(_userlogin) < 1)
            {
                UsersItem.Visible = false;
                LogsItem.Visible = false;
            }
        }

        private void StudentsItem_Click(object sender, EventArgs e)
        {
            menuItem = new StudentsItem(DataBaseIntializer.GetHashConnection(), DataGridView);
        }

        private void SubjectsItem_Click(object sender, EventArgs e)
        {
            menuItem = new SubjectItem(DataBaseIntializer.GetHashConnection(), DataGridView);
        }

        private void ReportsItem_Click(object sender, EventArgs e)
        {
            menuItem = new PlanItem(DataBaseIntializer.GetHashConnection(), DataGridView);
        }

        private void SemestersItem_Click(object sender, EventArgs e)
        {
            menuItem = new SemestersItem(DataBaseIntializer.GetHashConnection(), DataGridView);
        }

        private void UsersItem_Click(object sender, EventArgs e)
        {
            menuItem = new UsersItem(DataBaseIntializer.GetHashConnection(), DataGridView);
        }

        private void LogsItem_Click(object sender, EventArgs e)
        {
            menuItem = new LogsItem(DataBaseIntializer.GetHashConnection(), DataGridView);
        }

        private void DataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (menuItem != null && e.Row != null &&
                menuItem.Delete(DataGridView[0, e.Row.Index].Value.ToString()))
            {
                LogsPerforms.Add(menuItem.GetName, _userlogin, "Удаление");
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuItem != null && menuItem.Insert())
            {
                LogsPerforms.Add(menuItem.GetName, _userlogin, "Создание");
            }
        }

        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            prevtext = DataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(DataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
            if (menuItem != null && prevtext != null)
            {
                if (!menuItem.Update(DataGridView[0, e.RowIndex].Value.ToString(), e.ColumnIndex.ToString(),
                    DataGridView[e.ColumnIndex, e.RowIndex].Value.ToString()))
                {
                    DataGridView[e.ColumnIndex, e.RowIndex].Value = prevtext;
                    prevtext = null;
                }
                LogsPerforms.Add(menuItem.GetName, _userlogin, "Редактирование");
            }
        }

        private void EndSemesterBtn_Click(object sender, EventArgs e)
        {
            currentSemesterTB.Text = "Текущий семестр: " + _semester?.Increase();
        }
    }
}
