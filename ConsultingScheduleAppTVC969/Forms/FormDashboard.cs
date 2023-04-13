using ConsultingScheduleApp.Forms;
using ConsultingScheduleApp.Forms.Appointment;
using ConsultingScheduleApp.Forms.Client;
using ConsultingScheduleApp.Forms.Summary;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultingScheduleApp
{
    public partial class FormDashboard : Form
    {

        static string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        MySqlConnection connection = new MySqlConnection(connectionString);

        //reusable connection to the database
        protected MySqlConnection getConnection()
        {
            var connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }


        public FormDashboard()
        {
            InitializeComponent();


        }



        private void FormDashboard_Load(object sender, EventArgs e)
        {

            btnAddClient.PerformClick();
            //btnAddAppointment.PerformClick();
            dgClientView.DataSource = LoadClients();

            //button styles
            btnMonthlySummary.FlatStyle = FlatStyle.Flat;
            btnCalendarView.FlatStyle = FlatStyle.Flat;
            btnConsultantSummary.FlatStyle = FlatStyle.Flat;
            btnCumulativeCount.FlatStyle = FlatStyle.Flat;

            //panel style
            btnMonthlySummary.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnCumulativeCount.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnConsultantSummary.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnCalendarView.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;

            //client row view
            this.dgClientView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgClientView.MultiSelect = false;

            //appointment row selection
            this.dgAppointmentView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgAppointmentView.MultiSelect = false;

            //client view
            this.dgClientView.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dgClientView.AlternatingRowsDefaultCellStyle.BackColor =
                Color.SkyBlue;

            //appointment view
            this.dgAppointmentView.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dgAppointmentView.AlternatingRowsDefaultCellStyle.BackColor =
                Color.LightSkyBlue;


            loadAppointments();

        }
        //---------------------------Client-------------------------------
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            //opens the new client form
            FormNewClient frmNewClient = new FormNewClient();
            frmNewClient.ShowDialog();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            //if no client is selected, display an error message
            if (dgClientView.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select a row to delete a client.");
            }
            else
            {
                //display a message to make sure the action is true
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this client?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //otherwise, try and connect to the database
                    try
                    {

                        //establish a connection to the database
                        MySqlConnection connection = getConnection();

                        //query to delete a client
                        int customerId = (int)dgClientView.SelectedRows[0].Cells[0].Value;
                        //query through the customer table and filter by customer ID
                        string delete = $"DELETE FROM customer WHERE customerId={customerId}";
                        MySqlCommand mySqlCommand = new MySqlCommand(delete, connection);
                        mySqlCommand.ExecuteNonQuery();
                        dgClientView.DataSource = LoadClients();
                    }
                    catch (MySqlException error)
                    {
                        MessageBox.Show("Error:" + error);
                    }
                }
                
            }

        }

        private void btnModifyClient_Click(object sender, EventArgs e)
        {
            //if no client is selected, display a message to highlight a row
            if (dgClientView.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select a client row to modify");
            }
            else
            {
                //otherwise, open a the FormModifyClient form
                FormModifyClient formModifyClient = new FormModifyClient(this);
                formModifyClient.ShowDialog();
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //clients will be loaded to the datagrid view - clientView
            dgClientView.DataSource = LoadClients();
        }


        // query all clients and display
        public BindingSource LoadClients()
        {

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            MySqlCommand command;
            DataSet dataSet = new DataSet();
            BindingSource bindingSource = new BindingSource();
            //query from customer table
            string query = "SELECT * FROM client_schedule.customer";
            command = new MySqlCommand(query, connection);

            mySqlDataAdapter.SelectCommand = command;
            mySqlDataAdapter.Fill(dataSet);
            bindingSource.DataSource = dataSet.Tables[0];

            return bindingSource;

        }
        //-----------------------Appointments-----------------------
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            FormAddNewAppointment formAddNewAppointment = new FormAddNewAppointment(this);
            formAddNewAppointment.ShowDialog();
        }

        public void loadAppointments()
        {
            try
            {
                //establish connection to the database
                MySqlConnection connection = getConnection();

                //query appointments
                string query = "SELECT * FROM appointment";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                //iterate through the datatable to display local time
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    //assign to variables to be passed on to the date time
                    var startTime = dataTable.Rows[i]["start"];
                    var endTime = dataTable.Rows[i]["end"];
                    DateTime dateTimeStart = (DateTime)startTime;
                    DateTime dateTimeEnd = (DateTime)endTime;

                    //to localtime
                    dataTable.Rows[i]["start"] = dateTimeStart.ToLocalTime();
                    dataTable.Rows[i]["end"] = dateTimeEnd.ToLocalTime();
                }
                dgAppointmentView.DataSource = dataTable;



                ////removes columns that are automatically generated during binding
                //dgAppointmentView.AutoGenerateColumns = true;
                ////dgAppointmentView.DataSource = dataTable;
                //dgAppointmentView.Columns.Remove("description");
                //dgAppointmentView.Columns.Remove("location");
                //dgAppointmentView.Columns.Remove("contact");
                //dgAppointmentView.Columns.Remove("url");
                //dgAppointmentView.Columns.Remove("createdBy");
                //dgAppointmentView.Columns.Remove("lastUpdate");
                //dgAppointmentView.Columns.Remove("lastUpdateBy");
                //dgAppointmentView.Columns.Remove("createDate");
                

                dgAppointmentView.ClearSelection();

            }
            //display an error message when error occurs
            catch (MySqlException error)
            {
                MessageBox.Show("Error Message:" + error);
            }

        }



        private void dgAppointmentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadAppointments_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            //if no appointment is selected, display a message
            if (dgAppointmentView.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select a row to delete an appointment.");
            }
            else
            {
                //checks whether the delete action is true
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //otherwise, try and connect to the database
                    try
                    {
                        //establish a connection
                        MySqlConnection connection = getConnection();

                        //highlighted row gets deleted
                        int appointmentID = (int)dgAppointmentView.SelectedRows[0].Cells[0].Value;
                        //query from appointment and filter by appointmentID
                        string query = $"DELETE FROM appointment WHERE appointmentId={appointmentID}";
                        MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                        mySqlCommand.ExecuteNonQuery();
                        loadAppointments();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error Message:" + ex);
                    }
                }
                
            }
        }

        private void btnModifyAppointment_Click(object sender, EventArgs e)
        {
            //if no appointment is selected, display a message
            if (dgAppointmentView.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select a row to modify an appointment.");
            }
            else
            {
                //otherwise, open the FormModifyAppointment form

                FormModifyAppointment formModifyAppointment = new FormModifyAppointment(this);
                formModifyAppointment.ShowDialog();
            }

        }

        private void dgClientView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //-----------------Weekly and Monthly Report-----------------




        private void btnLoadCalendarView_Click(object sender, EventArgs e)
        {
            loadAppointments();

        }

        //styling the hover effect on buttons
        private void btnMonthlySummary_Click(object sender, EventArgs e)
        {
            btnMonthlySummary.FlatStyle = FlatStyle.Flat;
            btnMonthlySummary.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            FormMonthlySummary formMonthlySummary = new FormMonthlySummary();
            formMonthlySummary.ShowDialog();
        }

        //styling the hover effect on buttons

        private void btnConsultantSummary_Click(object sender, EventArgs e)
        {
            btnConsultantSummary.FlatStyle = FlatStyle.Flat;
            btnConsultantSummary.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            FormConsultantSummary formConsultantSummary = new FormConsultantSummary();
            formConsultantSummary.ShowDialog();
        }

        //styling the hover effect on buttons
        private void btnCumulativeCount_Click(object sender, EventArgs e)
        {
            btnCumulativeCount.FlatStyle = FlatStyle.Flat;
            btnCumulativeCount.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            FormCumulativeSummary formCumulativeSummary = new FormCumulativeSummary();
            formCumulativeSummary.ShowDialog();
        }


        //exits application
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btnCalendarView_Click(object sender, EventArgs e)
        {
            btnCalendarView.FlatStyle = FlatStyle.Flat;
            btnCalendarView.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            FormCalendarView formCalendarView = new FormCalendarView();
            formCalendarView.ShowDialog();

        }

        private void lblWelcomeMessage_Click(object sender, EventArgs e)
        {

        }

        private void btn_search(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Enter a valid date");
            }
            else

            {
                var unformat = txtSearch.Text;
                try
                {
                    var appointmentDate = DateTime.Parse(unformat).ToString("yyyy-MM-dd");
                    // establish connection
                    MySqlConnection connection = getConnection();
                    //query from appointment and filter by appointment start date
                    string query = $"SELECT * FROM appointment WHERE DATE(start)='{appointmentDate}'";
                    MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 0)
                    {
                        //display a message if empty
                        MessageBox.Show("There are no appointments for this date");
                        txtSearch.Text = "";
                    }
                    else
                    {
                        //display the appointment
                        dgAppointmentView.DataSource = dataTable;
                        txtSearch.Text = "";
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Something went wrong" + ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           loadAppointments();
        }


        //private BindingSource load()
        //{

        //    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
        //    MySqlCommand command;
        //    DataSet dataSet = new DataSet();
        //    BindingSource bindingSource = new BindingSource();

        //    string query = "SELECT * FROM client_schedule.customer";
        //    command = new MySqlCommand(query, connection);

        //    mySqlDataAdapter.SelectCommand = command;
        //    mySqlDataAdapter.Fill(dataSet);

        //    bindingSource.DataSource = dataSet.Tables[0];

        //    return bindingSource;

        //}
    }
}
