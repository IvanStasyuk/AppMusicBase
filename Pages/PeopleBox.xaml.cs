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
    /// Логика взаимодействия для PeopleBox.xaml
    /// </summary>
    public partial class PeopleBox : Page
    {
        public PeopleBox()
        {
            InitializeComponent();
            var DataUser = MusicStudioBaseEntities.GetContext().Users.FirstOrDefault(x => x.NameUser == TBKnowName.Text && x.FamiliaUser == TBKnowFamilia.Text && x.PatronymicUser == TBKnowPatronymic.Text && x.Login == TBKnowLogin.Text && x.Password == TBKnowPassword.Text);
            
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.NFrame.GoBack();
        }
    }
}
