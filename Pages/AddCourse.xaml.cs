using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Xaml;
using EquiLog.Controllers;
using EquiLog.Models;

namespace EquiLog.Pages
{
    public partial class AddCourse : Page
    {
        public AddCourse()
        {
            InitializeComponent();
            ListHours();
            ListEquidea();
            ListRider();
        }
        

        

        private static List<Hours_model> myHours =  Planning_controller.Hours.ToList();
        private static List<Rider_model> myRider =  Rider_controller.riderList.ToList();
        private static List<Equidea_model> myEquidea =  Equidae_controller.equideaList.ToList();

        private void ListHours()
        {
            myHours = Planning_controller.Hours.ToList();
            if (EquideaList.SelectedIndex != -1)
            {
                var r = Equidae_controller.equideaList[EquideaList.SelectedIndex];
                foreach (var hour in myHours.ToList())
                {
                    if (Planning_controller.planning.Any(x => x.Hours_id == hour.Id && x.Equidea_id == r.Id))
                    {
                        myHours.Remove(hour);
                    }
                }
            }
            if (RiderList.SelectedIndex != -1)
            {
                var r = Rider_controller.riderList[RiderList.SelectedIndex];
                foreach (var hour in myHours.ToList())
                {
                    if (Planning_controller.planning.Any(x => x.Hours_id == hour.Id && x.Rider_id == r.Id))
                    {
                        myHours.Remove(hour);
                    }
                }
            }
            HoursList.Items.Clear();
            foreach (var hour in myHours)
            {
                HoursList.Items.Add(hour.Hours+"h - "+hour.Id);
            }
        }

        private void ListRider()
        {
            myRider = Rider_controller.riderList.ToList();
            
            if (EquideaList.SelectedIndex != -1)
            {
                var s = Int32.TryParse(EquideaList.Text.Split('-')[1], out int ht);
                if (s)
                {
                    foreach (var rider in myRider.ToList())
                    {
                        if (Planning_controller.planning.Any(x => x.Rider_id == rider.Id && x.Equidea_id == ht))
                        {
                            myRider.Remove(rider);
                        }
                    }  
                }
            }
            if (HoursList.SelectedIndex != -1)
            {
                var s = Int32.TryParse(HoursList.Text.Split('-')[1], out int ht);
                if (s)
                {
                    foreach (var rider in myRider.ToList())
                    {
                        if (Planning_controller.planning.Any(x => x.Rider_id == rider.Id && x.Hours_id == ht))
                        {
                            myRider.Remove(rider);
                        }
                    }
                }
            }
            RiderList.Items.Clear();
            foreach (var rider in myRider.ToList())
            {
                RiderList.Items.Add(rider.Firstname+" - "+rider.Id);
            }
        }
        
        private void ListEquidea()
        {
            myEquidea = Equidae_controller.equideaList.ToList();
            
            if (RiderList.SelectedIndex != -1)
            {
                var s = Int32.TryParse(RiderList.Text.Split('-')[1], out int ht);
                if (s)
                {
                    foreach (var equidea in myEquidea.ToList())
                    {
                        if (Planning_controller.planning.Any(x => x.Equidea_id == equidea.Id && x.Rider_id == ht))
                        {
                            myEquidea.Remove(equidea);
                        }
                    }  
                }
            }
            if (HoursList.SelectedIndex != -1)
            {
                var s = Int32.TryParse(HoursList.Text.Split('-')[1], out int ht);
                if (s)
                {
                    foreach (var equidea in myEquidea.ToList())
                    {
                        if (Planning_controller.planning.Any(x => x.Equidea_id == equidea.Id && x.Hours_id == ht))
                        {
                            myEquidea.Remove(equidea);
                        }
                    }
                }
            }
            
            EquideaList.Items.Clear();
            foreach (var equidea in myEquidea.ToList())
            {
                EquideaList.Items.Add(equidea.Firstname+" - "+equidea.Id);
            }
        }

        private void RiderList_OnDropDownOpened(object sender, EventArgs e)
        {
            ListRider();
        }

        private void EquideaList_OnDropDownOpened(object sender, EventArgs e)
        {
            ListEquidea();
        }
        
        private void HoursList_OnDropDownOpened(object sender, EventArgs e)
        {
            ListHours();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var a = Int32.TryParse(RiderList.Text.Split('-')[1], out int r);
            var b = Int32.TryParse(EquideaList.Text.Split('-')[1], out int f);
            var c = Int32.TryParse(HoursList.Text.Split('-')[1], out int h);
            if (a && b && c)
            {
                Planning_controller.AddPlanning(f,h,r);
                Window.GetWindow(this)?.Close();
            }
        }
    }
}