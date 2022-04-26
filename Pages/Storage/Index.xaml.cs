using System.Windows;
using System.Windows.Controls;
using EquiLog.Controllers;
using EquiLog.Windows;

namespace EquiLog.Pages.Storage
{
    public partial class Index : Page
    {
        public Index()
        {
            InitializeComponent();
            dgUsers.ItemsSource = Storage_controller.storageList;
        }

        private void Btn_Add_OnClick(object sender, RoutedEventArgs e)
        {
            new Popups("../Pages/Storage/Add.xaml").Show();
        }
    }
}