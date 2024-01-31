using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Media;
using System.Xml;
using clinical_draft3;
using MySql.Data.MySqlClient;


namespace draft_clinical_2
{
    public partial class MainWindow : Window
    {
        
        private Page1 page1Instance;
        private int tabCounter = 2; // Starting from 2 because we already have Tab 1


        public MainWindow()
        {
            InitializeComponent();
            page1Instance = new Page1();


            // Attach the event handler to the ScrollBar's Scroll event
            scrollBar.Scroll += ScrollBar_Scroll;


            DatabaseOperations dbOperations = new DatabaseOperations();
            List<string> components = dbOperations.GetComponents();

            // Populate ComboBox1
            List<string> components1 = dbOperations.GetComponents();
            foreach (string component in components1)
            {
                PcomboBox.Items.Add(component);
            }

            // Populate ComboBox2
            List<string> components2 = dbOperations.GetComponents();
            foreach (string component in components2)
            {
                PcomboBox11.Items.Add(component);
            }

            // Populate ComboBox2
            List<string> components3 = dbOperations.GetComponents();
            foreach (string component in components3)
            {
                PcomboBox16.Items.Add(component);
            }

            // Populate ComboBox2
            List<string> components4 = dbOperations.GetComponents();
            foreach (string component in components4)
            {
                PcomboBox6.Items.Add(component);
            }

            // Populate ComboBox2
            List<string> components5 = dbOperations.GetComponents();
            foreach (string component in components5)
            {
                PcomboBox17.Items.Add(component);
            }

            List<string> components6 = dbOperations.GetCARBSComponents();
            foreach (string component in components6)
            {
                comboBox3.Items.Add(component);
            }
            List<string> components7 = dbOperations.GetCARBSComponents();
            foreach (string component in components7)
            {
                comboBox13.Items.Add(component);
            }
            List<string> components8 = dbOperations.GetCARBSComponents();
            foreach (string component in components8)
            {
                comboBox17.Items.Add(component);
            }
            List<string> components9 = dbOperations.GetCARBSComponents();
            foreach (string component in components9)
            {
                comboBox8.Items.Add(component);
            }
            List<string> components10 = dbOperations.GetCARBSComponents();
            foreach (string component in components10)
            {
                comboBox18.Items.Add(component);
            }



            List<string> components11 = dbOperations.GetFATSComponents();
            foreach (string component in components11)
            {
                comboBox4.Items.Add(component);
            }
            List<string> components12 = dbOperations.GetFATSComponents();
            foreach (string component in components12)
            {
                comboBox14.Items.Add(component);
            }
            List<string> components13 = dbOperations.GetFATSComponents();
            foreach (string component in components13)
            {
                comboBox20.Items.Add(component);
            }
            List<string> components14 = dbOperations.GetFATSComponents();
            foreach (string component in components14)
            {
                comboBox7.Items.Add(component);
            }
            List<string> components15 = dbOperations.GetFATSComponents();
            foreach (string component in components15)
            {
                comboBox21.Items.Add(component);
            }





            List<string> components16 = dbOperations.GetFIBERSComponents();
            foreach (string component in components16)
            {
                comboBox5.Items.Add(component);
            }
            List<string> components17 = dbOperations.GetFIBERSComponents();
            foreach (string component in components17)
            {
                comboBox15.Items.Add(component);
            }
            List<string> components18 = dbOperations.GetFIBERSComponents();
            foreach (string component in components18)
            {
                comboBox22.Items.Add(component);
            }
            List<string> components19 = dbOperations.GetFIBERSComponents();
            foreach (string component in components19)
            {
                comboBox9.Items.Add(component);
            }
            List<string> components20 = dbOperations.GetFIBERSComponents();
            foreach (string component in components20)
            {
                comboBox23.Items.Add(component);
            }




            List<string> components21 = dbOperations.GetRMComponents();
            foreach (string component in components21)
            {
                comboBox2.Items.Add(component);
            }
            List<string> components22 = dbOperations.GetRMComponents();
            foreach (string component in components22)
            {
                comboBox12.Items.Add(component);
            }
            List<string> components23 = dbOperations.GetRMComponents();
            foreach (string component in components23)
            {
                comboBox24.Items.Add(component);
            }
            List<string> components24 = dbOperations.GetRMComponents();
            foreach (string component in components24)
            {
                comboBox10.Items.Add(component);
            }
            List<string> components25 = dbOperations.GetRMComponents();
            foreach (string component in components25)
            {
                comboBox25.Items.Add(component);
            }

            // Add selection changed event handlers to ComboBoxes
            PcomboBox.SelectionChanged += PComboBox_SelectionChanged;
            PcomboBox11.SelectionChanged += PComboBox_SelectionChanged;
            PcomboBox16.SelectionChanged += PComboBox_SelectionChanged;
            PcomboBox6.SelectionChanged += PComboBox_SelectionChanged;
            PcomboBox17.SelectionChanged += PComboBox_SelectionChanged;


            comboBox3.SelectionChanged += CComboBox_SelectionChanged;
            comboBox13.SelectionChanged += CComboBox_SelectionChanged;
            comboBox17.SelectionChanged += CComboBox_SelectionChanged;
            comboBox8.SelectionChanged += CComboBox_SelectionChanged;
            comboBox18.SelectionChanged += CComboBox_SelectionChanged;


            comboBox4.SelectionChanged += FComboBox_SelectionChanged;
            comboBox14.SelectionChanged += FComboBox_SelectionChanged;
            comboBox20.SelectionChanged += FComboBox_SelectionChanged;
            comboBox7.SelectionChanged += FComboBox_SelectionChanged;
            comboBox21.SelectionChanged += FComboBox_SelectionChanged;


            comboBox5.SelectionChanged += F2ComboBox_SelectionChanged;
            comboBox15.SelectionChanged += F2ComboBox_SelectionChanged;
            comboBox22.SelectionChanged += F2ComboBox_SelectionChanged;
            comboBox9.SelectionChanged += F2ComboBox_SelectionChanged;
            comboBox23.SelectionChanged += F2ComboBox_SelectionChanged;


            comboBox2.SelectionChanged += RMComboBox_SelectionChanged;
            comboBox12.SelectionChanged += RMComboBox_SelectionChanged;
            comboBox24.SelectionChanged += RMComboBox_SelectionChanged;
            comboBox10.SelectionChanged += RMComboBox_SelectionChanged;
            comboBox25.SelectionChanged += RMComboBox_SelectionChanged;



        }

