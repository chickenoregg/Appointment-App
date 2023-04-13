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

    public partial class FormModifyClient : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        FormDashboard formDashboard = new FormDashboard();


        //establish reusable connection to the database
        protected MySqlConnection getConnection()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }

        //properties of a client
        public string customerId;
        public string nameId;
        public string phoneNumber;
        public string addressId;
        public string addressTwo;
        public string cityId;
        public string country;
        public string zipCode;
      

        public FormModifyClient(Form form)
        {

            InitializeComponent();
            formDashboard = form as FormDashboard;
            try
            {
                //establish connectio
                MySqlConnection connection = getConnection();

                //client view display
                customerId = formDashboard.dgClientView.SelectedRows[0].Cells[0].Value.ToString();


                //Id query and filters by customerID
                string idQuery = $"SELECT * FROM customer WHERE customerId={customerId}";
                MySqlCommand mySqlCommand = new MySqlCommand(idQuery, connection);
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter mySqlDataAdapter1 = new MySqlDataAdapter(mySqlCommand))
                {
                    mySqlDataAdapter1.Fill(dataTable);
                }
                //assign value
                nameId = dataTable.Rows[0][1].ToString();
                txtModifyClientName.Text = dataTable.Rows[0][1].ToString();

                //address query and filters by addressId
                string addressQuery = $"SELECT * FROM address WHERE addressId={dataTable.Rows[0][2]}";
                MySqlCommand mySqlCommand1 = new MySqlCommand(addressQuery, connection);
                DataTable dataTable1 = new DataTable();
                using (MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(mySqlCommand1))
                {
                    mySqlDataAdapter2.Fill(dataTable1);
                }
                //assign values to address
                txtModifyClientAddress.Text = dataTable1.Rows[0][1].ToString();
                addressId = dataTable1.Rows[0][0].ToString();

                //assign values to phone
                txtModifyClientPhone.Text = dataTable1.Rows[0][5].ToString();
                phoneNumber = dataTable1.Rows[0][5].ToString();

                //assign values to addresstwo
                txtModifyClientAddressTwo.Text = dataTable1.Rows[0][2].ToString();
                addressTwo = dataTable1.Rows[0][2].ToString();

                //assign values to zipcode
                txtModifyClientZipCode.Text = dataTable1.Rows[0][4].ToString();
                zipCode = dataTable1.Rows[0][4].ToString();
                


                //city query and filters cityID
                string cityQuery = $"SELECT * FROM city WHERE cityId={dataTable1.Rows[0][3]}";
                MySqlCommand mySqlCommand2 = new MySqlCommand(cityQuery, connection);
                DataTable dataTable2 = new DataTable();

                using (MySqlDataAdapter mySqlDataAdapter3 = new MySqlDataAdapter(mySqlCommand2))
                {
                    mySqlDataAdapter3.Fill(dataTable2);
                }
                //assign values to city
                cityId = dataTable2.Rows[0][0].ToString();
                txtModifyClientCity.Text = dataTable2.Rows[0][1].ToString();

                //country query and filters countryId
                string searchCountryQuery = $"SELECT country.country FROM country WHERE countryID={dataTable2.Rows[0][2]}";
                MySqlCommand mySqlCommand3 = new MySqlCommand(searchCountryQuery, connection);
                DataTable dataTable3 = new DataTable();
                using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand3))
                {
                    mySqlDataAdapter.Fill(dataTable3);
                }

                //assign value to country
                country = dataTable3.Rows[0][0].ToString();
                txtModifyClientCountry.Text = dataTable3.Rows[0][0].ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error" + ex);
            }

        }


        //checks if input is valid
        public bool IsValidString(string stringtext)
        {
            return !string.IsNullOrWhiteSpace(stringtext);
        }

        

        //cancels the form
        private void btnModifyClientCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModifyClient_Load(object sender, EventArgs e)
        {

        }

        //saves the values from the input
        private void btnSaveModifyClient_Click(object sender, EventArgs e)
        {
        //assignt values to variables
            string name = txtModifyClientName.Text;
            string address = txtModifyClientAddress.Text;
            string addressTwo = txtModifyClientAddressTwo.Text;
            string phone = txtModifyClientPhone.Text;
            string city = txtModifyClientCity.Text;
            string country = txtModifyClientCountry.Text;
            string zipCode = txtModifyClientZipCode.Text;

            //checks if inputs are valid and satisfies the isValidString method
            bool letSave()
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
      
                return true;
            }

            //display error message to user
            if (letSave() != true)
            {
                MessageBox.Show("You must fill out all fields to modify a client.");
            }
            else
            {
                try
                {
                    //establish connection
                    MySqlConnection connection = getConnection();

                    int customerId = (int)formDashboard.dgClientView.SelectedRows[0].Cells[0].Value;

                    //Queries for all customer default fields based on the database
                    // read query for country field
                    string countryReadQuery = "SELECT countryId FROM country ORDER BY countryId DESC LIMIT 1";
                    MySqlCommand mySqlCommand = new MySqlCommand(countryReadQuery, connection);
                    int countryIndex = Convert.ToInt32(mySqlCommand.ExecuteScalar()) + 1;
                    //insert country value collected from input 
                    string countryInsert = $"INSERT INTO country VALUES({countryIndex}, '{country}', NOW(), 'test', NOW(), NOW())";
                    MySqlCommand mySqlCommand1 = new MySqlCommand(countryInsert, connection);
                    mySqlCommand1.ExecuteNonQuery();

                    //read query for city field
                    string cityQuery = "SELECT cityId FROM city ORDER BY cityId DESC LIMIT 1";
                    MySqlCommand mySqlCommand2 = new MySqlCommand(cityQuery, connection);
                    int cityIndex = Convert.ToInt32(mySqlCommand2.ExecuteScalar()) + 1;

                    //insert city value collected from input
                    string cityInsert = $"INSERT INTO city VALUES({cityIndex},'{city}', {countryIndex}, NOW(), 'test', NOW(), 'test')";
                    MySqlCommand mySqlCommand3 = new MySqlCommand(cityInsert, connection);
                    mySqlCommand3.ExecuteNonQuery();

                    //Address Queries
                    string addressQuery = "SELECT addressId FROM address ORDER BY addressId DESC LIMIT 1";
                    MySqlCommand mySqlCommand4 = new MySqlCommand(addressQuery, connection);
                    int addressIndex = Convert.ToInt32(mySqlCommand4.ExecuteScalar()) + 1;

                    //insert address value collected from input
                    string addressInsertQuery = $"INSERT INTO address VALUES({addressIndex}, '{address}', '{addressTwo}', {cityIndex}, '{zipCode}', '{phone}', NOW(), 'test', NOW(), 'test')";
                    MySqlCommand mySqlCommand5 = new MySqlCommand(addressInsertQuery, connection);
                    mySqlCommand5.ExecuteNonQuery();

                    //Customer Query
                    string customerInsertQuery = $"UPDATE customer SET customerName='{name}', addressId={addressIndex} WHERE customerId={customerId}";
                    MySqlCommand mySqlCommand6 = new MySqlCommand(customerInsertQuery, connection);
                    mySqlCommand6.ExecuteNonQuery();
                    


                    formDashboard.LoadClients();
                    this.Close();


                }

                catch (MySqlException errormessage)
                {
                    MessageBox.Show("Error:" + errormessage);

                }
            }
        }

        private void lblModifyClientCountry_Click(object sender, EventArgs e)
        {

        }
    }
}