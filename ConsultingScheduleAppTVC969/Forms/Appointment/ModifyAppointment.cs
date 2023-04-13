using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ConsultingScheduleApp.Forms.Appointment
{
    public partial class FormModifyAppointment : Form
    {


        string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        FormDashboard formDashboard = new FormDashboard();


        //establish reusable connection
        protected MySqlConnection getConnection()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }


        private delegate bool LetSave();
        public FormModifyAppointment(Form form)
        {
            formDashboard = form as FormDashboard;
            InitializeComponent();
        }

        private void FormModifyAppointment_Load(object sender, EventArgs e)
        {
            //assign values to variables according to the index on the database table
            txtModifyAppointmentClientId.Text = formDashboard.dgAppointmentView.SelectedRows[0].Cells[1].Value.ToString();
            txtModifyAppointmentUserId.Text = formDashboard.dgAppointmentView.SelectedRows[0].Cells[2].Value.ToString();
            cmbModifyAppointmentType.Text = formDashboard.dgAppointmentView.SelectedRows[0].Cells[7].Value.ToString();
            txtModifyAppointmentTitle.Text = formDashboard.dgAppointmentView.SelectedRows[0].Cells[3].Value.ToString();
            string timeStartRef = formDashboard.dgAppointmentView.SelectedRows[0].Cells[9].Value.ToString();
            string timeEndRef = formDashboard.dgAppointmentView.SelectedRows[0].Cells[10].Value.ToString();

            //formatting date
            string[] date = timeStartRef.Split('/');
            txtModiyMonthAppointment.Text = date[0];
            txtModifyAppointmentDay.Text = date[1];
            string[] year = date[2].Split(' ');
            txtYearModifyAppointment.Text = year[0];

            //formatting start time
            string[] timeDateStartRef = timeStartRef.Split(' ');
            string[] timeStartRefB = timeDateStartRef[1].Split(':');

            

            //check if conditions are met then assign the value to the textbox
            if (timeDateStartRef[2] == "PM" && timeStartRefB[0] != "12")
            {
               
                txtStartModifyNewAppointmentHour.Text = (int.Parse(timeStartRefB[0]) + 12).ToString();
            }
            else if (timeDateStartRef[2] == "AM" && timeStartRefB[0] == "12")
            {
                txtStartModifyNewAppointmentHour.Text = "00";
            }
            else
            {
                txtStartModifyNewAppointmentHour.Text = timeStartRefB[0];
            }

            //assign values to the textboxes
            txtStartModifyNewAppointmentMin.Text = timeStartRefB[1];
            txtStartModifyNewAppointmentSec.Text = timeStartRefB[2];


            //formatting end time
            string[] timeDateEnd = timeEndRef.Split(' ');
            string[] timeDateEndB = timeDateEnd[1].Split(':');
            //check if conditions are met then assign the value to the textbox
            if (timeDateEnd[2] == "PM" && timeDateEndB[0] != "12")
            {
                txtEndModifyNewAppointmentHour.Text = (int.Parse(timeDateEndB[0]) + 12).ToString();
            }
            else if (timeDateEnd[2] == "AM" && timeDateEndB[0] == "12")
            {
                txtEndModifyNewAppointmentHour.Text = "00";
            }
            else
            {
                txtEndModifyNewAppointmentHour.Text = timeDateEndB[0];
            }

            txtEndModifyNewAppointmentMin.Text = timeDateEndB[1];
            txtEndModifyNewAppointmentSec.Text = timeDateEndB[2];

           

        }


        //closes the form
        private void btnCancelModifyAppointment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formatTime()
        {

        }


        private void btnSaveModifyAppointment_Click(object sender, EventArgs e)
        {

            // this function checks whether the input from the user are are not null.
            LetSave letSave = () =>
            {

                if (txtStartModifyNewAppointmentHour.Text == "" && txtStartModifyNewAppointmentMin.Text == "" && txtStartModifyNewAppointmentSec.Text == "")
                {
                    return false;
                }
                if (txtEndModifyNewAppointmentHour.Text == "" && txtEndModifyNewAppointmentMin.Text == "" && txtEndModifyNewAppointmentSec.Text == "")
                {
                    return false;

                }
                if (txtYearModifyAppointment.Text == "" && txtModiyMonthAppointment.Text == "" && txtModifyAppointmentDay.Text == "")
                {
                    return false;

                }
                if (txtModifyAppointmentTitle.Text == "")
                {
                    return false;
                }
                if (txtModifyAppointmentClientId.Text == "")
                {
                    return false;
                }
                if (txtModifyAppointmentUserId.Text == "")
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
                MessageBox.Show("All fields are required", "Warning!");
            }
            else
            {
                try
                {

                    //capture input values and assign to variables
                    string appointmentId = formDashboard.dgAppointmentView.SelectedRows[0].Cells[0].Value.ToString();
                    string title = txtModifyAppointmentTitle.Text;
                    string clientID = txtModifyAppointmentClientId.Text;
                    string userID = txtModifyAppointmentUserId.Text;
                    string appointmentType = cmbModifyAppointmentType.Text;
                    string appointmentStart = $"{txtStartModifyNewAppointmentHour.Text}:{txtStartModifyNewAppointmentMin.Text}:{txtStartModifyNewAppointmentSec.Text}";
                    string appointmentEnd = $"{txtEndModifyNewAppointmentHour.Text}:{txtEndModifyNewAppointmentMin.Text}:{txtEndModifyNewAppointmentSec.Text}";
                    string appointmentDate = $"{txtYearModifyAppointment.Text}-{txtModiyMonthAppointment.Text}-{txtModifyAppointmentDay.Text}";


                    //default hours the application is allowing (8AM - 6PM)
                    TimeSpan timeSpanOpen = new TimeSpan(08, 0, 0);
                    TimeSpan timeSpanClose = new TimeSpan(18, 0, 0);

                    //input values are assigned 
                    TimeSpan timeSpanStart = new TimeSpan(int.Parse(txtStartModifyNewAppointmentHour.Text), int.Parse(txtStartModifyNewAppointmentMin.Text), int.Parse(txtStartModifyNewAppointmentSec.Text));
                    TimeSpan timeSpandEnd = new TimeSpan(int.Parse(txtEndModifyNewAppointmentHour.Text), int.Parse(txtEndModifyNewAppointmentMin.Text), int.Parse(txtEndModifyNewAppointmentSec.Text));

                    // checks whether input time values meet the default hours set, if not, display warning message

                    if ((timeSpanOpen > timeSpanStart) || (timeSpanOpen > timeSpandEnd))
                    {
                        MessageBox.Show("Reminder: Only available from 8AM to 6PM", "Warning!");
                    }
                    else if ((timeSpanClose < timeSpanStart) || (timeSpanClose < timeSpandEnd))
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

                        //check if conditiones are met
                        if (end1[2] == "PM" && end1[0] != "12")
                        {
                            utcEnd = $"{end2[2]}-{end2[0]}-{end2[1]} {int.Parse(end3[0]) + 12}:{end3[1]}:{end3[2]}";
                        }
                        else
                        {
                            utcEnd = $"{end2[2]}-{end2[0]}-{end2[1]} {end1[1]}";
                        }


                        //function for checking if there's appointment overlap
                        bool noOverlapAllowed()
                        {
                            bool isValid = false;
                            try
                            {
                                //establish connection to the database
                                MySqlConnection connection = getConnection();

                                //query to check is there is a time overlap between appointments per user 
                                string timeOverLap =
                                    $"SELECT COUNT(*) FROM appointment WHERE start BETWEEN '{utcStart}' AND '{utcEnd}' AND userId={userID} OR end BETWEEN '{utcStart}' AND '{utcEnd}' AND userId={userID}";
                                MySqlCommand mySqlCommand = new MySqlCommand(timeOverLap, connection);
                                int timeOverlapIdx = Convert.ToInt32(mySqlCommand.ExecuteScalar());

                                //correction here
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
                                //establish connection
                                MySqlConnection connection = getConnection();

                                string update =
                                    $"UPDATE appointment SET type='{appointmentType}', title='{title}',customerId={clientID}, userId={userID}, start='{utcStart}', end='{utcEnd}' WHERE appointmentId={appointmentId}";
                                MySqlCommand mySqlCommand = new MySqlCommand(update, connection);
                                mySqlCommand.ExecuteNonQuery();
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
                            MessageBox.Show($"Reminder: User:{userID} has already been assigned for an appointment.");
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
