/*
Student Name: Yuriko Uchida
Student Number: #200448500

Due: April 20th, 2021
Final Project
*/

using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
            domainUpDownTreatment.Text = "  ----------------------  ";
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
            bool validation = true;
            string validation_msg = "";
            string time = dateTimePickerApp.Value.ToShortDateString();
            string treatment = domainUpDownTreatment.Text;
            string patient_id = maskedTextBoxPatientId.Text;
            string first_name = textBoxFirstName.Text;
            string last_name = textBoxLastName.Text;
            string phone = maskedTextBoxPhone.Text;
            string email = textBoxEmail.Text;

//            if (dateTimePickerApp.Value.Date <= DateTime.Now)
//            {
//                validation_msg += "Appointment time must be later than the current time.\n";
//                validation = false;
//            }
            if (domainUpDownTreatment.Text == "  ----------------------  ")
            {
                validation_msg += "Please select appropriate treatment.\n";
                validation = false;
            }
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "")
            {
                validation_msg += "Please enter first and last name.\n";
                validation = false;
            }
            if (maskedTextBoxPhone.Text.Length < 11)
            {
                validation_msg += "Please enter a proper phone number.\n";
                validation = false;
            }


            if (!validation)
            { 
             richTextBoxAlert.Text = validation_msg;
            
            }


            if (validation)
            {
                try
                {
                    string connection = "Server=localhost; Database=mysql_winter2021; uid=root; pwd=; ";
                    MySqlConnection conn = new MySqlConnection(connection);
                    //Connect to the database
                    conn.Open();
                    string sql = "insert into appointment (start_time, treatment, patient_id, first_name, last_name, phone, email) values (" + time + ", " + treatment + ", " + patient_id + ", " + first_name + ", " + last_name + ", " + phone + ", " + email + ");";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully booked!" + "\nTime: " + dateTimePickerApp.Text + "\nTreatment: " + domainUpDownTreatment.Text + "\nPatient ID: " + maskedTextBoxPatientId.Text + "\nFirst Name" + textBoxFirstName.Text + "\nLast Name" + textBoxLastName.Text + "\nPhone: " + maskedTextBoxPhone.Text + "\nE-mail: " + textBoxEmail.Text);
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show("[ERROR] " + a.Message);
                }
            }
        }
    }
}
