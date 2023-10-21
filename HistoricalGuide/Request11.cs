using MySql.Data.MySqlClient;
using System.Data;


namespace HistoricalGuide
{
    public partial class Request11 : Form
    {
        public Request11()
        {
            InitializeComponent();
        }
        DataBase historicalguide = new DataBase();
        private void createColums()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("country_id", "Айді держави");
            dataGridView1.Columns.Add("country_name", "Назва держави");


        }
        private void readSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetValue(0), record.GetString(1));
        }
        private void refreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            historicalguide.openConection();

            MySqlParameter sqlParameter = new MySqlParameter();
            sqlParameter = new MySqlParameter("eventName", MySqlDbType.VarChar);
            sqlParameter.Value = textBoxEventName.Text;

            MySqlCommand command = new MySqlCommand("get_CountryInEven", historicalguide.getConnection());
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


        private void buttonSearchGovermentForm_Click(object sender, EventArgs e)
        {
            createColums();
            refreshDataGrid(dataGridView1);
        }

        private void Request11_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
