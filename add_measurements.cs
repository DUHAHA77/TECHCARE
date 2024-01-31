using System.Windows;
using System.Data.SqlClient;
using tesst;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using tesst;
using Microsoft.Win32;

namespace tesst
{
    public partial class All_Patients : Window
    {
        public All_Patients()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }

        public class ViewModel
        {
            public List<string> Options1 { get; set; }
            public List<string> Options2 { get; set; }
            public List<string> Options3 { get; set; }
            public List<string> Options4 { get; set; }
            public List<string> Options5 { get; set; }



            public ViewModel()
            {
                // Initialize the list of options
                Options1 = new List<string>() { "Thyroid Function Tests", "Vitamin B12 Levels", "Vitamin D Levels" };
                // Initialize the list of options
                Options2 = new List<string>() { "Omega-3 Fatty Acids", "Vitamin B12", "Vitamin E" };
                // Initialize the list of options
                Options3 = new List<string>() { "Lose weight", "Gain weight", "Improving Digestive Health" };
                // Initialize the list of options
                Options5 = new List<string>() { "low", "moderate", "high" };
                // Initialize the list of options
                Options4 = new List<string>() { "wheat", "milk", "fish", "eggs" };
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Print a confirmation message
            MessageBox.Show("The data has been saved.", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter for file extension and default file extension
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif|All files (*.*)|*.*";

            // Display OpenFileDialog by calling ShowDialog method
            bool? result = openFileDialog.ShowDialog();

            // Check if the user selected a file
            if (result == true)
            {
                // Get the selected file name and display it
                string selectedFileName = openFileDialog.FileName;

                // Now you can use the selected file path (selectedFileName) to handle the uploaded photo
                // For example, you can display the photo in an Image control:
                // YourImageControl.Source = new BitmapImage(new Uri(selectedFileName));
            }
        }
    }
}