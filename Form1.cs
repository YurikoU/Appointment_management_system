/*
Student Name: Yuriko Uchida
Student Number: #200448500

Due: April 20th, 2021
Final Project
*/

using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Data;
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
            domainUpDownTreatment.Text = "--please select service--";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            maskedTextBoxPhone.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxPatientId.Text = "";
        }//End of button1_Click method


        private void buttonSee_Click(object sender, EventArgs e)
        {
            buttonSee.Enabled = false;
            groupBoxAppInfo.Visible = false;
            groupBoxSearch.Visible = false;
            buttonStartNew.Enabled = true;

            //Call Form2.cs to see the existing appointments
            Form2 frm2 = new Form2();
            frm2.Show();
        }//End of buttonSee_Click() method


        private void buttonStartNew_Click(object sender, EventArgs e)
        {
            buttonSee.Enabled = true;
            groupBoxAppInfo.Visible = true;
            groupBoxSearch.Visible = true;
            buttonStartNew.Enabled = false;
        }//End of buttonStartNew_Click() method


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
                MessageBox.Show(msg, "Some information is NOT valid.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DateTime end_time;
                if (treatment == "Dental Hygiene")
                {
                    //Only dental hygiene requires a hour
                    end_time = start_time.AddHours(1);
                }
                else
                {
                    //The other treatments all require two hours
                    end_time = start_time.AddHours(2);
                }

                try 
                {
                    //Connect to the database
                    string connection = "Server=localhost; Database=mysql_winter2021; uid=root; pwd=;";
                    MySqlConnection conn = new MySqlConnection(connection);
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    //Check if the date and time is available
                    cmd.CommandText = "select count(appointment_id) from appointment where((@start_time < end_time AND start_time <= @start_time)  OR  (start_time < @end_time AND @end_time <= end_time)  OR  (start_time <= @start_time AND @end_time <= end_time));";
                    cmd.Parameters.AddWithValue("@start_time", start_time);
                    cmd.Parameters.AddWithValue("@end_time", end_time);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    if (count != 0)
                    {
                        //If the appointment date or time is not available, the message will be shown
                        MessageBox.Show("Sorry! There are existing appointment(s) that have the same appointment time", "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } else
                    {
                        //Otherwise, a new appointment will be inserted into the database
                        try
                        {
                            conn.Open();
                            cmd.CommandText = "insert into appointment (start_time, end_time, treatment, patient_id, first_name, last_name, phone, email) values (@start_time, @end_time, @treatment, @patient_id, @first_name, @last_name, @phone, @email);";
                            cmd.Parameters.AddWithValue("@treatment", treatment);
                            cmd.Parameters.AddWithValue("@patient_id", patient_id);
                            cmd.Parameters.AddWithValue("@first_name", first_name);
                            cmd.Parameters.AddWithValue("@last_name", last_name);
                            cmd.Parameters.AddWithValue("@phone", phone);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.ExecuteNonQuery();

                            //Once successfully booked, the whole information will be shown
                            string success = "Successfully booked!" + "\nTime: " + start_time + "\nTreatment: " + treatment + "\nPatient ID: " + patient_id + "\nFirst Name" + first_name + "\nLast Name" + last_name + "\nPhone: " + phone + "\nE-mail: " + email;
                            MessageBox.Show(success, "Success!", MessageBoxButtons.OK);
                            conn.Close();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("[ERROR] " + a.Message, "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }


                }
                catch (Exception a)
                {
                    MessageBox.Show("[ERROR] " + a.Message, "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }//End of buttonBook_Click() method


        private void buttonSearchClear_Click(object sender, EventArgs e)
        {
            maskedTextBoxSearchPhone.Text = "";
            textBoxSearchPatientId.Text = "";
            textBoxSearchFirstName.Text = "";
            textBoxSearchLastName.Text = "";
            textBoxSearchEmail.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string phone_search = maskedTextBoxSearchPhone.Text;
            if (phone_search.Length < 15)
            {
                MessageBox.Show("Please enter a proper phone number.");
            }
            else {
                try
                {
                    //Connect to the database
                    string connection = "Server=localhost; Database=mysql_winter2021; uid=root; pwd=;";
                    MySqlConnection conn = new MySqlConnection(connection);
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    
                    //Show the patient info searching by their phone number from the database
                    cmd.CommandText = "select patient_id from patient where phone = @phone;";
                    cmd.Parameters.AddWithValue("@phone", phone_search);
                    if (Convert.ToString(cmd.ExecuteScalar()) == "")
                    {
                        //If the database doesn't have that phone number, the message will be shown
                        MessageBox.Show("There isn't a patient with the enterd phone number", "No Patient Found!", MessageBoxButtons.OK);
                        return;
                    }
                    else {
                        textBoxSearchPatientId.Text = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "select first_name from patient where phone = @phone;";
                        textBoxSearchFirstName.Text = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "select last_name from patient where phone = @phone;";
                        textBoxSearchLastName.Text = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "select email from patient where phone = @phone;";
                        textBoxSearchEmail.Text = Convert.ToString(cmd.ExecuteScalar());
                    }

                    //Close the database connection
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show("[ERROR] " + a.Message, "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }//End of buttonSearch_Click() method


    }//End of public partial class Form1 : Form
}//End of namespace Demo
