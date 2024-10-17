using System.Text;
using System.Windows;
using Password_Manager.View;

namespace Password_Manager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPassword_Click(object sender, RoutedEventArgs e)
        {
            CreatePassword createPasswordWindow = new CreatePassword();
            createPasswordWindow.ShowDialog();
        }
    }
}