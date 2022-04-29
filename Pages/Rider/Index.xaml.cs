using System;
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

        private void Btn_Remove_OnClick(object sender, RoutedEventArgs e)
        {
            var result = Int32.TryParse(RemoveID.Text, out var id);
            if (!result || Rider_controller.riderList.Find(x => x.Id == id) == null)
            {
                RemoveError.Visibility = Visibility.Visible;   
                return;
            }
            Rider_controller.RemoveRider(id);
            RemoveError.Visibility = Visibility.Hidden;
            RemoveID.Text = "";
        }
    }
}