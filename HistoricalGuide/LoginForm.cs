using MySql.Data.MySqlClient;
using System.Data;

namespace HistoricalGuide
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginFild.Text;
            String passwordUser = passwordFild.Text;

            DataBase historicalguider = new DataBase();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand comand = new MySqlCommand("SELECT * FROM employee where employee_login = @uL and employee_password = @uP", historicalguider.getConnection());

            historicalguider.openConection();
            comand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            comand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;
            adapter.SelectCommand = comand;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вітаю ви увійшли у систему");
                RequestsForm requestsForm = new RequestsForm();
                requestsForm.Show();
            }
            else
            {
                MessageBox.Show("Ви ввели неправильний логін чи пароль");
            }
            historicalguider.closeConection();


        }
    }
}