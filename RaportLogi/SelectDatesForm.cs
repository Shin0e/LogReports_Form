using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RaportLogi
{
    public partial class SelectDatesForm : Form
    {
        public DateTime StartDate { set; get;}
        public DateTime EndDate { set; get; }
        public SelectDatesForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartDate_textBox.Text = Start_Calendar.SelectionRange.Start.ToShortDateString();
            EndDate_textBox.Text = EndCalendar.SelectionRange.Start.ToShortDateString();
        }

        private void Start_Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
                StartDate_textBox.Text = Start_Calendar.SelectionRange.Start.ToShortDateString();

        }

        private void EndCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
          
                EndDate_textBox.Text = EndCalendar.SelectionRange.Start.ToShortDateString();
        }

        private void SelectRangeButton_Click(object sender, EventArgs e)
        {
            if (EndCalendar.SelectionRange.Start < Start_Calendar.SelectionRange.Start)
            {
                MessageBox.Show("Error, End Date is smaller then Start date");
            }
            else
            {
                StartDate = Start_Calendar.SelectionRange.Start;
                EndDate = EndCalendar.SelectionRange.Start;
                Close();
            }
        }
    }
}
