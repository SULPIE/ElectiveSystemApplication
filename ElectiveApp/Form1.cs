using ElectiveApp.DataBase;

namespace ElectiveApp
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            DataBaseIntializer.InitConnection();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if(UserPerforms.IsUserExist(login, password))
            {
                this.Hide();
                MainForm f = new(login);
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы ввели неверные данные");
            }
        }
    }
}
