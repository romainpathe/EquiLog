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
            Window.GetWindow(this)?.Close();
        }
    }
}