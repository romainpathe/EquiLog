using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using EquiLog.Classes;

namespace EquiLog.Windows
{
    public partial class Login : Window
    {
        //TODO: Ajouter une croix de fermeture custom
        public Login()
        {
            InitializeComponent();
            if (!Configuration_Controller.config.RegistrationEnabled)
            {
                RegistrationMessage.Visibility = Visibility.Hidden;
            }
        }

        private void openRegister_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            new Register().Show();
            Close();
        }

        private void Login_Username_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (Login_Username.Text == "Nom d'utilisateur")
            {
                Login_Username.Text = "";
            }
        }
        private void Login_Username_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (Regex.Replace(Login_Username.Text, @" ", "") == "")
            {
                Login_Username.Text = "Nom d'utilisateur";
            }
        }

        private void Login_Password_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (Login_Password.Password == "Password")
            {
                Login_Password.Password = "";
            }
        }

        private void Login_Password_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (Regex.Replace(Login_Password.Password, @" ", "") == "")
            {
                Login_Password.Password = "Password";
            }
        }

        private void Login_Button_OnClick(object sender, RoutedEventArgs e)
        {
            Login_Button.IsEnabled = false;
            try
            {
                var userData = Staff_controller.staffList.First(i => i.Password == Login_Password.Password && i.Username == Login_Username.Text);
                Staff_controller.actifUserId = userData.Id;
                new Logiciel().Show();
                Close();
            }
            catch (Exception exception)
            {
                Trace.WriteLine(exception);
                Login_Error.Visibility = Visibility.Visible;
            }
            Login_Button.IsEnabled = true;
        }
    }
}