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
    /// Логика взаимодействия для MusicInstruments.xaml
    /// </summary>
    public partial class MusicInstruments : Page
    {
        public MusicInstruments()
        {
            InitializeComponent();
            ObservableCollection<string> Instruments = new ObservableCollection<string>
            {
                "Названия инструментов", "--------------------------------------",
                "Гитара (1700р)",
                "Фортепиано (2000р)",
                "Скрипка (3400р)",
                "Саксофон (700р)",
                "Флейта (1500р)",
                "Барабаны (2100р)",
                "Труба (3100р)",
                "Клавишные (3000р)",
                "Голос (4000р)",
                "Бас-гитара (2500р)",
            };
            MyListIntruments.ItemsSource = Instruments;
        }
    }
}
