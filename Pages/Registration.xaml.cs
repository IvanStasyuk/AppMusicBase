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
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(TBNamePage.Text))
                errors.AppendLine("Укажите имя пользователя");
            if (string.IsNullOrEmpty(TBFamiliaPage.Text))
                errors.AppendLine("Укажите фамилию пользователя");
            if (string.IsNullOrEmpty(TBPatronymicPage.Text))
                errors.AppendLine("Укажите отчество пользователя");
            if (string.IsNullOrEmpty(TBLoginPage.Text))
                errors.AppendLine("Укажите логин пользователя");
            if (string.IsNullOrEmpty(TBPasswordPage.Text))
                errors.AppendLine("Укажите пароль пользователя");
            if (string.IsNullOrEmpty(TBRolePage.Text))
                errors.AppendLine("Укажите роль для пользователя");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

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
