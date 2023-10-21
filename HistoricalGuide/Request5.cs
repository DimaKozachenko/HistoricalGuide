using MySql.Data.MySqlClient;
using System.Data;


namespace HistoricalGuide
{
    public partial class Request5 : Form
    {
        DataBase historicalguide = new DataBase();
        public Request5()
        {
            InitializeComponent();
        }
        private void createColums()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("event_name", "Назва події");
            dataGridView1.Columns.Add("event_start", "Початок події");
            dataGridView1.Columns.Add("event_end", "Кінець події");

        }
        private void readSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetDateTime(1), record.GetDateTime(2));
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

            MySqlCommand command = new MySqlCommand("get_event_for_date", historicalguide.getConnection());
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

        private void Request5_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void buttonSearchDateEvent_Click(object sender, EventArgs e)
        {
            createColums();
            refreshDataGrid(dataGridView1);
        }
    }
}
