using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultingScheduleApp
{
    public partial class frmLogIn : Form
    {
        FormDashboard formDashboard = new FormDashboard();

        string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        //establish reusable connection
        protected MySqlConnection getConnection()
        {
            var connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }
        public frmLogIn()
        {
           
            InitializeComponent();
     
            //form controls are in Spanish 
            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
            {
                lblUser.Text = "Nombre de usuario";
                lblPassword.Text = "Contraseña";
                btnLogIn.Text = "Acceso";
                btnExitApp.Text = "Salida";
            }

        }
        
        private void frmLogIn_Load(object sender, EventArgs e)
        {
         
        }

        //user log in 
        private void btnLogIn_Click(object sender, EventArgs e)
        {

            try
            {
                // this is the txt path to the file
                string log = @"C:\Users\LabUser\Desktop\myuserlog.txt.txt";

                //string log = @"C:\Users\LabUser\Desktop\myuserlog.txt.txt";

                //test on my local machine
                //string log = @"C:\Users\theav\OneDrive\Desktop\atest.txt.txt";
                //establish database connection
                MySqlConnection connection = getConnection();

                //capture input values and assign to variables
                string userName = txtUserName.Text;
                string passWord = txtPassword.Text;

                //get query from user
                string userQuery = $"SELECT * FROM user WHERE userName='{userName}' AND password='{passWord}'";
                MySqlCommand command = new MySqlCommand(userQuery, connection);
                var lineReader = command.ExecuteReader();
                if (lineReader.HasRows)
                {
                    // to check whether there is an appointment within 15 minutes
                    // write the log in information (successful or unsuccessful)
                    if (remindNextAppointment() != true)
                    {
                        //MessageBox.Show("Welcome! You've logged in successfully!");
                        formDashboard.Show();
                        this.Hide();

                        //to write log ins to logusertrack.txt
                        try
                        {
                            var textDisplaySuccess = $"OK! Login Information: {userName} ---- {DateTime.Now} {Environment.NewLine}";

                            // Check if file exists
                            if (File.Exists(log))
                            {
                                // Check whether file is empty or not
                                if (new FileInfo(log).Length == 0)
                                {
                                    // If file is empty, write text:
                                    File.AppendAllText(log, textDisplaySuccess + Environment.NewLine);
                                }
                                else
                                {
                                    // If file is not empty, write (appends text):
                                    File.AppendAllText(log, textDisplaySuccess + Environment.NewLine);
                                }
                            }
                            else
                            {
                                // If file not exist, create it and write text
                                File.AppendAllText(log, textDisplaySuccess + Environment.NewLine);
                            }                           
                        }
                        //catch error 
                        catch (IOException ex)
                        {
                            MessageBox.Show("Error:" + ex);
                        }

                    }
                    else
                    {
                        MessageBox.Show($"Reminder: {userName} ---- appointment assigned within 15 minutes.");
                        formDashboard.Show();
                        this.Hide();
                    }
                }
                   
                // if everything checks out, below runs for languages English / Spanish
                
                else
                {
                    //English display text when user fails to log in 
                    if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
                    {
                        MessageBox.Show("Invalid credentials. Please try again.");
                    }
                    //Spanish display text when user fails to log in
                    else if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
                    {
                        MessageBox.Show("Credenciales no válidas. Inténtalo de nuevo.");
                    }

                    try
                    {
                        //to write user's failed attempts to log in

                        if (File.Exists(log) == false)
                        {
                            File.Create(log).Dispose();

                            using (TextWriter textWriter = new StreamWriter(log))
                            {
                                textWriter.WriteLine($"Denied! Login Information: {userName} ----{DateTime.Now} {Environment.NewLine}");
                            }
                        }
                        else if (File.Exists(log) == true)
                        {
                            File.AppendAllText(log, $"Denied! ********* Login Information: {userName} ---- {DateTime.Now} {Environment.NewLine}");
                        }

                    }
                    catch (IOException error)
                    {
                        MessageBox.Show("Error Message:" + error);
                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Something went wrong, try connecting again");
            }



        }

        //to remind user if there's an appointment in line within 15 minutes
        private bool remindNextAppointment()
        {
            //establish connection
            MySqlConnection connection = getConnection();

            string username = txtUserName.Text;
            bool isValid = false;

            // running a query if any appointments within 15 minutes exist
            try
            {
                string reminderQuery =
                    $"SELECT * FROM appointment WHERE start BETWEEN NOW() AND NOW() + INTERVAL 15 MINUTE AND userId=(SELECT userId FROM user WHERE userName='{username}')";
                MySqlCommand mySqlCommand = new MySqlCommand(reminderQuery, connection);
                // to retrieve a value on first columns of first row
                int reminderAppointmentIdx = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                if (reminderAppointmentIdx == 0)
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
                MessageBox.Show("Error Message:" + ex);
            }
            return isValid;
        }

        //closes the application
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
