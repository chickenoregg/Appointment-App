using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultingScheduleApp
{
    class ConnectionClass
    {
        string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;


        //reusable connection
        protected MySqlConnection getConnection()
        {
            var connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }

        //getting data
        public DataSet getData(String query) // get data from database
        {
            MySqlConnection connection = getConnection();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = query; 
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command); // use as a bridge between dataset and mysql 
            DataSet dataSet = new DataSet(); 
            dataAdapter.Fill(dataSet);
            return dataSet;

        }


        //Insertion
        //Deletion
        //Updation
        public void setData(String query, String message)
        {
            MySqlConnection connection = getConnection();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            //connection.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
