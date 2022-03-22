﻿using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using EquiLog.Windows;

namespace EquiLog.Pages.Staff
{
    public partial class Index : Page
    {
        public Index()
        {
            InitializeComponent();
            dgUsers.ItemsSource = Staff_controller.staffList;
        }
        private void Btn_Add_OnClick(object sender, RoutedEventArgs e)
        {
            new Popups("../Pages/Staff/Add.xaml").Show();
        }
    }
}