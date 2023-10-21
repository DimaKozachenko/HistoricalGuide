using MySql.Data.MySqlClient;
using System.Data;


namespace HistoricalGuide
{
    public partial class Request2 : Form
    {
        
        public Request2()
        {
            InitializeComponent();
        }
        DataBase historicalguide = new DataBase();
        private void createColums()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("country_name", "Назва Держави");
            dataGridView1.Columns.Add("period_name", "Назва періоду");
            dataGridView1.Columns.Add("period_start", "Початок періоду");
            dataGridView1.Columns.Add("period_end", "Кінець періоду");
            dataGridView1.Columns.Add("goverment_form", "Форма Правліня");
            dataGridView1.Columns.Add("political_regime", "Політичний режим");
        }
        private void readSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetDateTime(2), record.GetDateTime(3), record.GetString(4), record.GetString(5));
        }
        private void refreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            historicalguide.openConection();

            MySqlParameter sqlParameter = new MySqlParameter();
            sqlParameter = new MySqlParameter("countryName", MySqlDbType.VarChar);
            sqlParameter.Value = textBoxCountryName.Text;



            MySqlCommand command = new MySqlCommand("get_period_country", historicalguide.getConnection());
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

        private void Request2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void buttonSearchCountry_Click(object sender, EventArgs e)
        {
            createColums();
            refreshDataGrid(dataGridView1);
        }
    }
}
