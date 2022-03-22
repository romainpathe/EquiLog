using System.Windows;
using System.Windows.Controls;
using EquiLog.Controllers;
using EquiLog.Windows;

namespace EquiLog.Pages.Rider
{
    public partial class Index : Page
    {
        public Index()
        {
            InitializeComponent();
            dgUsers.ItemsSource = Rider_controller.riderList;
        }

        private void Btn_Add_OnClick(object sender, RoutedEventArgs e)
        {
            new Popups("../Pages/Rider/Add.xaml").Show();
        }
    }
}