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
using System.Windows.Shapes;

namespace FruitShop.UI
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public DetailWindow()
        {
            InitializeComponent();
        }

        //TODO: Create property FruitToDisplay of type Fruit

        private void ShowFruitProperties()
        {
            //idTextBox.Text = FruitToDisplay.Id;
            //nameTextBox.Text = FruitToDisplay.Name;
            //...
        }
    }
}
