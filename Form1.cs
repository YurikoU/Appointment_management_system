/*
 Yuriko Uchida
#200448500 
 */



using DocumentFormat.OpenXml.Drawing.Diagrams;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject_Winter2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDownService.Items.Insert(0, "General Dentistry");
            domainUpDownService.Items.Insert(1, "Dental Hygiene");
            domainUpDownService.Items.Insert(2, "Pediatric Dentistry");
            domainUpDownService.Items.Insert(3, "Orthodontics");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dateTimePickerBooking.Value = DateTime.Now;
            domainUpDownService.Text = "General Dentistry";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            maskedTextBoxPhone.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxPatientId.Text = "";
        }

        private void buttonReview_Click(object sender, EventArgs e)
        {
            buttonReview.Enabled = false;
            groupBoxAppointmentInfo.Visible = false;
            buttonNew.Enabled = true;
            dataGridViewCalendar.Visible = true;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            buttonReview.Enabled = true;
            groupBoxAppointmentInfo.Visible = true;
            buttonNew.Enabled = false;
            dataGridViewCalendar.Visible = false;
        }
    }
}
