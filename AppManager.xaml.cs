using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для AppManager.xaml
    /// </summary>
    public partial class AppManager : Window
    {
        public object FileContent { get; private set; }

        public AppManager()
        {
            InitializeComponent();
            var uriMain = new Uri("pack://application:,,,/Resources/imagestudio.png");
            var bitmapMain = new BitmapImage(uriMain);
            MainGrid.Background = new ImageBrush(bitmapMain);
            Manager.QFrame = QFrame;
            Manager.NFrame = NFrame;
            Manager.MainGrid = MainGrid;
            Manager.NFrame.Navigate(new Pages.AudioDefitions());
        }

        private void OProgramm_Click(object sender, RoutedEventArgs e)
        {
            ProgrammInfo window1 = new ProgrammInfo();
            window1.Show();
        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {
            Manager.NFrame.Navigate(new Pages.AddOrder());
        }

        private void PeopleboxButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите зайти в свою учетную запись?", "Подтвердите", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                goto captcha;
            }
            else
            {
                return;
            }
            captcha:;
                CaptchaWindow window2 = new CaptchaWindow();
                window2.Show();
        }

        private void PeoplefileopenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string filename = openFileDialog.FileName;
                string content = System.IO.File.ReadAllText(filename);
                FileContent = content;
            }
        }

        private void PeoplefilesaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt) |*.txt|All files (*.*) |*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                string filename = saveFileDialog.FileName;
            }
        }

        private void PeoplefileexportButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите перейти на сайт приложения?", "Подтвердите", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Process.Start("https://audiomaster.su/");
            }
            else
            {
                return;
            }
        }

        private void PeoplefilesettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите перейти в настройки приложения?", "Подтвердите", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Manager.QFrame.Navigate(new Pages.Settings());
            }
            else
            {
                return;
            }
        }

        private void JanrsButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.QFrame.Navigate(new Pages.Elections());
        }

        private void EffectsButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.QFrame.Navigate(new Pages.Effects());
        }

        private void InstrumentsButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.QFrame.Navigate(new Pages.MusicInstruments());
        }

        private void BackWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window5 = new MainWindow();
            window5.Show();
            this.Close();
        }
    }
}
