using System.Windows;
using System.Windows.Controls;
using EquiLog.Classes;

namespace EquiLog.Pages
{
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
            RegistrationCheckBox.IsChecked = Configuration_Controller.config.RegistrationEnabled;
        }

        private void RegistrationCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Configuration_Controller.ChangeRegistrationValue();
        }
    }
}