
namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSee = new System.Windows.Forms.Button();
            this.buttonStartNew = new System.Windows.Forms.Button();
            this.groupBoxAppInfo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPatientId = new System.Windows.Forms.MaskedTextBox();
            this.domainUpDownTreatment = new System.Windows.Forms.DomainUpDown();
            this.labelPatientId = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelTreatment = new System.Windows.Forms.Label();
            this.dateTimePickerApp = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelRequired = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewCalendar = new System.Windows.Forms.DataGridView();
            this.groupBoxAppInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSee
            // 
            this.buttonSee.Location = new System.Drawing.Point(243, 12);
            this.buttonSee.Name = "buttonSee";
            this.buttonSee.Size = new System.Drawing.Size(200, 35);
            this.buttonSee.TabIndex = 0;
            this.buttonSee.Text = "See calendar";
            this.buttonSee.UseVisualStyleBackColor = true;
            this.buttonSee.Click += new System.EventHandler(this.buttonSee_Click);
            // 
            // buttonStartNew
            // 
            this.buttonStartNew.Location = new System.Drawing.Point(518, 12);
            this.buttonStartNew.Name = "buttonStartNew";
            this.buttonStartNew.Size = new System.Drawing.Size(200, 35);
            this.buttonStartNew.TabIndex = 1;
            this.buttonStartNew.Text = "Start a new reservation";
            this.buttonStartNew.UseVisualStyleBackColor = true;
            // 
            // groupBoxAppInfo
            // 
            this.groupBoxAppInfo.Controls.Add(this.button1);
            this.groupBoxAppInfo.Controls.Add(this.buttonBook);
            this.groupBoxAppInfo.Controls.Add(this.textBoxEmail);
            this.groupBoxAppInfo.Controls.Add(this.maskedTextBoxPhone);
            this.groupBoxAppInfo.Controls.Add(this.textBoxLastName);
            this.groupBoxAppInfo.Controls.Add(this.textBoxFirstName);
            this.groupBoxAppInfo.Controls.Add(this.maskedTextBoxPatientId);
            this.groupBoxAppInfo.Controls.Add(this.domainUpDownTreatment);
            this.groupBoxAppInfo.Controls.Add(this.labelPatientId);
            this.groupBoxAppInfo.Controls.Add(this.labelEmail);
            this.groupBoxAppInfo.Controls.Add(this.labelPhone);
            this.groupBoxAppInfo.Controls.Add(this.labelLastName);
            this.groupBoxAppInfo.Controls.Add(this.labelFirstName);
            this.groupBoxAppInfo.Controls.Add(this.labelTreatment);
            this.groupBoxAppInfo.Controls.Add(this.dateTimePickerApp);
            this.groupBoxAppInfo.Controls.Add(this.labelTime);
            this.groupBoxAppInfo.Controls.Add(this.labelRequired);
            this.groupBoxAppInfo.Controls.Add(this.label8);
            this.groupBoxAppInfo.Controls.Add(this.label7);
            this.groupBoxAppInfo.Controls.Add(this.label6);
            this.groupBoxAppInfo.Controls.Add(this.label5);
            this.groupBoxAppInfo.Controls.Add(this.label4);
            this.groupBoxAppInfo.Location = new System.Drawing.Point(243, 78);
            this.groupBoxAppInfo.Name = "groupBoxAppInfo";
            this.groupBoxAppInfo.Size = new System.Drawing.Size(475, 355);
            this.groupBoxAppInfo.TabIndex = 2;
            this.groupBoxAppInfo.TabStop = false;
            this.groupBoxAppInfo.Text = "Appointment Information";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(389, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(195, 291);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(80, 35);
            this.buttonBook.TabIndex = 15;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(233, 238);
            this.textBoxEmail.MaxLength = 40;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 26);
            this.textBoxEmail.TabIndex = 13;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(233, 206);
            this.maskedTextBoxPhone.Mask = "(999) 0000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(200, 26);
            this.maskedTextBoxPhone.TabIndex = 12;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(233, 174);
            this.textBoxLastName.MaxLength = 25;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 26);
            this.textBoxLastName.TabIndex = 11;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(233, 142);
            this.textBoxFirstName.MaxLength = 25;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 26);
            this.textBoxFirstName.TabIndex = 10;
            // 
            // maskedTextBoxPatientId
            // 
            this.maskedTextBoxPatientId.Location = new System.Drawing.Point(233, 110);
            this.maskedTextBoxPatientId.Mask = "00000";
            this.maskedTextBoxPatientId.Name = "maskedTextBoxPatientId";
            this.maskedTextBoxPatientId.Size = new System.Drawing.Size(200, 26);
            this.maskedTextBoxPatientId.TabIndex = 9;
            this.maskedTextBoxPatientId.ValidatingType = typeof(int);
            // 
            // domainUpDownTreatment
            // 
            this.domainUpDownTreatment.Location = new System.Drawing.Point(233, 78);
            this.domainUpDownTreatment.Name = "domainUpDownTreatment";
            this.domainUpDownTreatment.Size = new System.Drawing.Size(200, 26);
            this.domainUpDownTreatment.TabIndex = 8;
            this.domainUpDownTreatment.Text = "  -------------------------";
            // 
            // labelPatientId
            // 
            this.labelPatientId.AutoSize = true;
            this.labelPatientId.Location = new System.Drawing.Point(58, 110);
            this.labelPatientId.Name = "labelPatientId";
            this.labelPatientId.Size = new System.Drawing.Size(80, 20);
            this.labelPatientId.TabIndex = 7;
            this.labelPatientId.Text = "Patient ID";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(58, 241);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 20);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "E-mail";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(58, 206);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 20);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Phone";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(58, 177);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 20);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(58, 142);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name";
            // 
            // labelTreatment
            // 
            this.labelTreatment.AutoSize = true;
            this.labelTreatment.Location = new System.Drawing.Point(58, 78);
            this.labelTreatment.Name = "labelTreatment";
            this.labelTreatment.Size = new System.Drawing.Size(82, 20);
            this.labelTreatment.TabIndex = 2;
            this.labelTreatment.Text = "Treatment";
            // 
            // dateTimePickerApp
            // 
            this.dateTimePickerApp.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dateTimePickerApp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerApp.Location = new System.Drawing.Point(233, 46);
            this.dateTimePickerApp.Name = "dateTimePickerApp";
            this.dateTimePickerApp.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerApp.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(58, 46);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(138, 20);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Appointment Time";
            // 
            // labelRequired
            // 
            this.labelRequired.AutoSize = true;
            this.labelRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequired.ForeColor = System.Drawing.Color.Red;
            this.labelRequired.Location = new System.Drawing.Point(190, 46);
            this.labelRequired.Name = "labelRequired";
            this.labelRequired.Size = new System.Drawing.Size(24, 29);
            this.labelRequired.TabIndex = 3;
            this.labelRequired.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(135, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(132, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(139, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(139, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(108, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "*";
            // 
            // dataGridViewCalendar
            // 
            this.dataGridViewCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendar.Location = new System.Drawing.Point(12, 446);
            this.dataGridViewCalendar.Name = "dataGridViewCalendar";
            this.dataGridViewCalendar.RowHeadersWidth = 62;
            this.dataGridViewCalendar.RowTemplate.Height = 28;
            this.dataGridViewCalendar.Size = new System.Drawing.Size(903, 220);
            this.dataGridViewCalendar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 678);
            this.Controls.Add(this.dataGridViewCalendar);
            this.Controls.Add(this.groupBoxAppInfo);
            this.Controls.Add(this.buttonStartNew);
            this.Controls.Add(this.buttonSee);
            this.Name = "Form1";
            this.Text = "Appointment Management System";
            this.groupBoxAppInfo.ResumeLayout(false);
            this.groupBoxAppInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSee;
        private System.Windows.Forms.Button buttonStartNew;
        private System.Windows.Forms.GroupBox groupBoxAppInfo;
        private System.Windows.Forms.DateTimePicker dateTimePickerApp;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelTreatment;
        private System.Windows.Forms.Label labelPatientId;
        private System.Windows.Forms.DomainUpDown domainUpDownTreatment;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPatientId;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelRequired;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewCalendar;
    }
}

