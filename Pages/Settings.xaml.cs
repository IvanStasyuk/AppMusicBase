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
                    var uri = new Uri("pack://application:,,,/Resources/redWallpaper.png");
                    var bitmap = new BitmapImage(uri);
                    Manager.MainGrid.Background = new ImageBrush(bitmap);
                    break;
                case "Синий":
                    var uri2 = new Uri("pack://application:,,,/Resources/blueWallpaper.png");
                    var bitmapTwo = new BitmapImage(uri2);
                    Manager.MainGrid.Background = new ImageBrush(bitmapTwo);
                    break;
                case "Зелёный":
                    var uri3 = new Uri("pack://application:,,,/Resources/greenWallpaper.png");
                    var bitmapThree = new BitmapImage(uri3);
                    Manager.MainGrid.Background = new ImageBrush(bitmapThree);
                    break;
                case "Жёлтый":
                    var uri4 = new Uri("pack://application:,,,/Resources/yellowWallpaper.png");
                    var bitmapFour = new BitmapImage(uri4);
                    Manager.MainGrid.Background = new ImageBrush(bitmapFour);
                    break;
                case "Коричневый":
                    var uri5 = new Uri("pack://application:,,,/Resources/grownWallpaper.png");
                    var bitmapFive = new BitmapImage(uri5);
                    Manager.MainGrid.Background = new ImageBrush(bitmapFive);
                    break;
                case "По умолчанию":
                    var uriMain = new Uri("pack://application:,,,/Resources/imagestudio.png");
                    var bitmapMain = new BitmapImage(uriMain);
                    Manager.MainGrid.Background = new ImageBrush(bitmapMain);
                    break;
            }
        }
    }
}
