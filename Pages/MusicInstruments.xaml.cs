﻿using System;
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
            ObservableCollection<string> data = new ObservableCollection<string>
            {
                "Названия инструментов", "",
                "Гитара",
                "Фортепиано",
                "Скрипка",
                "Саксофон",
                "Флейта",
                "Барабаны",
                "Труба",
                "Клавишные",
                "Голос",
                "Бас-гитара",
            };
            MyListIntruments.ItemsSource = data;
        }
    }
}
