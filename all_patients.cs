using MySql.Data.MySqlClient;
using System;
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

namespace draft_clinical_2
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();

            // Call a method to populate the DataGrid with data from the database
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            try
            {
                // Create a connection string to your database
                string connectionString = "Data Source=YourDataSource;Initial Catalog=YourDatabaseName;Integrated Security=True";

                // Create a SQL connection using the connection string
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=clinicalproject3;Uid=root;Pwd=;"))
                {
                    // Open the database connection
                    connection.Open();

                    // Create a SQL command to retrieve data from the database
                    string query = "SELECT * FROM patients"; // Replace YourTableName with the actual table name
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Create a SqlDataAdapter to fetch the data into a DataTable
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        // Create a DataTable to store the retrieved data
                        System.Data.DataTable dataTable = new System.Data.DataTable();

                        // Fill the DataTable with data from the database
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGrid as its ItemsSourc
                        dataGrid.ItemsSource = dataTable.DefaultView;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any SQL exceptions
                MessageBox.Show("An error occurred while retrieving data from the database: " + ex.Message);
            }
        }
    }
}
