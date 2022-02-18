using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows;
using EquiLog.Models;

namespace EquiLog.Classes
{
    public class Configuration_Controller
    {
        //public static Visibility RegistrationEnabled { get; private set; } = Visibility.Visible;
        public static Configuration_model config;
        
        public static void InitConfiguration()
        {
            var srConfig = new StreamReader("../../Resources/config.json");
            config = JsonSerializer.Deserialize<Configuration_model>(srConfig.ReadToEnd());
            srConfig.Close();
        }

        private static void UpdateConfiguration()
        {
            var jsonConfigString = JsonSerializer.Serialize(config);
            var swConfig = new StreamWriter("../../Resources/config.json");
            swConfig.Write(jsonConfigString);
            swConfig.Close();
        }
        
        public static void ChangeRegistrationValue()
        {
            config.RegistrationEnabled = !config.RegistrationEnabled;
            UpdateConfiguration();
        }
        
    }
}