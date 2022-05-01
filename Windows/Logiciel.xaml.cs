using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using EquiLog.Controllers;

namespace EquiLog.Windows
{
    public partial class Logiciel : Window
    {
        public Logiciel()
        {
            InitializeComponent();
            Rider_controller.InitRiderList();
            Equidae_controller.InitEquideaList();
            Storage_controller.InitStorageList();
            Planning_controller.InitPlanning();
            Planning_controller.InitHours();
            fContainer.Navigate(new System.Uri("../Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        // Start: MenuLeft PopupButton //
        private void btnHome_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnHome;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Home";
            }
        }

        private void btnHome_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnStaff_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnStaff;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Staff";
            }
        }

        private void btnStaff_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnRiders_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnRiders;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Riders";
            }
        }

        private void btnRiders_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnEquidea_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnEquidea;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Equidea";
            }
        }

        private void btnEquidea_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnPlanning_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnPlanning;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Planning";
            }
        }

        private void btnPlanning_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnStorage_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnStorage;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Storage";
            }
        }

        private void btnStorage_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        
        private void btnSetting_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnSetting;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Setting";
            }
        }

        private void btnSetting_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        // End: MenuLeft PopupButton //

        // Start: Button Close | Restore | Minimize 
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        // End: Button Close | Restore | Minimize

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("../Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("../Pages/Settings.xaml", UriKind.RelativeOrAbsolute));
        }


        private void BtnStaff_OnClick(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("../Pages/Staff/Index.xaml", UriKind.RelativeOrAbsolute));
        }
        private void BtnRiders_OnClick(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("../Pages/Rider/Index.xaml", UriKind.RelativeOrAbsolute));
        }
        
        private void BtnEquidea_OnClick(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("../Pages/Equidea/Index.xaml", UriKind.RelativeOrAbsolute));
        }


        private void BtnStorage_OnClick(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("../Pages/Storage/Index.xaml", UriKind.RelativeOrAbsolute));
        }
        private void BtnPlanning_OnClick(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("../Pages/Planning.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}