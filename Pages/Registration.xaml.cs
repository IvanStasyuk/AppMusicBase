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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void RegButtonPage_Click(object sender, RoutedEventArgs e)
        {
            if (MusicStudioBaseEntities.GetContext().Users.Count(y => y.Login == TBLoginPage.Text) > 0)
            {
                MessageBox.Show("Пользователь уже существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Users UserReg = new Users()
                {
                    Login = TBLoginPage.Text,
                    Password = TBPasswordPage.Text,
                    NameUser = TBNamePage.Text,
                    FamiliaUser = TBFamiliaPage.Text,
                    PatronymicUser = TBPatronymicPage.Text,
                    idRole = int.Parse(TBRolePage.Text)
                };
                MusicStudioBaseEntities.GetContext().Users.Add(UserReg);
                MusicStudioBaseEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                Manager.MFrame.Visibility = Visibility.Hidden;
                Manager.MFrame.Visibility = Visibility.Visible;
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void RegButtonBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MFrame.Visibility = Visibility.Hidden;
        }
    }
}
