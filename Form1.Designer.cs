
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
            this.buttonCreate = new System.Windows.Forms.Button();
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
            this.dateTimePickerBooking.Location = new System.Drawing.Point(178, 84);
            this.dateTimePickerBooking.Name = "dateTimePickerBooking";
            this.dateTimePickerBooking.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerBooking.TabIndex = 4;
            // 
            // labelApoTime
            // 
            this.labelApoTime.AutoSize = true;
            this.labelApoTime.Location = new System.Drawing.Point(12, 84);
            this.labelApoTime.Name = "labelApoTime";
            this.labelApoTime.Size = new System.Drawing.Size(160, 25);
            this.labelApoTime.TabIndex = 5;
            this.labelApoTime.Text = "Appointment Date";
            // 
            // domainUpDownService
            // 
            this.domainUpDownService.Location = new System.Drawing.Point(178, 130);
            this.domainUpDownService.Name = "domainUpDownService";
            this.domainUpDownService.Size = new System.Drawing.Size(200, 31);
            this.domainUpDownService.TabIndex = 7;
            this.domainUpDownService.Text = "General Dentistry";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(12, 132);
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
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(437, 44);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(112, 34);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "BOOK";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 705);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonReview);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.domainUpDownService);
            this.Controls.Add(this.labelApoTime);
            this.Controls.Add(this.dateTimePickerBooking);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Appointment Management System";
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
        private System.Windows.Forms.Button buttonCreate;
    }
}

