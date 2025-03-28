using FruitShop.AppLogic.Data;
using FruitShop.AppLogic.Models;
using System.Windows;

namespace FruitShop.UI
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        public CreateWindow()
        {
            InitializeComponent();
        }

        private Fruit _createdFruit;

        public Fruit CreatedFruit
        {
            get { return _createdFruit; }
        }


        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _createdFruit = FruitData.CreateFruit(nameTextBox.Text, colorTextBox.Text, seasonComboBox.Text);
                this.DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
