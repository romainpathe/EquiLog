using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using EquiLog.Windows;

namespace EquiLog.Pages.Staff
{
    public partial class Index : Page
    {
        public Index()
        {
            InitializeComponent();
            dgUsers.ItemsSource = Staff_controller.staffList;
        }
        private void Btn_Add_OnClick(object sender, RoutedEventArgs e)
        {
            new Popups("../Pages/Staff/Add.xaml").Show();
        }

        private void Btn_Remove_OnClick(object sender, RoutedEventArgs e)
        {
            var result = Int32.TryParse(RemoveID.Text, out var id);
            if (!result || Staff_controller.staffList.Find(x => x.Id == id) == null)
            {
                RemoveError.Visibility = Visibility.Visible;   
                return;
            }
            Staff_controller.RemoveStaff(id);
            RemoveError.Visibility = Visibility.Hidden;
            RemoveID.Text = "";        }
    }
}