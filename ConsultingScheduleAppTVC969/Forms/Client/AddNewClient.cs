using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultingScheduleApp.Forms.Client
{

    
    public partial class FormNewClient : Form

    {
        ConnectionClass connectionClass = new ConnectionClass();
        string query;
        FormDashboard formDashboard = new FormDashboard();

        string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        //establish reusable connection
        protected MySqlConnection getConnection()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }

        
        public FormNewClient()
        {
            InitializeComponent();
            //client display 
            this.dgAddNewClient.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dgAddNewClient.AlternatingRowsDefaultCellStyle.BackColor =
                Color.SkyBlue;
        }


        
        private void frmNewClient_Load(object sender, EventArgs e)
        {
            //gets data and loads on the form
            query = "SELECT * FROM customer";
            DataSet dataSet =  connectionClass.getData(query);
            dgAddNewClient.DataSource = dataSet.Tables[0];
        }

        private void txtAddNewClientName_TextChanged(object sender, EventArgs e)
        {
            //bool isValidName = IsValidString(txtAddNewClientName.Text);
 
            //btnSaveClient.Enabled = LetSave();

                
        }

        private void txtAddNewClientAddress_TextChanged(object sender, EventArgs e)
        {
            //bool isValidAddress = IsValidString(txtAddNewClientAddress.Text);
            //btnSaveClient.Enabled = LetSave();
        }

        private void txtAddNewClientPhone_TextChanged(object sender, EventArgs e)
        {
            //bool isValidPhone = IsValidString(txtAddNewClientPhone.Text);
            //btnSaveClient.Enabled = LetSave();
        }

        private void txtAddNewClientCity_TextChanged(object sender, EventArgs e)
        {
            //bool isValidCity = IsValidString(txtAddNewClientCity.Text);
            //btnSaveClient.Enabled = LetSave();
        }

        private void txtAddNewClientCountry_TextChanged(object sender, EventArgs e)
        {
            //bool isValidVCountry = IsValidString(txtAddNewClientCountry.Text);
            //btnSaveClient.Enabled = LetSave();
        }

        //checks whether an input is valid or not
        public bool IsValidString(string stringtext)
        {
            return !string.IsNullOrWhiteSpace(stringtext);
        }


        private delegate bool LetSave();
        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            // feeding in the textboxes' values to variables
            string name = txtAddNewClientName.Text;
            string address = txtAddNewClientAddress.Text;
            string addressTwo = txtAddNewClientAddressTwo.Text;
            string phone = txtAddNewClientPhone.Text;
            string city = txtAddNewClientCity.Text;
            string country = txtAddNewClientCountry.Text;
            string zipCode = txtAddNewClientZipCode.Text;

            // this function checks whether the input from the user are valid.
            LetSave letSave = () =>
            {

                if (!IsValidString(name))
                {
                    return false;
                }
                if (!IsValidString(address))
                {
                    return false;
                }
                if (!IsValidString(addressTwo))
                {
                    return false;
                }
                if (!IsValidString(phone))
                {
                    return false;

                }
                if (!IsValidString(city))
                {
                    return false;

                }
                if (!IsValidString(country))
                {
                    return false;
                }
                if (!IsValidString(zipCode))
                {
                    return false;
                }
                else
                {
                    return true;

                }
                
            };
            //display error message when fields are not filled correctly.
            if (letSave() != true)
            {
                MessageBox.Show("All fields are required.");
            }
            else
            {
                try
                {
                    //establish connection to the database
                    MySqlConnection connection = getConnection();

                  //Queries for all customer default fields based on the database

                  // read query for zipcode field
                 
        


                  // read query for country field
                    string countryReadQuery = "SELECT countryId FROM country ORDER BY countryId DESC LIMIT 1";
                    MySqlCommand mySqlCommand = new MySqlCommand(countryReadQuery, connection);
                    int countryIdx = Convert.ToInt32(mySqlCommand.ExecuteScalar()) + 1;

                    //insert country value collected from input 
                    string countryInsert = $"INSERT INTO country VALUES({countryIdx}, '{country}', NOW(), 'test', NOW(), NOW())";
                    MySqlCommand mySqlCommand1 = new MySqlCommand(countryInsert, connection);
                    mySqlCommand1.ExecuteNonQuery();

                    //read query for city field
                    string cityQuery = "SELECT cityId FROM city ORDER BY cityId DESC LIMIT 1";
                    MySqlCommand mySqlCommand2 = new MySqlCommand(cityQuery, connection);
                    int cityIdx = Convert.ToInt32(mySqlCommand2.ExecuteScalar()) + 1;

                    //insert city value collected from input
                    string cityInsert = $"INSERT INTO city VALUES({cityIdx},'{city}', {countryIdx}, NOW(), 'test', NOW(), 'test')";
                    MySqlCommand mySqlCommand3 = new MySqlCommand(cityInsert, connection);
                    mySqlCommand3.ExecuteNonQuery();

                    //read query for address field
                    string addressReadQuery = "SELECT addressId FROM address ORDER BY addressId DESC LIMIT 1";
                    MySqlCommand mySqlCommand4 = new MySqlCommand(addressReadQuery, connection);
                    int addressIdx = Convert.ToInt32(mySqlCommand4.ExecuteScalar()) + 1;

                    //insert address value collected from input
                    string addressInsert = $"INSERT INTO address VALUES({addressIdx}, '{address}', '{addressTwo}', {cityIdx}, '{phone}','{zipCode}', NOW(), 'test', NOW(), 'test')";
                    MySqlCommand mySqlCommand5 = new MySqlCommand(addressInsert, connection);
                    mySqlCommand5.ExecuteNonQuery();

                    //read query for client field
                    string nameReadQuery = "SELECT customerId FROM customer ORDER BY customerId DESC LIMIT 1";
                    MySqlCommand mySqlCommand6 = new MySqlCommand(nameReadQuery, connection);
                    int clientIdx = Convert.ToInt32(mySqlCommand6.ExecuteScalar()) + 1;

                    //insert client value collected from input
                    string clientInsertQuery = $"INSERT INTO customer VALUES({clientIdx}, '{name}', {addressIdx}, 1, NOW(), 'test', NOW(), 'test')";
                    MySqlCommand mySqlCommand7 = new MySqlCommand(clientInsertQuery, connection);
                    mySqlCommand7.ExecuteNonQuery();

                    //displays clients on the datagrid
                    formDashboard.LoadClients();

              
                    this.Close();

                }

                

                //display error 
                catch (MySqlException error)
                {
                    MessageBox.Show("Error Message:" + error);
                    
                }

            }


        }

        //cancels the form
        private void btnClientCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //returns to the dashboard
        private void btnReturnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();

            
        }

        private void dgAddNewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


