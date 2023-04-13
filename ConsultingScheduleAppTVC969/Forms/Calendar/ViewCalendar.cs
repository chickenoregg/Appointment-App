using ConsultingScheduleApp.Forms.Appointment;
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

namespace ConsultingScheduleApp.Forms
{
    public partial class FormCalendarView : Form
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
        public FormCalendarView()
        {
            InitializeComponent();
            //calendarview display 
            this.dgCalendarViewWeekMonth.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dgCalendarViewWeekMonth.AlternatingRowsDefaultCellStyle.BackColor =
                Color.LightSkyBlue;
        }


        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            //instantiate and opens the formAddNewAppointment form
            FormAddNewAppointment formAddNewAppointment = new FormAddNewAppointment(this);
            formAddNewAppointment.ShowDialog();
        }



        

        private void rbtnCalendarWeeklyView_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //establish connection
                MySqlConnection connection = getConnection();

                //query for all appointments for the current week of the current year
                string query = "SELECT * FROM appointment WHERE week(appointment.start)=week(NOW()) AND year(appointment.start)=year(NOW())";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                //iterate each week based on the total count and convert to local time
                for (int week = 0; week < dataTable.Rows.Count; week++)
                {
                    var timeStart = dataTable.Rows[week]["start"];
                    var timeEnd = dataTable.Rows[week]["end"];
                    DateTime dateTime = (DateTime)timeStart;
                    DateTime dateTime1 = (DateTime)timeEnd;
                    dataTable.Rows[week]["start"] = dateTime.ToLocalTime();
                    dataTable.Rows[week]["end"] = dateTime1.ToLocalTime();
                }
                //removes columns that are automatically generated during binding
                dgCalendarViewWeekMonth.AutoGenerateColumns = true;
                dgCalendarViewWeekMonth.DataSource = dataTable;
                dgCalendarViewWeekMonth.Columns.Remove("description");
                dgCalendarViewWeekMonth.Columns.Remove("location");
                dgCalendarViewWeekMonth.Columns.Remove("contact");
                dgCalendarViewWeekMonth.Columns.Remove("url");
                dgCalendarViewWeekMonth.Columns.Remove("createdBy");
                dgCalendarViewWeekMonth.Columns.Remove("lastUpdate");
                dgCalendarViewWeekMonth.Columns.Remove("lastUpdateBy");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Message:" + ex);
            }
        }

        
        private void rbtnCalendarMonthlyView_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //establish connection
                MySqlConnection connection = getConnection();

                //query for all appointments for the current month  of the current year
                string query = "SELECT * FROM appointment WHERE month(appointment.start)=month(NOW()) AND year(appointment.start)=year(NOW())";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                //iterate each month based on the total count and convert to local time
                for (int month = 0; month < dataTable.Rows.Count; month++)
                {
                    var timeStart = dataTable.Rows[month]["start"];
                    var timeEnd = dataTable.Rows[month]["end"];
                    DateTime dateTime = (DateTime)timeStart;
                    DateTime dateTime1 = (DateTime)timeEnd;
                    dataTable.Rows[month]["start"] = dateTime.ToLocalTime();
                    dataTable.Rows[month]["end"] = dateTime1.ToLocalTime();
                }

                //removes columns that are automatically generated during binding
                dgCalendarViewWeekMonth.AutoGenerateColumns = true;
                dgCalendarViewWeekMonth.DataSource = dataTable;
                dgCalendarViewWeekMonth.Columns.Remove("description");
                dgCalendarViewWeekMonth.Columns.Remove("location");
                dgCalendarViewWeekMonth.Columns.Remove("contact");
                dgCalendarViewWeekMonth.Columns.Remove("url");
                dgCalendarViewWeekMonth.Columns.Remove("createdBy");
                dgCalendarViewWeekMonth.Columns.Remove("lastUpdate");
                dgCalendarViewWeekMonth.Columns.Remove("lastUpdateBy");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Message:" + ex);

            }
        }

        private void FormCalendarView_Load(object sender, EventArgs e)
        {

        }

        private void btnExitCalendar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
