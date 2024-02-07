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
            List<string> items = new List<string> { "Красный", "Синий", "Зелёный", "Жёлтый", "Коричневый", "По умолчанию" };
            SelectBackground.ItemsSource = items;
        }

        private void SelectBackground_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (SelectBackground.SelectedValue.ToString())
            {
                case "Красный":
                    Manager.MainGrid.Background = Brushes.Red;
                    break;
                case "Синий":
                    Manager.MainGrid.Background = Brushes.Blue;
                    break;
                case "Зелёный":
                    Manager.MainGrid.Background = Brushes.Green;
                    break;
                case "Жёлтый":
                    Manager.MainGrid.Background = Brushes.Yellow;
                    break;
                case "Коричневый":
                    Manager.MainGrid.Background = Brushes.Brown;
                    break;
                case "По умолчанию":
                    Manager.MainGrid.Background = Brushes.LightGray;
                    break;
            }
        }
    }
}
