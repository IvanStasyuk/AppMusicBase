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
            try
            {
                var UserVhod = MusicStudioBaseEntities.GetContext().Users.FirstOrDefault(x => x.Login == TBlogin.Text && x.Password == TBPassword.Text);
                if (UserVhod == null)
                {
                    MessageBox.Show("Такого пользователя нет!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (CaptchaInput.Text == "")
                {
                    MessageBox.Show("Введите капчу", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else if (CaptchaInput.Text == "ABCD")
                {
                    MessageBox.Show("Капча верна", "Авторизация успешна", MessageBoxButton.OK, MessageBoxImage.Information);

                    switch (UserVhod.idRole)
                    {
                        case 1:
                            MessageBox.Show("Здравствуй, Администратор " + UserVhod.NameUser + "!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                            AppManager window1 = new AppManager();
                            window1.Show();
                            this.Close();
                            break;
                        case 2:
                            MessageBox.Show("Здравствуй, Менеджер " + UserVhod.NameUser + "!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                            AppManager window2 = new AppManager();
                            window2.Show();
                            this.Close();
                            break;
                        case 3:
                            MessageBox.Show("Здравствуй, Клиент " + UserVhod.NameUser + "!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                            AppManager window3 = new AppManager();
                            window3.Show();
                            this.Close();
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены " + UserVhod.NameUser + "!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                            AppManager window4 = new AppManager();
                            window4.Show();
                            this.Close();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message.ToString() + "Критическая ошибка приложения", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MFrame.Navigate(new Pages.Registration());
            Manager.MFrame.Visibility = Visibility.Visible; 
        }

        private void GhostButton_Click(object sender, RoutedEventArgs e)
        {
            AppManager window1 = new AppManager();
            window1.Show();
            this.Close();
        }
    }
}
