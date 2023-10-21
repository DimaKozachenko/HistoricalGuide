using MySql.Data.MySqlClient;
using System.Data;


namespace HistoricalGuide
{
    public partial class Request20 : Form
    {
        public Request20()
        {
            InitializeComponent();
        }
        DataBase historicalguide = new DataBase();

        private void createColums()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("country_id", "country_id");
            dataGridView1.Columns.Add("country_name", "Назва країни");
            dataGridView1.Columns.Add("event_name", "Назва події");
        }

        private void readSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2));
        }

        private void refreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            historicalguide.openConection();

            MySqlParameter[] sqlParameter = new MySqlParameter[3];
            sqlParameter[0] = new MySqlParameter("personName", MySqlDbType.VarChar);
            sqlParameter[0].Value = textBoxPersonName.Text; ;

            sqlParameter[1] = new MySqlParameter("personMiddleName", MySqlDbType.VarChar);
            sqlParameter[1].Value = textBoxPersonMiddleName.Text; ;

            sqlParameter[2] = new MySqlParameter("personSurname", MySqlDbType.VarChar);
            sqlParameter[2].Value = textBoxPersonSurname.Text; ;

            MySqlCommand command = new MySqlCommand("getCoutryInEventForPerson", historicalguide.getConnection());
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
        private void Request20_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createColums();
            refreshDataGrid(dataGridView1);
        }
    }
}
