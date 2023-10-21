using MySql.Data.MySqlClient;
using System.Data;


namespace HistoricalGuide
{
    public partial class Request15 : Form
    {
        public Request15()
        {
            InitializeComponent();
        }
        DataBase historicalguide = new DataBase();

        private void createColums()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("person_surname", "Призвіще");
            dataGridView1.Columns.Add("person_name", "Ім'я");
            dataGridView1.Columns.Add("person_middle_name", "По-батькові");
            dataGridView1.Columns.Add("person_gender", "Стать");
            

        }
        private void readSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3));
        }


        private void refreshDataGrid(DataGridView dgw)
        {

            historicalguide.openConection();

            MySqlCommand command = new MySqlCommand("getPersonNotInEven", historicalguide.getConnection());
            command.CommandType = CommandType.StoredProcedure;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readSingleRows(dgw, reader);
            }

            historicalguide.closeConection();

        }

        private void Request15_FormClosing(object sender, FormClosingEventArgs e)
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
