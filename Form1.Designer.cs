
namespace FinalProject_Winter2021
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerBooking = new System.Windows.Forms.DateTimePicker();
            this.labelApoTime = new System.Windows.Forms.Label();
            this.domainUpDownService = new System.Windows.Forms.DomainUpDown();
            this.labelService = new System.Windows.Forms.Label();
            this.buttonReview = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.maskedTextBoxPatientId = new System.Windows.Forms.MaskedTextBox();
            this.labelPatientId = new System.Windows.Forms.Label();
            this.labelRequired = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select action";
            // 
            // dateTimePickerBooking
            // 
            this.dateTimePickerBooking.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dateTimePickerBooking.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBooking.Location = new System.Drawing.Point(222, 42);
            this.dateTimePickerBooking.Name = "dateTimePickerBooking";
            this.dateTimePickerBooking.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerBooking.TabIndex = 4;
            // 
            // labelApoTime
            // 
            this.labelApoTime.AutoSize = true;
            this.labelApoTime.Location = new System.Drawing.Point(20, 48);
            this.labelApoTime.Name = "labelApoTime";
            this.labelApoTime.Size = new System.Drawing.Size(160, 25);
            this.labelApoTime.TabIndex = 5;
            this.labelApoTime.Text = "Appointment Date";
            // 
            // domainUpDownService
            // 
            this.domainUpDownService.Location = new System.Drawing.Point(222, 77);
            this.domainUpDownService.Name = "domainUpDownService";
            this.domainUpDownService.Size = new System.Drawing.Size(200, 31);
            this.domainUpDownService.TabIndex = 7;
            this.domainUpDownService.Text = "General Dentistry";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(20, 80);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(67, 25);
            this.labelService.TabIndex = 8;
            this.labelService.Text = "Service";
            // 
            // buttonReview
            // 
            this.buttonReview.Location = new System.Drawing.Point(237, 44);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(112, 34);
            this.buttonReview.TabIndex = 9;
            this.buttonReview.Text = "REVIEW";
            this.buttonReview.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(437, 44);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(112, 34);
            this.buttonNew.TabIndex = 10;
            this.buttonNew.Text = "NEW";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(20, 118);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(97, 25);
            this.labelFirstName.TabIndex = 11;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(20, 155);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(95, 25);
            this.labelLastName.TabIndex = 12;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(222, 114);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 31);
            this.textBoxFirstName.TabIndex = 13;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(222, 151);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 31);
            this.textBoxLastName.TabIndex = 14;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(20, 192);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(62, 25);
            this.labelPhone.TabIndex = 16;
            this.labelPhone.Text = "Phone";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(222, 188);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(200, 31);
            this.maskedTextBoxPhone.TabIndex = 17;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 229);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(61, 25);
            this.labelEmail.TabIndex = 18;
            this.labelEmail.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(222, 225);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 31);
            this.textBoxEmail.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonBook);
            this.groupBox1.Controls.Add(this.maskedTextBoxPatientId);
            this.groupBox1.Controls.Add(this.labelPatientId);
            this.groupBox1.Controls.Add(this.domainUpDownService);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.dateTimePickerBooking);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelApoTime);
            this.groupBox1.Controls.Add(this.maskedTextBoxPhone);
            this.groupBox1.Controls.Add(this.labelService);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.labelFirstName);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.labelRequired);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(58, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 381);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Information";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonClear.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonClear.Location = new System.Drawing.Point(377, 326);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 34);
            this.buttonClear.TabIndex = 28;
            this.buttonClear.Text = "clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(174, 326);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(112, 34);
            this.buttonBook.TabIndex = 21;
            this.buttonBook.Text = "BOOK";
            this.buttonBook.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxPatientId
            // 
            this.maskedTextBoxPatientId.Location = new System.Drawing.Point(222, 262);
            this.maskedTextBoxPatientId.Mask = "00000";
            this.maskedTextBoxPatientId.Name = "maskedTextBoxPatientId";
            this.maskedTextBoxPatientId.Size = new System.Drawing.Size(200, 31);
            this.maskedTextBoxPatientId.TabIndex = 27;
            this.maskedTextBoxPatientId.ValidatingType = typeof(int);
            // 
            // labelPatientId
            // 
            this.labelPatientId.AutoSize = true;
            this.labelPatientId.Location = new System.Drawing.Point(20, 265);
            this.labelPatientId.Name = "labelPatientId";
            this.labelPatientId.Size = new System.Drawing.Size(88, 25);
            this.labelPatientId.TabIndex = 23;
            this.labelPatientId.Text = "Patient ID";
            // 
            // labelRequired
            // 
            this.labelRequired.AutoSize = true;
            this.labelRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRequired.ForeColor = System.Drawing.Color.Red;
            this.labelRequired.Location = new System.Drawing.Point(174, 44);
            this.labelRequired.Name = "labelRequired";
            this.labelRequired.Size = new System.Drawing.Size(24, 29);
            this.labelRequired.TabIndex = 21;
            this.labelRequired.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(81, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(110, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(108, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(76, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(102, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "*";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 705);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonReview);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Appointment Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBooking;
        private System.Windows.Forms.Label labelApoTime;
        private System.Windows.Forms.DomainUpDown domainUpDownService;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Button buttonReview;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRequired;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPatientId;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPatientId;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonClear;
    }
}

