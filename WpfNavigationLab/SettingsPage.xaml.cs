
using System.Windows;
using System.Windows.Controls;

namespace WpfNavigationLab
{
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (chkNotifications.IsChecked == true)
            {
                MessageBox.Show(
                    "Az értesítések engedélyezve vannak.");
            }
            else
            {
                MessageBox.Show(
                    "Az értesítések le vannak tiltva.");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null &&
                NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Nincs előző oldal.");
            }
        }
    }
}
