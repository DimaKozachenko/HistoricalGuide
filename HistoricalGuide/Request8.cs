using MySql.Data.MySqlClient;
using System.Data;


namespace HistoricalGuide
{
    public partial class Request8 : Form
    {
        public Request8()
        {
            InitializeComponent();
        }

        DataBase historicalguide = new DataBase();

        private void createColums()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("period_count", "Кількість періодів у базі данних");


        }
        private void readSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetValue(0));
        }


        private void refreshDataGrid(DataGridView dgw)
        {

            historicalguide.openConection();

            MySqlCommand command = new MySqlCommand("get_period_count", historicalguide.getConnection());
            command.CommandType = CommandType.StoredProcedure;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readSingleRows(dgw, reader);
            }

            historicalguide.closeConection();

        }


        private void Request8_FormClosing(object sender, FormClosingEventArgs e)
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
