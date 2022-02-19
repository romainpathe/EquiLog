using System;
using EquiLog.Classes;

namespace EquiLog
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            Configuration_Controller.InitConfiguration();
            Staff_controller.InitStaffList();
        }
    }
}