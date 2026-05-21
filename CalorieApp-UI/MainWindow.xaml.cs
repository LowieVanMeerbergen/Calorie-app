using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalorieApp_Business;

namespace CalorieApp_UI
{
    
    public partial class MainWindow : Window
    {
        private Controller _controller;

        public MainWindow()
        {
            InitializeComponent();
            _controller = new Controller();

            //Fill the combobox with names from controller
            CmbProductChoice.ItemsSource = _controller.GetProductNames();
            CmbProductChoice.SelectedIndex = 0;

        }

        private void AddToList(object sender, RoutedEventArgs e)
        {
            //Check if there is a product selected

            if (CmbProductChoice.SelectedItem == null)
            {

                MessageBox.Show("Kies eerst een product.");
                return;
            }
            //Check if the number is good
            if (!int.TryParse(TxtWeight.Text, out int weight) || weight <= 0)
            {

                MessageBox.Show("Geef een geldig gewicht in (groter dan 0 & kleiner dan 2 000 000 001 ). ");
                return;


            }

            //Get product name
            string productName = CmbProductChoice.SelectedItem.ToString();

            //Add via controller
            _controller.AddProduct(productName, weight);

            //Refresh listbox
            LstProducts.ItemsSource = null;
            LstProducts.ItemsSource = _controller.GetEatenProducts();

            //Update total
            LblTotalCalories.Content = _controller.GetTotalCalories() + " kCal";
            //Empty weigt field
            TxtWeight.Text = "";
        }
    }
}