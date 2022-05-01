using System.Windows;
using System.Windows.Controls;
using EquiLog.Controllers;

namespace EquiLog.Pages.Rider
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
            if (level.Text == "")
            {
                MessageBox.Show("Le galop ne peux pas être nul");
                return;
            }
            if (email.Text == "")
            {
                MessageBox.Show("L'email ne peux pas être nul");
                return;
            }
            if (phone.Text == "")
            {
                MessageBox.Show("Le téléphone ne peux pas être nul");
                return;
            }
            if (course.Text == "")
            {
                MessageBox.Show("Le nombre d'heure de cours ne peuvent pas être nulles");
                return;
            }
            var x = int.TryParse(course.Text, out var intCourse);
            if (!x)
            {
                MessageBox.Show("Les heures de cours doivent être un nombre");
                return;
            }

            Rider_controller.AddRider(firstname.Text, lastname.Text, email.Text,phone.Text,intCourse,level.Text);
            Window.GetWindow(this)?.Close();
        }
    }
}