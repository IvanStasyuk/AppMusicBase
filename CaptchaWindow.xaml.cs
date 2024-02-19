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
using System.Windows.Shapes;

namespace AppMusicBase
{
    /// <summary>
    /// Логика взаимодействия для CaptchaWindow.xaml
    /// </summary>
    public partial class CaptchaWindow : Window
    {
        public CaptchaWindow()
        {
            InitializeComponent();
        }

        private void captchaInEnter_Click(object sender, RoutedEventArgs e)
        {
            if (captchaIn.Text != "ABCD")
            {
                MessageBox.Show("Неправильная капча!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                MessageBox.Show("Капча верна!", "Капча", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
                Manager.NFrame.Navigate(new Pages.PeopleBox());
            }
        }
    }
}
