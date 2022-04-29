using System;
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


        private void Btn_Remove_OnClick(object sender, RoutedEventArgs e)
        {
            var result = Int32.TryParse(RemoveID.Text, out var id);
            if (!result || Equidae_controller.equideaList.Find(x => x.Id == id) == null)
            {
                RemoveError.Visibility = Visibility.Visible;   
                return;
            }
            Equidae_controller.RemoveEquidea(id);
            RemoveError.Visibility = Visibility.Hidden;
            RemoveID.Text = "";
        }
    }
}