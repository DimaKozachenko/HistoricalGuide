using MySql.Data.MySqlClient;

namespace HistoricalGuide
{
    internal class DataBase
    {
        MySqlConnection sqlConection = new MySqlConnection("server=localhost;port=3306;username=root;password=jester0996136208king;database=historicalguide");
       
        public void openConection()
        {
            if(sqlConection.State== System.Data.ConnectionState.Closed)
            {
                sqlConection.Open();
            }
        }
        public void closeConection()
        {
            if (sqlConection.State == System.Data.ConnectionState.Open)
            {
                sqlConection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return sqlConection;
        }
    }
}
