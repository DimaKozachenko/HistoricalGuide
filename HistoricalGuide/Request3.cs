using MySql.Data.MySqlClient;
using System.Data;

namespace HistoricalGuide
{
    public partial class Request3 : Form
    {
        DataBase historicalguide = new DataBase();
        public Request3()
        {
            InitializeComponent();
        }
        private void createColums()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("employee_surname", "Призвіще Співробітника");
            dataGridView1.Columns.Add("employee_name", "Ім'я Співробітника");
            dataGridView1.Columns.Add("employee_middle_name", "Побатькові Співробітника");
            dataGridView1.Columns.Add("employee_data_birth", "Дата Народження Співробітника");
            dataGridView1.Columns.Add("employee_position", "Посада Співробітника");

        }
        private void readSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetDateTime(3), record.GetString(4));
        }
        private void refreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            historicalguide.openConection();

            MySqlParameter sqlParameter = new MySqlParameter();
            sqlParameter = new MySqlParameter("employeeSurname", MySqlDbType.VarChar);
            sqlParameter.Value = textBoxEmployeeSurname.Text;



            MySqlCommand command = new MySqlCommand("get_employee", historicalguide.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(sqlParameter);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readSingleRows(dgw, reader);

            }

            reader.Close();
            historicalguide.closeConection();

        }
        private void Request3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            createColums();
            refreshDataGrid(dataGridView1);
        }
    }
}
