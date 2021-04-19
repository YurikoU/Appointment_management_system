
namespace Demo
{
    partial class Form2
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
            this.dataGridViewCalendar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCalendar
            // 
            this.dataGridViewCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCalendar.Name = "dataGridViewCalendar";
            this.dataGridViewCalendar.RowHeadersWidth = 62;
            this.dataGridViewCalendar.RowTemplate.Height = 28;
            this.dataGridViewCalendar.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewCalendar.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCalendar);
            this.Name = "Form2";
            this.Text = "Existing Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCalendar;
    }
}