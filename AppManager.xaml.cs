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
            Manager.QFrame = QFrame;
        }

        private void OProgramm_Click(object sender, RoutedEventArgs e)
        {
            ProgrammInfo window1 = new ProgrammInfo();
            window1.Show();
        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PeopleboxButton_Click(object sender, RoutedEventArgs e)
        {

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
        }

        private void PeoplefilesettingsButton_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
