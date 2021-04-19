/*
Student Name: Yuriko Uchida
Student Number: #200448500

Due: April 20th, 2021
Final Project
*/


using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            string connection = "Server=localhost; Database=mysql_winter2021; uid=root; pwd=; ";
            MySqlConnection conn = new MySqlConnection(connection);
            //Connect to the database
            conn.Open();

            DataTable dt = new DataTable();
            string sql = "select appointment_id 'Appointment ID', start_time 'Start Time', end_time 'End Time', treatment Treatment, patient_id 'Patient ID', first_name 'First Name', last_name 'Last Name', phone 'Phone', email 'E-mail' from appointment where start_time >= now();";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);
            //Display all reservation on the app
            dataGridViewCalendar.DataSource = dt;
            //Close the database connection
            conn.Close();

        }
    }
}
