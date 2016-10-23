﻿using System;
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
        public MainWindow()
        {
            InitializeComponent();
        }
        public void CalcSalary()
        {
            int numberOfDays;
            int totalSalary = 1;
            if (int.TryParse(txtNumberOfDay.Text, out numberOfDays))
            {
                for (int i = 1; i <= numberOfDays; i++)
                {
                    totalSalary = i * INCREMENT_FACTOR;
                    string finalResult = i + " " + totalSalary;
                    lstSalary.Items.Add(finalResult);
                }
            }
            else
                MessageBox.Show(ERROR_MESSAGE);
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            CalcSalary();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            lstSalary.Items.Clear();
            txtNumberOfDay.Text = "";
        }
    }
}
