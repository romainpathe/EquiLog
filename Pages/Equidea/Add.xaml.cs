using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using EquiLog.Controllers;
using MaterialDesignThemes.Wpf;

namespace EquiLog.Pages.Equidea
{
    public partial class Add : Page
    {
        public Add()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, System.Windows.RoutedEventArgs e)
        {
            Equidae_controller.AddEquidae(lastname.Text, firstname.Text, gender.Text,Convert.ToInt32(age.Text),color.Text,Convert.ToInt32(hours.Text));
            Window.GetWindow(this)?.Close();
        }
    }
}