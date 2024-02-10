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
    /// Логика взаимодействия для AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Page
    {
        public AddOrder()
        {
            InitializeComponent();
            List<string> items = new List<string> { "Гитара", "Фортепиано", "Скрипка", "Саксофон", "Флейта", "Барабаны", "Труба", "Клавишные", "Голос", "Бас-гитара" };
            TBInstrumentPage.ItemsSource = items;
            List<string> items2 = new List<string> { "Поп", "Рок", "Металл", "Кантри", "Блюз", "Электронная", "Классическая", "Фанк", "Хаус", "Соул" };
            TBJanrPage.ItemsSource = items2;
            List<string> items3 = new List<string> { "Дилей", "Реверберация", "Фленжер", "Эхо", "Хорус", "Компрессия", "Дисторшн", "Эквализация", "Фазовращение", "Вокодер" };
            TBEffectPage.ItemsSource = items3;
        }

        private void BTSaveOrder_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(TBNameOrderPage.Text))
                errors.AppendLine("Укажите название заказа");
            if (string.IsNullOrEmpty(TBNameSingerPage.Text))
                errors.AppendLine("Укажите имя исполнителя");
            if (string.IsNullOrEmpty(TBFamiliaSingerPage.Text))
                errors.AppendLine("Укажите фамилию исполнителя");
            if (string.IsNullOrEmpty(TBPatronymicSingerPage.Text))
                errors.AppendLine("Укажите отчество исполнителя");
            if (string.IsNullOrEmpty(TBInstrumentPage.Text))
                errors.AppendLine("Укажите инструмент исполнителя");
            if (string.IsNullOrEmpty(TBProfitPage.Text))
                errors.AppendLine("Укажите цену услуги");
            if (string.IsNullOrEmpty(TBCountCompositionsPage.Text))
                errors.AppendLine("Укажите количество композиций");
            if (string.IsNullOrEmpty(TBStartOrderPage.Text))
                errors.AppendLine("Укажите начало записи");
            if (string.IsNullOrEmpty(TBEndOrderPage.Text))
                errors.AppendLine("Укажите конец записи");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (MusicStudioBaseEntities.GetContext().Orders.Count(y => y.NameOrder == TBNameOrderPage.Text) > 0)
            {
                MessageBox.Show("Заказ уже существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Orders UserOrder = new Orders()
                {
                    NameOrder = TBNameOrderPage.Text,
                    NameSinger = TBNameSingerPage.Text,
                    FamiliaSinger = TBFamiliaSingerPage.Text,
                    PatronymicSinger = TBPatronymicSingerPage.Text,
                    Instrument = TBInstrumentPage.Text,
                    Profit = int.Parse(TBProfitPage.Text),
                    CountCompositions = int.Parse(TBCountCompositionsPage.Text),
                    DateStart = DateTime.Parse(TBStartOrderPage.Text),
                    DateEnd = DateTime.Parse(TBEndOrderPage.Text)
                };
                MusicStudioBaseEntities.GetContext().Orders.Add(UserOrder);
                MusicStudioBaseEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void BTBackOrder_Click(object sender, RoutedEventArgs e)
        {
            Manager.NFrame.Navigate(new Pages.AudioDefitions());
        }

        private void ListOrdersBT_Click(object sender, RoutedEventArgs e)
        {
            Manager.NFrame.Navigate(new Pages.ListOrders());
        }
    }
}
