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
    public partial class FormCumulativeSummary : Form
    {

        public string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        //establish reusable connection
        protected MySqlConnection getConnection()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }

        public FormCumulativeSummary()
        {
            InitializeComponent();
        }

        private void FormCumulativeSummary_Load(object sender, EventArgs e)
        {
            //formCumulative display
            this.dgCumulativeTotalCount.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dgCumulativeTotalCount.AlternatingRowsDefaultCellStyle.BackColor =
                Color.SkyBlue;
            loadCumulativeCountSummary();

        }

        private void loadCumulativeCountSummary()
        {


            try
            {
               
                //establish connection to the database
                MySqlConnection connection = getConnection();
            

                //string query = "SELECT * FROM appointment WHERE MONTH(appointment.start)=MONTH(NOW()) AND YEAR(appointment.start)=YEAR(NOW())";
                //presentation query
                string presentation = $"SELECT COUNT(*) FROM appointment WHERE type='Oil Change' AND month(start) AND year(appointment.start)=year(NOW())";
                MySqlCommand presentationCommand = new MySqlCommand(presentation, connection);
                int presentationIdx = Convert.ToInt32(presentationCommand.ExecuteScalar());
                //add a row to the monthly summary
                dgCumulativeTotalCount.Rows.Add("Current Year: Oil Change:", presentationIdx);

                //scrum query
                string scrum = $"SELECT COUNT(*) FROM appointment WHERE type='AC and Heating System' AND month(start) AND year(appointment.start)=year(NOW())";
                MySqlCommand scrumCommand = new MySqlCommand(scrum, connection);
                int scrumIdx = Convert.ToInt32(scrumCommand.ExecuteScalar());
                //add a row to the monthly summary
                dgCumulativeTotalCount.Rows.Add("Current Year: AC and Heating System:", scrumIdx);

                //general consultation query
                string generalConsultation = $"SELECT COUNT(*) FROM appointment WHERE type='Tire Services' AND month(start) AND year(appointment.start)=YEAR(NOW())";
                MySqlCommand generalConsultationCommand = new MySqlCommand(generalConsultation, connection);
                int generalConsultationIdx = Convert.ToInt32(generalConsultationCommand.ExecuteScalar());
                //add a row to the monthly summary
                dgCumulativeTotalCount.Rows.Add("Current Year: Tire Services:", generalConsultationIdx);

                //query of total appointment count 
                string query = "SELECT COUNT(*) FROM appointment WHERE year(appointment.start)=year(NOW())";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                int cumulativeCountTotalIdx = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                //adds the count to the datagridview
                dgCumulativeTotalCount.Rows.Add("Current year Total Appointments:", cumulativeCountTotalIdx);
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error Message:" + error);
            }
        }

        //loads the count of the cumulative summary form
        private void btnCumulativeCount_Click(object sender, EventArgs e)
        {
            loadCumulativeCountSummary();
        }

        //closes the cumulative summary form
        private void btnExitCumulativeCount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgCumulativeTotalCount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCumulativeAppointmentCount_Click(object sender, EventArgs e)
        {

        }
    }
}