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

namespace AppMusicBase.Pages
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void SelectBackground_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItems = (ComboBoxItem)SelectBackground.SelectedItem;
            string selectedColor = selectedItems.Content.ToString();
            switch (selectedColor)
            {
                case "Красный":
                    this.Background = Brushes.Red;
                    break;
            }
        }
    }
}
