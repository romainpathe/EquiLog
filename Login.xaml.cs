using System.Windows.Controls;

namespace EquiLog
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string Title { get; set; }

        public int MaxLength { get; set; }
    }
}