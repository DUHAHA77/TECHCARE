using draft_clinical_2;
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

namespace clinical_draft3
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        public void AddComponent(string component)
        {
            // Your implementation to add components goes here
            // This method should contain the logic to add components to the page
        }

private void Button_Click(object sender, RoutedEventArgs e)
{
    // Create an instance of Page3
    Page3 page3 = new Page3();

            // Convert Page3 to UserControl (assuming Page3 inherits UserControl)
            Page page3UserControl = new Page();
            this.Content = page3;
}





    }
}
