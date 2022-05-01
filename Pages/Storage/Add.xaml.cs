using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using EquiLog.Controllers;
using MaterialDesignThemes.Wpf;

namespace EquiLog.Pages.Storage
{
    public partial class Add : Page
    {
        public Add()
        {
            InitializeComponent();
            Hay.Text = Storage_controller.storageList.Last().Hay.ToString();
            Granule.Text= Storage_controller.storageList.Last().Granule.ToString();
            Briddle.Text= Storage_controller.storageList.Last().Briddle.ToString();
            Saddle.Text= Storage_controller.storageList.Last().Saddle.ToString();
            Blanket.Text= Storage_controller.storageList.Last().Blanket.ToString();
            Stirrup.Text= Storage_controller.storageList.Last().Stirrup.ToString();
            StirrupStraps.Text= Storage_controller.storageList.Last().StirrupStraps.ToString();
            SaddlePad.Text= Storage_controller.storageList.Last().SaddlePad.ToString();

        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            

            /*if (firstname.Text == "")
            {
                MessageBox.Show("Le prénom ne peux pas être null");
                return;
            }
            if (lastname.Text == "")
            {
                MessageBox.Show("Le nom ne peux pas être null");
                return;
            }
            if (level.Text == "")
            {
                MessageBox.Show("Le level ne peux pas être null");
                return;
            }
            if (email.Text == "")
            {
                MessageBox.Show("L'email ne peux pas être null");
                return;
            }
            if (phone.Text == "")
            {
                MessageBox.Show("Le téléphone ne peux pas être null");
                return;
            }
            if (course.Text == "")
            {
                MessageBox.Show("Le nombre d'heure de cours ne peux pas être null");
                return;
            }
            var x = int.TryParse(course.Text, out var intCourse);
            if (!x)
            {
                MessageBox.Show("Les heures de cours doit être un nombres");
                return;
            }

            Rider_controller.AddRider(firstname.Text, lastname.Text, email.Text,phone.Text,intCourse,level.Text);
            Window.GetWindow(this)?.Close();*/
        }
    }
}