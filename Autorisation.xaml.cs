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

namespace AppMusicBase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MFrame = MFrame;
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MFrame.Navigate(new Pages.Registration());
        }

        private void GhostButton_Click(object sender, RoutedEventArgs e)
        {
            AppManager window1 = new AppManager();
            window1.Show();
            this.Close();
        }
    }
}
