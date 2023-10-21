using MySql.Data.MySqlClient;
using System.Data;


namespace HistoricalGuide
{
    public partial class Request16 : Form
    {
        public Request16()
        {
            InitializeComponent();
        }
        DataBase historicalguide = new DataBase();
        private void createColums()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("country_name", "Назва Держави");

        }
        private void readSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(1));
        }
        private void refreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            historicalguide.openConection();

            MySqlParameter sqlParameter = new MySqlParameter();
            sqlParameter = new MySqlParameter("EvenName", MySqlDbType.VarChar);
            sqlParameter.Value = textBoxCountryName.Text;



            MySqlCommand command = new MySqlCommand("getCountryWithoutEven", historicalguide.getConnection());
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


        private void Request16_FormClosing(object sender, FormClosingEventArgs e)
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
