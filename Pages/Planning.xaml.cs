using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using EquiLog.Controllers;
using EquiLog.Models;

namespace EquiLog.Pages
{
    public partial class Planning : Page
    {
        //private int[] hours = {8,9,10,11,12,13,14,15,16,17,18,19,20,21,22};
        public Planning()
        {
            InitializeComponent();
            updateGrid();
            Grid.SetColumn(grid,0);
            Grid.SetRow(grid,0);
            Plan.Children.Add(grid);
        }
        private Grid grid { get; set; }
        private TextBlock myText { get; set; }
        
        private void updateGrid()
        {
            grid = new Grid();
            grid.ShowGridLines = true;
            Planning_controller.InitPlanning();
            var x = Planning_controller.planning;
            displayHeader();
            displayEquidea();
            displayRider();
        }

        private void displayHeader()
        {
            var z = new RowDefinition();
            z.MaxHeight = 30;
            grid.RowDefinitions.Add(z);
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            TextBlock textBlock = new TextBlock(new Run("Nom du cheval"));
            textBlock.TextAlignment = TextAlignment.Center;
            textBlock.VerticalAlignment = VerticalAlignment.Center;
            textBlock.Foreground = new SolidColorBrush(Colors.White);
            Grid.SetColumn(textBlock,0);
            Grid.SetRow(textBlock,0);
            grid.Children.Add(textBlock);
            foreach (var hour in Planning_controller.Hours)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
                textBlock = new TextBlock(new Run(hour.Hours+"h"));
                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.VerticalAlignment = VerticalAlignment.Center;
                textBlock.Foreground = new SolidColorBrush(Colors.White);
                Grid.SetColumn(textBlock,hour.Columns);
                Grid.SetRow(textBlock,0);
                grid.Children.Add(textBlock);
            }
        }

        private void displayEquidea()
        {
            TextBlock textBlock;
            int i = 1;
            foreach (var equidea in Equidae_controller.equideaList)
            {
                var z = new RowDefinition();
                z.MaxHeight = 30;
                grid.RowDefinitions.Add(z);
                textBlock = new TextBlock(new Run(equidea.Firstname));
                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.VerticalAlignment = VerticalAlignment.Center;
                textBlock.Foreground = new SolidColorBrush(Colors.White);
                Grid.SetColumn(textBlock,0);
                Grid.SetRow(textBlock,i);
                grid.Children.Add(textBlock);
                i++;
            }
        }

        private void displayRider()
        {
            TextBlock textBlock;

            foreach (var data in Planning_controller.planning)
            {
                var rider = Rider_controller.riderList.Find(x => x.Id == data.Rider_id);
                Debug.WriteLine("RIDER: "+rider);
                if (rider != null)
                {
                    var equidea = Equidae_controller.equideaList.Find(x=>x.Id == data.Equidea_id);
                    Debug.WriteLine("EQUIDEA: "+equidea);
                    if (equidea != null)
                    {
                        var index = Equidae_controller.equideaList.IndexOf(equidea);
                        Debug.WriteLine("INDEX: "+index);
                        var hours = Planning_controller.Hours.Find(x => x.Id == data.Hours_id);
                        Debug.WriteLine("HOURS: "+hours);
                        if (hours != null)
                        {
                            textBlock = new TextBlock(new Run(rider.Firstname+" "+rider.Lastname[0]));
                            textBlock.TextAlignment = TextAlignment.Center;
                            textBlock.VerticalAlignment = VerticalAlignment.Center;
                            textBlock.Foreground = new SolidColorBrush(Colors.White);
                            Grid.SetColumn(textBlock,hours.Columns);
                            Grid.SetRow(textBlock,index+1);
                            grid.Children.Add(textBlock);
                        }
                    }
                }
            }
        }
        
        
    }
}