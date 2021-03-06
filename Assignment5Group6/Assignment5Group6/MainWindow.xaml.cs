﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment5Group6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int INCREMENT_FACTOR = 2;
        const string ERROR_MESSAGE = "Please enter valid inputs.";
        const string DIRNAME = "Project Result";
        const string FILENAME = "result.txt";
        public MainWindow()
        {
            InitializeComponent();
        }
        public void CalcSalary()
        {
            int numberOfDays;
            double totalSalary;
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullPath = System.IO.Path.Combine(path, DIRNAME);
            Directory.CreateDirectory(fullPath);
            string filePath = System.IO.Path.Combine(fullPath, FILENAME);
            StreamWriter sw = File.AppendText(filePath);
            if (int.TryParse(txtNumberOfDay.Text, out numberOfDays))
            {
                for (int i = 0; i < numberOfDays; i++)
                {
                    totalSalary = Math.Pow(2, i);
                    string finalResult = (i+1) + " " + totalSalary;
                    lstSalary.Items.Add(finalResult);
                    sw.WriteLine(finalResult);
                }
                sw.Close();
            }
            else
                MessageBox.Show(ERROR_MESSAGE);
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            CalcSalary();
            //saveToFile();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            lstSalary.Items.Clear();
            txtNumberOfDay.Text = "";
        }
    }
}
