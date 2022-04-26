using System.Windows;
using System.Windows.Controls;
using EquiLog.Controllers;
using EquiLog.Windows;

namespace EquiLog.Pages.Equidea
{
    public partial class Index : Page
    {
        public Index()
        {
            InitializeComponent();
            dgUsers.ItemsSource = Equidae_controller.equideaList;
        }
        
        private void Btn_Add_OnClick(object sender, RoutedEventArgs e)
        {
            new Popups("../Pages/Equidea/Add.xaml").Show();
        }
        
        
    }
}