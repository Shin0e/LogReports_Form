
namespace RaportLogi
{
    partial class SelectDatesForm
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
            this.Start_Calendar = new System.Windows.Forms.MonthCalendar();
            this.StartDate_textBox = new System.Windows.Forms.TextBox();
            this.EndDate_textBox = new System.Windows.Forms.TextBox();
            this.SelectRangeButton = new System.Windows.Forms.Button();
            this.EndCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_Calendar
            // 
            this.Start_Calendar.Location = new System.Drawing.Point(18, 18);
            this.Start_Calendar.MaxSelectionCount = 1;
            this.Start_Calendar.Name = "Start_Calendar";
            this.Start_Calendar.TabIndex = 0;
            this.Start_Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Start_Calendar_DateChanged);
            // 
            // StartDate_textBox
            // 
            this.StartDate_textBox.Location = new System.Drawing.Point(187, 192);
            this.StartDate_textBox.Name = "StartDate_textBox";
            this.StartDate_textBox.Size = new System.Drawing.Size(100, 23);
            this.StartDate_textBox.TabIndex = 1;
            // 
            // EndDate_textBox
            // 
            this.EndDate_textBox.Location = new System.Drawing.Point(474, 192);
            this.EndDate_textBox.Name = "EndDate_textBox";
            this.EndDate_textBox.Size = new System.Drawing.Size(100, 23);
            this.EndDate_textBox.TabIndex = 2;
            // 
            // SelectRangeButton
            // 
            this.SelectRangeButton.Location = new System.Drawing.Point(474, 235);
            this.SelectRangeButton.Name = "SelectRangeButton";
            this.SelectRangeButton.Size = new System.Drawing.Size(100, 23);
            this.SelectRangeButton.TabIndex = 3;
            this.SelectRangeButton.Text = "Select Range";
            this.SelectRangeButton.UseVisualStyleBackColor = true;
            this.SelectRangeButton.Click += new System.EventHandler(this.SelectRangeButton_Click);
            // 
            // EndCalendar
            // 
            this.EndCalendar.Location = new System.Drawing.Point(305, 18);
            this.EndCalendar.MaxSelectionCount = 1;
            this.EndCalendar.Name = "EndCalendar";
            this.EndCalendar.TabIndex = 4;
            this.EndCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.EndCalendar_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Start date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select end date:";
            // 
            // SelectDatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 274);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndCalendar);
            this.Controls.Add(this.SelectRangeButton);
            this.Controls.Add(this.EndDate_textBox);
            this.Controls.Add(this.StartDate_textBox);
            this.Controls.Add(this.Start_Calendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectDatesForm";
            this.ShowIcon = false;
            this.Text = "Select date range";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Start_Calendar;
        private System.Windows.Forms.TextBox StartDate_textBox;
        private System.Windows.Forms.TextBox EndDate_textBox;
        private System.Windows.Forms.Button SelectRangeButton;
        private System.Windows.Forms.MonthCalendar EndCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}