/*
Student Name: Yuriko Uchida
Student Number: #200448500

Due: April 20th, 2021
Final Project
*/

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDownTreatment.Items.Insert(0, "General Dentistry");
            domainUpDownTreatment.Items.Insert(1, "Dental Hygiene");
            domainUpDownTreatment.Items.Insert(2, "Pediatric Dentistry");
            domainUpDownTreatment.Items.Insert(3, "Orthodontics");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reset the input
            dateTimePickerApp.Value = DateTime.Now;
            domainUpDownTreatment.Text = "  -------------------------";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            maskedTextBoxPhone.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxPatientId.Text = "";
        }

        private void buttonSee_Click(object sender, EventArgs e)
        {
            buttonSee.Enabled = false;
            groupBoxAppInfo.Visible = false;
            buttonStartNew.Enabled = true;

            //Call Form2.cs to see the existing appointments
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void buttonStartNew_Click(object sender, EventArgs e)
        {
            buttonSee.Enabled = true;
            groupBoxAppInfo.Visible = true;
            buttonStartNew.Enabled = false;
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            string connection = "Server=localhost; Database=mysql_winter2021; uid=root; pwd=; ";
            MySqlConnection conn = new MySqlConnection(connection);
            //Connect to the database
            conn.Open();
            DataTable dt = new DataTable();
            string sql = "select appointment_id 'Appointment ID', start_time 'Start Time', end_time 'End Time', treatment Treatment, patient_id 'Patient ID', first_name 'First Name', last_name 'Last Name', phone 'Phone', email 'E-mail' from appointment where start_time >= now();";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);
            //Display all reservation on the app
            //dataGridViewCalendar.DataSource = dt;
            //Close the database connection
            //conn.Close();

            if (dateTimePickerApp.Value <= DateTime.Now)
            {
                richTextBoxAlert.Text = "Appointment time must be later than the current time."
            }


        }
    }
}
