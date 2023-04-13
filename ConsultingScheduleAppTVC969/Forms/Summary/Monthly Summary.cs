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
    public partial class FormMonthlySummary : Form
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

 
        public FormMonthlySummary()
        {
            InitializeComponent();
            //monthlySummaryView display
            this.dgMonthlySummaryView.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dgMonthlySummaryView.AlternatingRowsDefaultCellStyle.BackColor =
                Color.LightSkyBlue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //a method to populate months to be selected by the user
        private void generateMonth()
        {
            //generates 12 months in numbers to be added to the combo box

            for (int month = 1; month <= 12; month++)
            {
                //add the number to the combo box on the form
                cmbMontlySelection.Items.Add(month);
            }

 

        }
        private void btnLoadMonthlySummary_Click(object sender, EventArgs e)
        {
            //if no month is selected, display an error message
            if (cmbMontlySelection.Text == "")
            {
                MessageBox.Show("You must select a month to view summary");
            }
            else
            {
                //otherwise, assign the value to a variable
                string monthSelected = cmbMontlySelection.Text;
                dgMonthlySummaryView.Rows.Clear();
                
                try
                {
                    //establish connection to the database
                    MySqlConnection connection = getConnection();

                    //scrum query
                    string scrum = $"SELECT COUNT(*) FROM appointment WHERE type='Oil Change' AND month(start)={monthSelected} AND year(appointment.start)=year(NOW())";
                    MySqlCommand scrumCommand = new MySqlCommand(scrum, connection);
                    int scrumIdx = Convert.ToInt32(scrumCommand.ExecuteScalar());
                    //add a row to the monthly summary
                    dgMonthlySummaryView.Rows.Add("Oil Change:", scrumIdx);

                    //general consultation query
                    string generalConsultation = $"SELECT COUNT(*) FROM appointment WHERE type='AC and Heating System' AND month(start)={monthSelected} AND year(appointment.start)=YEAR(NOW())";
                    MySqlCommand generalConsultationCommand = new MySqlCommand(generalConsultation, connection);
                    int generalConsultationIdx = Convert.ToInt32(generalConsultationCommand.ExecuteScalar());
                    //add a row to the monthly summary
                    dgMonthlySummaryView.Rows.Add("AC and Heating System:", generalConsultationIdx);

                    //string query = "SELECT * FROM appointment WHERE MONTH(appointment.start)=MONTH(NOW()) AND YEAR(appointment.start)=YEAR(NOW())";
                    //presentation query
                    string presentation = $"SELECT COUNT(*) FROM appointment WHERE type='Tire Services' AND month(start)={monthSelected} AND year(appointment.start)=year(NOW())";
                    MySqlCommand presentationCommand = new MySqlCommand(presentation, connection);
                    int presentationIdx = Convert.ToInt32(presentationCommand.ExecuteScalar());
                    //add a row to the monthly summary
                    dgMonthlySummaryView.Rows.Add("Tire Services:", presentationIdx);

                }
                catch (MySqlException error)
                {

                    MessageBox.Show("Error Message:" + error.ToString());
                }


            }
           
        }

        //displays appointments to the Monthly Summary datagrid
        private void FormMonthlySummary_Load(object sender, EventArgs e)
        {
            generateMonth();
        }
        
        //closes the form and redirect
        private void btnExitMonthlySummary_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnDec_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnNov_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnOct_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnSep_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnAug_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
