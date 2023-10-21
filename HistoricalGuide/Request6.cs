using MySql.Data.MySqlClient;
using System.Data;


namespace HistoricalGuide
{
    public partial class Request6 : Form
    {
        DataBase historicalguide = new DataBase();
        public Request6()
        {
            InitializeComponent();
        }
        private void createColums()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("country_name", "Назва держави");
            dataGridView1.Columns.Add("period_name", "Назва періоду");
            dataGridView1.Columns.Add("period_start", "Початок періоду");

        }
        private void readSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetDateTime(2));
        }
        private void refreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            historicalguide.openConection();

            MySqlParameter[] sqlParameter = new MySqlParameter[2];

            sqlParameter[0] = new MySqlParameter("findDateOne", MySqlDbType.Date);
            sqlParameter[0].Value = textBoxDateOne.Text;

            sqlParameter[1] = new MySqlParameter("finDateTwo", MySqlDbType.Date);
            sqlParameter[1].Value = textBoxDatTwo.Text;

            MySqlCommand command = new MySqlCommand("get_country_for_date", historicalguide.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(sqlParameter);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readSingleRows(dgw, reader);

            }

            reader.Close();
            historicalguide.closeConection();

        }

        private void Request6_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void buttonSearchDateCountry_Click(object sender, EventArgs e)
        {
            createColums();
            refreshDataGrid(dataGridView1);
        }
    }
}
