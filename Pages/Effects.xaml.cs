using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
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
using static AppMusicBase.Manager;

namespace AppMusicBase.Pages
{
    /// <summary>
    /// Логика взаимодействия для Effects.xaml
    /// </summary>
    public partial class Effects : Page
    {
        public Effects()
        {
            InitializeComponent();
            ObservableCollection<string> Effects = new ObservableCollection<string>
            {
                "Названия эффектов", "--------------------------------------",
                "Дилей (2500р)",
                "Реверберация (3000р)",
                "Фленжер (1700р)",
                "Эхо (2300р)",
                "Хорус (4100р)",
                "Компрессия (1800р)",
                "Дисторшн (800р)",
                "Эквализация (2900р)",
                "Фазовращение (3500р)",
                "Вокодер (1500р)",
            };
            MyListEffects.ItemsSource = Effects;
        }
    }
}
