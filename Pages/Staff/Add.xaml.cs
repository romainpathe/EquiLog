﻿using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;

namespace EquiLog.Pages.Staff
{
    public partial class Add : Page
    {
        public Add()
        {
            InitializeComponent();
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (firstname.Text == "")
            {
                MessageBox.Show("Le prénom ne peux pas être nul");
                return;
            }
            if (lastname.Text == "")
            {
                MessageBox.Show("Le nom ne peux pas être nul");
                return;
            }
            if (job.Text == "")
            {
                MessageBox.Show("Le job ne peux pas être nul");
                return;
            }
            if (hours.Text == "")
            {
                MessageBox.Show("Le nombre d'heures ne peux pas être nul");
                return;
            }
            if (holidays.Text == "")
            {
                MessageBox.Show("Le nombre de vacances ne peux pas être nul");
                return;
            }
            if (password.Text == "")
            {
                MessageBox.Show("Le mot de passe ne peux pas être nul");
                return;
            }
            var x = int.TryParse(hours.Text, out var intHours);
            var y = int.TryParse(holidays.Text, out var intHolidays);
            if (!x||!y)
            {
                MessageBox.Show("Les vacances et les heures doivent être un nombre");
                return;
            }
            Staff_controller.AddStaff(firstname.Text,lastname.Text,password.Text,job.Text,intHours,intHolidays);
            Window.GetWindow(this)?.Close();
        }
    }
}