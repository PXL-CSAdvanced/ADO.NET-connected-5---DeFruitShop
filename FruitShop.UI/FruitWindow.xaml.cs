using FruitShop.AppLogic.Data;
using FruitShop.AppLogic.Models;
using System.Windows;

namespace FruitShop.UI
{
    /// <summary>
    /// Interaction logic for FruitWindow.xaml
    /// </summary>
    public partial class FruitWindow : Window
    {
        public FruitWindow()
        {
            InitializeComponent();

            FruitData.ConnectionString = Settings.Default.ConnectionString;
            FruitData.GetAllFruit();
            fruitDataGrid.ItemsSource = FruitData.Fruits;
        }

        private void createFruitButton_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow window= new CreateWindow();
            if(window.ShowDialog() == true)
            {
                fruitDataGrid.Items.Refresh();
                fruitDataGrid.SelectedItem = window.CreatedFruit;
            }
        }

        private void deleteFruitButton_Click(object sender, RoutedEventArgs e)
        {
            Fruit selectedFruit = fruitDataGrid.SelectedItem as Fruit;

            if (selectedFruit is not null)
            {
                if(FruitData.DeleteFruit(selectedFruit.Id))
                {
                    fruitDataGrid.Items.Refresh();
                }
            }
        }
    }
}
