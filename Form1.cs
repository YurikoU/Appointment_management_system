/*
Student Name: Yuriko Uchida
Student Number: #200448500

Due: April 20th, 2021
Final Project
*/

using MySql.Data.MySqlClient;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePickerApp.Value = DateTime.Now;
            domainUpDownTreatment.Items.Insert(0, "General Dentistry");
            domainUpDownTreatment.Items.Insert(1, "Dental Hygiene");
            domainUpDownTreatment.Items.Insert(2, "Pediatric Dentistry");
            domainUpDownTreatment.Items.Insert(3, "Orthodontics");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Reset the input
            dateTimePickerApp.Value = DateTime.Now;
            domainUpDownTreatment.Text = "--please select servicde--";
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
            string msg = "";
            DateTime now = DateTime.Now;
            DateTime start_time = dateTimePickerApp.Value;
            TimeSpan start_time_only = start_time.TimeOfDay;
            TimeSpan start_business = new TimeSpan(10, 30, 0);
            TimeSpan end_business = new TimeSpan(17, 00, 0);

            string treatment = domainUpDownTreatment.Text;
            string patient_id = maskedTextBoxPatientId.Text;
            string first_name = textBoxFirstName.Text;
            string last_name = textBoxLastName.Text;
            string phone = maskedTextBoxPhone.Text;
            string email = textBoxEmail.Text;

            EmailAddressAttribute email_validation = new EmailAddressAttribute();


            //Validation----------------------------------------------------------------------------------
            if (start_time <= now)
            {
                msg += "Appointment time must be later than the current time.\n";
                validation = false;
            }
            if (start_time_only < start_business || end_business < start_time_only)
            {
                msg += "Appointment time must be between 10:30-17:00.\n";
                validation = false;
            }
            if (treatment == "--please select servicde--")
            {
                msg += "Please select an appropriate treatment.\n";
                validation = false;
            }
            if (patient_id.Length != 5)
            {
                msg += "Patient ID must be five degits.\n";
                validation = false;
            }
            if (first_name == "" || last_name == "")
            {
                msg += "Please enter first and last name.\n";
                validation = false;
            }
            if (!Regex.IsMatch(first_name, @"^[a-zA-Z]+$") || !Regex.IsMatch(last_name, @"^[a-zA-Z]+$"))
            {
                msg += "First and last name must be alphabets only.\n";
                validation = false;
            }
            if (phone.Length < 15)
            {
                msg += "Please enter a proper phone number.\n";
                validation = false;
            }
            if (email != "")
            {
                if (!email_validation.IsValid(email))
                {
                    msg += "Please enter a properly formatted e-mail address.\n";
                    validation = false;
                }
            }
            //End of validation---------------------------------------------------------------------------


            if (!validation)
            {
                //If any information is not valid, the message will be shown
                MessageBox.Show(msg);
            }
            else
            {
                try
                {
                    DateTime end_time;
                    if (treatment == "Dental Hygiene")
                    {
                        end_time = start_time.AddHours(1);
                    }
                    end_time = start_time.AddHours(2);
                    string start_time_string = start_time.ToString("yyyy/MM/dd HH:mm");
                    string end_time_string = end_time.ToString("yyyy/MM/dd HH:mm");

                    string connection = "Server=localhost; Database=mysql_winter2021; uid=root; pwd=; ";
                    MySqlConnection conn = new MySqlConnection(connection);
                    //Connect to the database
                    conn.Open();
                    string sql = "insert into appointment (start_time, end_time, treatment, patient_id, first_name, last_name, phone, email) values (" + start_time_string + ", " + end_time_string + ", "+ treatment + ", " + patient_id + ", " + first_name + ", " + last_name + ", " + phone + ", " + email + ");";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully booked!" + "\nTime: " + start_time + "\nTreatment: " + treatment + "\nPatient ID: " + patient_id + "\nFirst Name" + first_name + "\nLast Name" + last_name + "\nPhone: " + phone + "\nE-mail: " + email);
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
