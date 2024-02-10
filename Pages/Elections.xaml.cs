using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для Elections.xaml
    /// </summary>
    public partial class Elections : Page
    {
        public Elections()
        {
            InitializeComponent();
            ObservableCollection<string> Janrs = new ObservableCollection<string>
            {
                "Названия жанров", "--------------------------------------",
                "Поп (5000р)",
                "Рок (4500р)",
                "Металл (3200р)",
                "Кантри (1700р)",
                "Блюз (900р)",
                "Электронная (2600р)",
                "Классическая (1000р)",
                "Фанк (2100р)",
                "Хаус (3400р)",
                "Соул (1900р)",
            };
            MyListElections.ItemsSource = Janrs;
        }
    }
}
