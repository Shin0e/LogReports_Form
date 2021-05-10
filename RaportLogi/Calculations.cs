using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace RaportLogi
{
    class Calculations
    {
        private string dataCsv = "Date;";
        public string DataCsv { get { return dataCsv; } set { dataCsv = value; } }

        public string DataTxt { get; set; }
        public int howManyLines(string path, string version, int numberOfLines = 0)
        {
            foreach (string line in File.ReadLines(path))
            {
                if (line.Contains(version))
                {
                    numberOfLines++;
                    //Console.WriteLine(line);
                }
            }
            return numberOfLines;
        }

        public void AddData(string add)
        {
            DataCsv = DataCsv + add;
        }

        public int[] IntArrayClear(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            return arr;
        }

    public int[,] DailySum(string[] versions, string[] paths)
        {
            int[,] sumTotal = new int[versions.Length, paths.Length];
            for (int i = 0; i < versions.Length; i++)
            {
                for (int j = 0; j < paths.Length; j++)
                {
                    sumTotal[i, j] = sumTotal[i, j] + this.howManyLines(paths[j], versions[i]);
                }
            }
            return sumTotal;
        }
        public int[] MonthlySum (int[,] dailyTotal, int [] monthlySum, int versionsLength, int pathsLength)
        {
            for (int i = 0; i< versionsLength;i++)
            {
                for (int j = 0; j < pathsLength; j++)
                {
                    monthlySum[i] = monthlySum[i] + dailyTotal[i, j];
                }
            }
            return monthlySum;
        }


        public void SaveData(string path, string data)
        {
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(path);
            file.WriteLine(data);
            file.Close();
        }
        public void CreateReport(string[] years, string[] months, string pathToLogs)
        {

           
            string[] versions = { "free", "basic", "pro", "edge" }; //2 Free, 2 Basic, 2 Pro, 2 Edge, PioCalc, 1 Edge (1 not uncluded)
            string[] monthlySum = new string[versions.Length];
            string[] yearlySum = new string[versions.Length];
            int[] monthlySumInt = new int[versions.Length];

            for (int i = 0; i < versions.Length; i++)
            {
                AddData($"{versions[i]};");
            }
            AddData("\n");
            foreach (string year in years)
            {
                foreach (string month in months)
                {
                    string filter = "*.log." + year + month + "*";

                    string[] paths = Directory.GetFiles(pathToLogs, filter);

                    if (paths.Length == 0)
                    {
                        DataTxt += $"no files of year {year} month {month}\n";
                    }
                    string[] dates = new string[paths.Length];


                    Array.Copy(paths, dates, paths.Length);
                    for (int i = 0; i < dates.Length; i++)
                    {
                        dates[i] = dates[i].Substring(dates[i].LastIndexOf(".") + 1);
                    }
                    int[,] sumTotal = DailySum(versions, paths);
                    monthlySumInt = MonthlySum(sumTotal, monthlySumInt, versions.Length, paths.Length);
                    for (int i = 0; i < monthlySumInt.Length; i++)
                    {
                        monthlySum[i] = monthlySumInt[i].ToString();
                    }
                    for (int j = 0; j < dates.Length; j++)
                    {
                        AddData($"{dates[j]};");
                        for (int i = 0; i < versions.Length; i++)
                        {
                            AddData($"{sumTotal[i, j]};");
                        }
                        AddData("\n");
                    }
                    AddData($"{month};");
                    for (int j = 0; j < monthlySum.Length; j++)
                    {
                        AddData($"{monthlySum[j]};");
                    }

                    AddData("\n\n");
                    IntArrayClear(monthlySumInt);                    
                }
            }
        }
    }
}