        // Assuming you have a class for your database operations
        public class DatabaseOperations
        {
            // Method to retrieve components from the database
            public List<string> GetComponents()
            {
                List<string> components = new List<string>();

                // Connect to your database and retrieve components from the Components table
                // Sample code to retrieve components (you need to replace this with your actual database access code)
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=clinicalproject3;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("SELECT protien_Name FROM Proteins", connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        components.Add(reader["protien_Name"].ToString());
                    }
                }

                return components;
            }

            // Method to retrieve components from the database
            public List<string> GetCARBSComponents()
            {
                List<string> components = new List<string>();

                // Connect to your database and retrieve components from the Components table
                // Sample code to retrieve components (you need to replace this with your actual database access code)
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=clinicalproject3;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("SELECT Carbohydrates_Name FROM Carbohydrates", connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        components.Add(reader["Carbohydrates_Name"].ToString());
                    }
                }

                return components;
            }

            // Method to retrieve components from the database
            public List<string> GetFATSComponents()
            {
                List<string> components = new List<string>();

                // Connect to your database and retrieve components from the Components table
                // Sample code to retrieve components (you need to replace this with your actual database access code)
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=clinicalproject3;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("SELECT fat_Name FROM Fats", connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        components.Add(reader["fat_Name"].ToString());
                    }
                }

