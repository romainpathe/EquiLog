using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using EquiLog.Controllers;
using MaterialDesignThemes.Wpf;
using EquiLog.Models;

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
            

            if (Hay.Text == "")
            {
                MessageBox.Show("Le foin ne peux pas être nul");
                return;
            }
            if (Granule.Text == "")
            {
                MessageBox.Show("Les granulés ne peuvent pas être nul");
                return;
            }
            if (Briddle.Text == "")
            {
                MessageBox.Show("Les filets ne peuvent pas être nul");
                return;
            }
            if (Saddle.Text == "")
            {
                MessageBox.Show("Les selles ne peuvent pas être nul");
                return;
            }
            if (Blanket.Text == "")
            {
                MessageBox.Show("Les couvertures ne peuvent pas être nul");
                return;
            }
            if (Stirrup.Text == "")
            {
                MessageBox.Show("Les étriers ne peuvent pas être nul");
                return;
            }
            if (StirrupStraps.Text == "")
            {
                MessageBox.Show("Les étrivières ne peuvent pas être nulle");
                return;
            }
            if (SaddlePad.Text == "")
            {
                MessageBox.Show("Les tapis ne peuvent pas être nul");
                return;
            }
            var x = int.TryParse(Hay.Text, out var inthay);
            if (!x)
            {
                MessageBox.Show("Le foin doit être un nombre");
                return;
            }
            var y = int.TryParse(Granule.Text, out var intgranule);
            if (!y)
            {
                MessageBox.Show("Le foin doit être un nombre");
                return;
            }
            var z = int.TryParse(Briddle.Text, out var intbriddle);
            if (!z)
            {
                MessageBox.Show("Les filets doivent être un nombre");
                return;
            }
            var a = int.TryParse(Saddle.Text, out var intsaddle);
            if (!a)
            {
                MessageBox.Show("Les selles doivent être un nombre");
                return;
            }
            var b = int.TryParse(Blanket.Text, out var intblanket);
            if (!b)
            {
                MessageBox.Show("Les couvertures doivent être un nombre");
                return;
            }
            var c = int.TryParse(Stirrup.Text, out var intstirrup);
            if (!c)
            {
                MessageBox.Show("Les étriers doivent être un nombre");
                return;
            }
            var d = int.TryParse(StirrupStraps.Text, out var intstirrupstraps);
            if (!d)
            {
                MessageBox.Show("Les étrivières doivent être un nombre");
                return;
            }
            var f = int.TryParse(SaddlePad.Text, out var intsaddlepad);
            if (!f)
            {
                MessageBox.Show("Les tapis doivent être un nombre");
                return;
            }

            Storage_model storage = new Storage_model(inthay,intgranule,intbriddle,intsaddle,intblanket,intstirrup,intstirrupstraps,intsaddlepad); 
            Storage_controller.AddStorage(storage);
            Window.GetWindow(this)?.Close();
        }
    }
}