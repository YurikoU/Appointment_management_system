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
            string connection = "Server=localhost;Database=mysql_winter2021;uid=root;pwd=";

            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();    // 接続

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from clown_info;", conn);
            da.Fill(dt);
            dataGridViewCalendar.DataSource = dt;
            //                conn.Close();	// 接続の解除




        }
    }
}
