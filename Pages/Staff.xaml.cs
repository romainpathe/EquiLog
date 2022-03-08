using System.Windows.Controls;

namespace EquiLog.Pages
{
    public partial class Staff : Page
    {
        public Staff()
        {
            InitializeComponent();
            dgUsers.ItemsSource = Staff_controller.staffList;
        }
    }
}