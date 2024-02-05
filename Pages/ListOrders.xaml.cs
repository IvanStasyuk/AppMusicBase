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
    /// Логика взаимодействия для ListOrders.xaml
    /// </summary>
    public partial class ListOrders : Page
    {
        public ListOrders()
        {
            InitializeComponent();
            DataGridOrders.ItemsSource = MusicStudioBaseEntities.GetContext().Orders.ToList();
        }

        private void BTListBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.NFrame.Navigate(new Pages.AddOrder());
        }

        private void BTListDelete_Click(object sender, RoutedEventArgs e)
        {
            var OrderRemoving = DataGridOrders.SelectedItems.Cast<Orders>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить {OrderRemoving.Count()} элементов",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    MusicStudioBaseEntities.GetContext().Orders.RemoveRange(OrderRemoving);
                    MusicStudioBaseEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DataGridOrders.ItemsSource = MusicStudioBaseEntities.GetContext().Orders.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
