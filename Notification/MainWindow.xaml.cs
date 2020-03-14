using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NotificationControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Notification> Notifications = new ObservableCollection<Notification>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = Notifications;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Notifications.Add(new Notification(nameBankTextBox.Text, descriptionTextBox.Text));
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (sender as ListView).SelectedIndex = -1;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Notifications.Clear();
        }
    }
}
