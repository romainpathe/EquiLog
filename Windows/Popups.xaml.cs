using System;
using System.Windows;

namespace EquiLog.Windows
{
    public partial class Popups : Window
    {
        public Popups()
        {
            InitializeComponent();
        }
        public Popups(string page)
        {
            InitializeComponent();
            fContainer.Navigate(new System.Uri(page, UriKind.RelativeOrAbsolute));
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Popups_OnDeactivated(object sender, EventArgs e)
        {
            var x = (Window) sender;
            x.Visibility = Visibility.Hidden;
        }
    }
}