using System.Windows;
using System.Windows.Controls;
using EquiLog.Classes;
using EquiLog.Controllers;

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
        
        private void RemovePlanningButton_Click(object sender, RoutedEventArgs e)
        {
            Planning_controller.planning.RemoveAll(x=> x.Equidea_id != null);
        }
        
    }
}