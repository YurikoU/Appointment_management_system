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
            //dataGridViewCalendar.Visible = true;

            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void buttonStartNew_Click(object sender, EventArgs e)
        {
            buttonSee.Enabled = true;
            groupBoxAppInfo.Visible = true;
            buttonStartNew.Enabled = false;
            //dataGridViewCalendar.Visible = false;
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {

        }
    }
}
