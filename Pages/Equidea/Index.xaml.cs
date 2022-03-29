using System.Windows;
using System.Windows.Controls;
using EquiLog.Windows;

namespace EquiLog.Pages.Equidea
{
    public partial class Index : Page
    {
        public Index()
        {
            InitializeComponent();
        }
        
        private void Btn_Add_OnClick(object sender, RoutedEventArgs e)
        {
            new Popups("../Pages/Equidea/Add.xaml").Show();
        }
        
        
    }
}