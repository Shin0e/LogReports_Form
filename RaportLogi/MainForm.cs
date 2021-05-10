using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaportLogi
{
    public partial class MainForm : Form
    {
        public string logDirectory;
        public string saveLogDirectory;
        public int startYear;
        public int endYear;
        public int startMonth;
        public int endMonth;

        public MainForm()
        {
            InitializeComponent();
        }
        private void SetDateButton_Click(object sender, EventArgs e)
        {
            SelectDatesForm selectingDatesForm = new SelectDatesForm();
            selectingDatesForm.ShowDialog();
            //textBox1.Text = selectingDatesForm.StartDate.Year.ToString() + "." + DateAddZero(selectingDatesForm.StartDate.Month.ToString()) + "." + DateAddZero(selectingDatesForm.StartDate.Day.ToString()) + "–" + selectingDatesForm.EndDate.Year.ToString() + "." + DateAddZero(selectingDatesForm.EndDate.Month.ToString()) + "." + DateAddZero(selectingDatesForm.EndDate.Day.ToString());
            startYear = selectingDatesForm.StartDate.Year;
            endYear = selectingDatesForm.EndDate.Year;
            textBox1.Text = endYear.ToString();

        }

        private void LogsFolderOpen_Click(object sender, EventArgs e)
        {
            folderBrowserLogs.SelectedPath = Path.GetDirectoryName(Application.ExecutablePath);
            var result = folderBrowserLogs.ShowDialog();

            if (result == DialogResult.OK)
            {
                logDirectory = folderBrowserLogs.SelectedPath;
                textBox2.Text = logDirectory;
            }
        }

        private void SaveFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserSave.SelectedPath = Path.GetDirectoryName(Application.ExecutablePath);
            var result = folderBrowserSave.ShowDialog();

            if (result == DialogResult.OK)
            {
                saveLogDirectory = folderBrowserSave.SelectedPath;
                textBox3.Text = saveLogDirectory;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculations calculate = new Calculations();

            string[] yearsString = CalculateYearsString(startYear, endYear);
            string[] months = { "01", "02", "03 ", "04", "05", "06", "07", "08", "09", "10", "11", "12" }; //CalculateMonthsString

            calculate.CreateReport(yearsString, months, logDirectory);
                calculate.SaveData(saveLogDirectory+@"\data.csv", calculate.DataCsv);
                calculate.SaveData(saveLogDirectory+@"\data.txt", calculate.DataTxt);
                MessageBox.Show($"Success!\nSaved reports to directory {saveLogDirectory}");
        }
        public string DateAddZero(string a)
        {
            if (a.Length == 1)
            {
                return "0" + a;
            }
            return a;
        }
        public string[] CalculateYearsString(int startingYear, int endYear)
        {
            
            string[] yearsString = new string[endYear- startingYear+1];
            for (int i = 0; i<yearsString.Length; i++)
            {
                yearsString[i] = startingYear.ToString();
                startingYear++;
            }
            return yearsString;
        }
    }
}
