using MySql.Data.MySqlClient;
using System.Data;

namespace HistoricalGuide
{
    public partial class Request7 : Form
    {
        DataBase historicalguide = new DataBase();
        public Request7()
        {
            InitializeComponent();
        }

        private void createColums()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("count_country_leder_women", "Кількість країн в яких були лідери жінки");


        }
        private void readSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetValue(0));
        }


        private void refreshDataGrid(DataGridView dgw)
        {

            historicalguide.openConection();

            MySqlCommand command = new MySqlCommand("get_countryLeder_women", historicalguide.getConnection());
            command.CommandType = CommandType.StoredProcedure;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readSingleRows(dgw, reader);

            }


            historicalguide.closeConection();

        }


        private void Request7_FormClosing(object sender, FormClosingEventArgs e)
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
