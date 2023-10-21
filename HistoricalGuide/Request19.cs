using MySql.Data.MySqlClient;
using System.Data;


namespace HistoricalGuide
{
    public partial class Request19 : Form
    {
        public Request19()
        {
            InitializeComponent();
        }
        DataBase historicalguide = new DataBase();

        private void createColums()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("event_name", "Назва події");
            dataGridView1.Columns.Add("event_start", "Початок події");
            dataGridView1.Columns.Add("event_end", "Кінець події");
        }
        private void readSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(1), record.GetValue(2), record.GetValue(3));
        }


        private void refreshDataGrid(DataGridView dgw)
        {

            historicalguide.openConection();

            MySqlCommand command = new MySqlCommand("getEventInBirthPersn", historicalguide.getConnection());
            command.CommandType = CommandType.StoredProcedure;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readSingleRows(dgw, reader);
            }

            historicalguide.closeConection();

        }

        private void Request19_FormClosing(object sender, FormClosingEventArgs e)
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
