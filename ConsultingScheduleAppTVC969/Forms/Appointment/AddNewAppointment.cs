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

namespace ConsultingScheduleApp.Forms.Appointment
{
    public partial class FormAddNewAppointment : Form
    {
        //FormDashboard formDashboard = new FormDashboard();
        string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        //FormDashboard formDashboard = new FormDashboard();

        //establish reusable connection
        protected MySqlConnection getConnection()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }

        private FormDashboard formDashboard = null;

        public FormAddNewAppointment(Form form)
        {
            formDashboard = form as FormDashboard;
            InitializeComponent();
        }

        //checks whether an input is valid or not
        public bool IsValidString(string stringtext)
        {
            return !string.IsNullOrWhiteSpace(stringtext);
        }


        //Lambda Use - to avoid having to create separate cases for each statement
        // This permits boolean returns as long as the conditions are satisfied
        // The check statemets are used to see whether conditions are satisfied within the context of the function.
        private delegate bool LetSave();
        private void btnSaveNewAppointment_Click(object sender, EventArgs e)
        {

            // this function checks whether the input from the user are are not null.
            // letSave will then be implemented
            LetSave letSave = () =>
            {

                if (txtAddStartNewAppointmentHour.Text == "" && txtAddStartNewAppointmentMin.Text == "" && txtAddStartNewAppointmentSec.Text == "")
                {
                    return false;
                }
                if (txtAddEndNewAppointmentHour.Text == "" && txtAddEndNewAppointmentMin.Text == "" && txtAddEndNewAppointmentSec.Text == "")
                {
                    return false;

                }
                if (txtAddNewYearAppointment.Text == "" && txtAddNewMonthAppointment.Text == "" &&  txtAddNewDayAppointment.Text == "")
                {
                    return false;

                }
                if (txtAddNewAppointmentTitle.Text == "")
                {
                    return false;
                }
                if (txtAddNewAppointmentClientId.Text == "")
                {
                    return false;
                }
                if (txtAddNewAppointmentUserId.Text == "")
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
                MessageBox.Show("All fields are required", "Warning");
            }
            else
            {
                //try to see if hours set are met 
                try
                {
                    //assigning input values to variables
                    string appointmentType = cmbAddNewAppointmentType.Text;
                    string appointmentStart = $"{txtAddStartNewAppointmentHour.Text}:{txtAddStartNewAppointmentMin.Text}:{txtAddStartNewAppointmentSec.Text}";
                    string appointmentEnd = $"{txtAddEndNewAppointmentHour.Text}:{txtAddEndNewAppointmentMin.Text}:{txtAddEndNewAppointmentSec.Text}";
                    string appointmentDate = $"{txtAddNewYearAppointment.Text}-{txtAddNewMonthAppointment.Text}-{txtAddNewDayAppointment.Text}";
                    string title = txtAddNewAppointmentTitle.Text;
                    string clientID = txtAddNewAppointmentClientId.Text;
                    string userId = txtAddNewAppointmentUserId.Text;

                    //default hours the application is allowing (8AM - 6PM)
                    TimeSpan timeSpanOpen = new TimeSpan(08, 0, 0);
                    TimeSpan timeSpanClose = new TimeSpan(18, 0, 0);
                    //input values are assigned 
                    TimeSpan timeSpanStart = new TimeSpan(int.Parse(txtAddStartNewAppointmentHour.Text), int.Parse(txtAddStartNewAppointmentMin.Text), int.Parse(txtAddStartNewAppointmentSec.Text));
                    TimeSpan timeSpanEnd = new TimeSpan(int.Parse(txtAddEndNewAppointmentHour.Text), int.Parse(txtAddEndNewAppointmentMin.Text), int.Parse(txtAddEndNewAppointmentSec.Text));

                    // checks whether input time values meet the default hours set, if not, display warning message
                    if ((timeSpanOpen > timeSpanStart) || (timeSpanOpen > timeSpanEnd))
                    {
                        MessageBox.Show("Reminder: Only available from 8AM to 6PM", "Warning!");
                    }
                    // checks whether input time values meet the default hours set

                    else if ((timeSpanClose < timeSpanStart) || (timeSpanClose < timeSpanEnd))
                    {
                        MessageBox.Show("Reminder: Only available from 8AM to 6PM", "Warning!");
                    }
                    else
                    {


                        //times are formatted in a way it works when making a query
                        // start times 
                        string dateStartT = $"{appointmentDate} {appointmentStart}";
                        string startTime = DateTime.Parse(dateStartT).ToUniversalTime().ToString();
                        //use split method to break a delimited string into substring 
                        string[] start1 = startTime.Split(' ');
                        string[] start2 = start1[0].Split('/');
                        string[] start3 = start1[1].Split(':');
                        string utcStart = "";
                        //check if conditions are met
                        if (start1[2] == "PM" && start3[1] != "12")
                        {
                            utcStart = $"{start2[2]}-{start2[0]}-{start2[1]} {int.Parse(start3[0]) + 12}:{start3[1]}:{start3[2]}";
                        }
                        else
                        {
                            utcStart = $"{start2[2]}-{start2[0]}-{start2[1]} {start1[1]}";
                        }

                        //times are formatted in a way it works when making a query
                        // end times 
                        string dateEndT = $"{appointmentDate} {appointmentEnd}";
                        string endTime = DateTime.Parse(dateEndT).ToUniversalTime().ToString();
                        //use split method to break a delimited string into substring 

                        string[] end1 = endTime.Split(' ');
                        string[] end2 = end1[0].Split('/');
                        string[] end3 = end1[1].Split(':');
                        string utcEnd = "";

                        if (end1[2] == "PM" && end1[0] != "12")
                        {
                            utcEnd = $"{end2[2]}-{end2[0]}-{end2[1]} {int.Parse(end3[0]) + 12}:{end3[1]}:{end3[2]}";
                        }
                        else
                        {
                            utcEnd = $"{end2[2]}-{end2[0]}-{end2[1]} {end1[1]}";
                        }


                        //function for checking if there's an appointment overlap
                        bool noOverlapAllowed()
                        {
                            bool isValid = false;
                            try
                            {
                                //establish connection to the database
                                MySqlConnection connection = getConnection();

                                //query to check is there is a time overlap between appointments per user
                                string timeOverLap =
                                    $"SELECT COUNT(*) FROM appointment WHERE start BETWEEN '{utcStart}' AND '{utcEnd}' AND userId={userId} OR end BETWEEN '{utcStart}' AND '{utcEnd}' AND userId={userId}";
                                MySqlCommand mySqlCommand = new MySqlCommand(timeOverLap, connection);
                                int timeOverlapIdx = Convert.ToInt32(mySqlCommand.ExecuteScalar());

                                if (timeOverlapIdx != 0)
                                {
                                    isValid = false;

                                }
                                else
                                {
                                    isValid = true;
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show("Error:" + ex);
                            }
                            return isValid;
                        }

                        //if there are no time overlapping found, connect and run command
                        if (noOverlapAllowed() == true)
                        {
                            try
                            {
                                //establish connection to the database
                                MySqlConnection connection = getConnection();


                                //use the appointment ID to do a query
                                string query = "SELECT appointmentId FROM appointment ORDER BY appointmentId DESC LIMIT 1";
                                MySqlCommand mySqlCommandApp = new MySqlCommand(query, connection);
                                int appointmentIdx = Convert.ToInt32(mySqlCommandApp.ExecuteScalar()) + 1;

                                //perform an insert query based on the input values received
                                string insert =
                                    $"INSERT INTO appointment VALUES({appointmentIdx}, {clientID}, {userId}, '{title}', '', '', '', '{appointmentType}', '', '{utcStart}', '{utcEnd}', NOW(), '', NOW(), '')";
                                MySqlCommand mySqlCommandInsert = new MySqlCommand(insert, connection);
                                mySqlCommandInsert.ExecuteNonQuery();
                                //closes the form automatically
                                this.Close();
                                formDashboard.loadAppointments();
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show("Error Message:" + ex);
                            }
                        }
                        else
                        {
                            //display an error message when there's a time overlap found 
                            MessageBox.Show($"Reminder: User:{userId} has already been assigned for an appointment.");
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }




        }



        private void btnSaveClient_Click(object sender, EventArgs e)
        {
        }

        //cancels the form and redirect
        private void btnCancelNewAppointment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddNewAppointmentTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddNewAppointmentClientId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddNewAppointmentUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbAddNewAppointmentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