                return components;
            }


            // Method to retrieve components from the database
            public List<string> GetFIBERSComponents()
            {
                List<string> components = new List<string>();

                // Connect to your database and retrieve components from the Components table
                // Sample code to retrieve components (you need to replace this with your actual database access code)
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=clinicalproject3;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("SELECT fiber_Name FROM Fibers", connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        components.Add(reader["fiber_Name"].ToString());
                    }
                }

                return components;
            }


            // Method to retrieve components from the database
            public List<string> GetRMComponents()
            {
                List<string> components = new List<string>();

                // Connect to your database and retrieve components from the Components table
                // Sample code to retrieve components (you need to replace this with your actual database access code)
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pharmacy_db;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("SELECT name FROM medication", connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        components.Add(reader["name"].ToString());
                    }
                }

                return components;
            }

            // Method to save the chosen component to the database
            public void SaveComponent(string componentName)
            {
                // Connect to your database and save the chosen component
                // Sample code to save the component (you need to replace this with your actual database access code)
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pharmacy_db;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("INSERT INTO prescription (name_try) VALUES (@ComponentName)", connection);
                    command.Parameters.AddWithValue("@ComponentName", componentName);
                    command.ExecuteNonQuery();
                }
            }


            // Method to save the chosen component to the database
            public void SaveCARBSComponent(string componentName)
            {
                // Connect to your database and save the chosen component
                // Sample code to save the component (you need to replace this with your actual database access code)
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pharmacy_db;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("INSERT INTO prescription (name_try) VALUES (@ComponentName)", connection);
                    command.Parameters.AddWithValue("@ComponentName", componentName);
                    command.ExecuteNonQuery();
                }
            }


            // Method to save the chosen component to the database
            public void SaveFATSComponent(string componentName)
            {
                // Connect to your database and save the chosen component
                // Sample code to save the component (you need to replace this with your actual database access code)
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pharmacy_db;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("INSERT INTO prescription (name_try) VALUES (@ComponentName)", connection);
                    command.Parameters.AddWithValue("@ComponentName", componentName);
                    command.ExecuteNonQuery();
                }
            }


            // Method to save the chosen component to the database
            public void SaveFIBERSComponent(string componentName)
            {
                // Connect to your database and save the chosen component
                // Sample code to save the component (you need to replace this with your actual database access code)
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pharmacy_db;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("INSERT INTO prescription (name_try) VALUES (@ComponentName)", connection);
                    command.Parameters.AddWithValue("@ComponentName", componentName);
                    command.ExecuteNonQuery();
                }
            }

            // Method to save the chosen component to the database
            public void SaveRMComponent(string componentName)
            {
                // Connect to your database and save the chosen component
                // Sample code to save the component (you need to replace this with your actual database access code)
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pharmacy_db;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("INSERT INTO prescription (name_try) VALUES (@ComponentName)", connection);
                    command.Parameters.AddWithValue("@ComponentName", componentName);
                    command.ExecuteNonQuery();
                }
            }
        }


        // Assuming you have a WPF window with a ComboBox named comboBox and another page where you want to add the chosen component

        // Event handler for ComboBox selection changed event
        private void PComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox; // Get the ComboBox that triggered the event
            string selectedComponent = comboBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedComponent))
            {
                // Add the chosen component to another page (Assuming you have a method to add components to another page)
                page1Instance.AddComponent(selectedComponent);

                // Save the chosen component to the database
                DatabaseOperations dbOperations = new DatabaseOperations();
                dbOperations.SaveComponent(selectedComponent);
            }
        }

        // Event handler for ComboBox selection changed event
        private void CComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox; // Get the ComboBox that triggered the event
            string selectedComponent = comboBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedComponent))
            {
                // Add the chosen component to another page (Assuming you have a method to add components to another page)
                page1Instance.AddComponent(selectedComponent);

                // Save the chosen component to the database
                DatabaseOperations dbOperations = new DatabaseOperations();
                dbOperations.SaveComponent(selectedComponent);
            }
        }


        // Event handler for ComboBox selection changed event
        private void FComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox; // Get the ComboBox that triggered the event
            string selectedComponent = comboBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedComponent))
            {
                // Add the chosen component to another page (Assuming you have a method to add components to another page)
                page1Instance.AddComponent(selectedComponent);

                // Save the chosen component to the database
                DatabaseOperations dbOperations = new DatabaseOperations();
                dbOperations.SaveComponent(selectedComponent);
            }
        }


        // Event handler for ComboBox selection changed event
        private void F2ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox; // Get the ComboBox that triggered the event
            string selectedComponent = comboBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedComponent))
            {
                // Add the chosen component to another page (Assuming you have a method to add components to another page)
                page1Instance.AddComponent(selectedComponent);

                // Save the chosen component to the database
                DatabaseOperations dbOperations = new DatabaseOperations();
                dbOperations.SaveComponent(selectedComponent);
            }
        }


        // Event handler for ComboBox selection changed event
        private void RMComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox; // Get the ComboBox that triggered the event
            string selectedComponent = comboBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedComponent))
            {
                // Add the chosen component to another page (Assuming you have a method to add components to another page)
                page1Instance.AddComponent(selectedComponent);

                // Save the chosen component to the database
                DatabaseOperations dbOperations = new DatabaseOperations();
                dbOperations.SaveComponent(selectedComponent);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a new TabItem
            TabItem newTabItem = new TabItem();
            newTabItem.Header = "Day " + tabCounter;

            // Clone the content of the first tab item and assign it to the new tab
            if (PlanTabControl.Items.Count > 0)
            {
                TabItem firstTab = (TabItem)PlanTabControl.Items[0];
                if (firstTab.Content is Grid originalGrid)
                {
                    Grid clonedGrid = CloneGridContent(originalGrid);

                    // Find the button in the cloned grid and wire up its Click event
                    Button addButton = FindButton(clonedGrid);
                    if (addButton != null)
                    {
                        addButton.Click += AddButton_Click;
                    }

                    newTabItem.Content = clonedGrid;
                }
            }

            // Add the new TabItem to the TabControl
            PlanTabControl.Items.Add(newTabItem);

            // Increase the tab counter for the next tab
            tabCounter++;
        }

        private Grid CloneGridContent(Grid originalGrid)
        {
            // Serialize the original grid to XAML
            string gridXaml = XamlWriter.Save(originalGrid);
            // Deserialize the XAML to create a new grid
            StringReader stringReader = new StringReader(gridXaml);
            XmlReader xmlReader = XmlReader.Create(stringReader);
            Grid newGrid = (Grid)XamlReader.Load(xmlReader);
            return newGrid;
        }

        private Button FindButton(DependencyObject parent)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);
                if (child is Button button)
                {
                    return button;
                }
                else
                {
                    Button result = FindButton(child);
                    if (result != null)
                    {
                        return result;
                    }
                }
            }
            return null;
        }

        private void ScrollBar_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            // Handle the scroll event here
            // You can access properties like e.NewValue to get the new value of the scrollbar
            double newValue = e.NewValue;
            // Do something with the new value
        }
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Retrieve the TextBox instance
            TextBox textBox = sender as TextBox;

            // Ensure that the TextBox instance is not null and text is not empty
            if (textBox != null && !string.IsNullOrEmpty(textBox.Text))
            {
                // Retrieve the text input from the TextBox
                string inputText = textBox.Text;

                // Process or validate the input if necessary

                // Save the input to the database
                SaveInputToDatabase(inputText);
            }
        }

        // Method to save the input to the database
        private void SaveInputToDatabase(string inputText)
        {
            // Define the SQL query to insert data into the database
            string query = "INSERT INTO nutrion_prescription (name_try) VALUES (@ComponentName)";

            try
            {
                // Open a new MySqlConnection for database operations
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=clinicalproject3;Uid=root;Pwd=sal_moh_859;"))
                {
                    // Open the database connection
                    connection.Open();

                    // Create a MySqlCommand object with the query and connection
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter for the input text
                        command.Parameters.AddWithValue("@ComponentName", inputText);

                        // Execute the SQL command to insert data
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            // Display a confirmation message
                            MessageBox.Show("Input saved to the database: " + inputText);
                        }
                        else
                        {
                            // Display a message if no rows were affected
                            MessageBox.Show("Failed to save input to the database.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL exceptions
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Page2 when the button is clicked
            Page1 page1 = new Page1();
            this.Content = page1;

        }
    }
}