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

namespace ConsultingScheduleApp.Forms.Summary
{

    public partial class FormConsultantSummary : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        //reusable connection to the database
        protected MySqlConnection getConnection()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }
        public FormConsultantSummary()
        {
            InitializeComponent();
        
        }

        private void FormConsultantSummary_Load(object sender, EventArgs e)
        {
            generateUser();
            //loads the first user on the datagrid view
            cmbAssignedConsultant.SelectedIndex = cmbAssignedConsultant.Items.Count - 1;
            //consultant view display
            this.dgConsultantView.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dgConsultantView.AlternatingRowsDefaultCellStyle.BackColor =
                Color.SkyBlue;

            LoadConsultantSummary();
        }


        //Lambda Use - formats the datagridview display instead of having to create separate methods to hide each columns
        private delegate void HideColums(DataGridView dataGridViewCalendar);
        private void LoadConsultantSummary()
        {
            try
            {
                //establish connection
                MySqlConnection connection = getConnection();

                //capture input value and assign to the variable 
                string userId = cmbAssignedConsultant.Text;

                //query to select all appointments filtering userId
                string query = $"SELECT * FROM appointment WHERE userId={userId}";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    var timeStart = dataTable.Rows[i]["start"];
                    var timeEnd = dataTable.Rows[i]["end"];
                    DateTime dateTime = (DateTime)timeStart;
                    DateTime dateTime1 = (DateTime)timeEnd;
                    dataTable.Rows[i]["start"] = dateTime.ToLocalTime();
                    dataTable.Rows[i]["end"] = dateTime1.ToLocalTime();
                }
                //dgConsultantView.DataSource = dataTable;

                //to remove columns that are automatically generated during data binding
                HideColums hideColumns = dataGridViewCalendar =>
                {
                    dgConsultantView.AutoGenerateColumns = true;
                    dgConsultantView.DataSource = dataTable;
                    dgConsultantView.Columns.Remove("description");
                    dgConsultantView.Columns.Remove("location");
                    dgConsultantView.Columns.Remove("contact");
                    dgConsultantView.Columns.Remove("url");
                    dgConsultantView.Columns.Remove("createdBy");
                    dgConsultantView.Columns.Remove("lastUpdate");
                    dgConsultantView.Columns.Remove("lastUpdateBy");
                    dgConsultantView.ClearSelection();

              

                };

                hideColumns(dgConsultantView);


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Message:"+ ex);
            }

        }

        //generates user from the database
        private void generateUser()
        {

            try
            {
                //establish connection
                MySqlConnection connection = getConnection();

                //query the count from user
                string query = "SELECT COUNT(*) FROM user";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                int userIdx = Convert.ToInt32(mySqlCommand.ExecuteScalar());

                //iterate through the number of indexes per user
                for (int user = 0; user < userIdx; user++)
                {
                    cmbAssignedConsultant.Items.Add(user + 1);
                }
            }
            //display error if no connection to the database
            catch (MySqlException error)
            {
                MessageBox.Show("Error Message:" + error);
            }
        }
        private void btnLoadConsultantSummary_Click(object sender, EventArgs e)
        {



        }

        //closes the consultant summary form
        private void btnExitConsultantSummary_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgConsultantView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblConsultantAssignedSchedule_Click(object sender, EventArgs e)
        {

        }

        private void cmbAssignedConsultant_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
