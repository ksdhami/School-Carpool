using System;
using System.Collections.Generic;
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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        person user;
        public Page4(string usr_email)
        {
            InitializeComponent();
            user = new person(usr_email);

            string directory = Directory.GetCurrentDirectory();
            string picName = user.getPhotoPath();
            if (picName == "ENTER FILE NAME")
            {
                picName = "unknown.png";
            }
            try
            {
                profilePic.Source = new BitmapImage(new Uri(directory + "\\" + user.getPhotoPath()));
            }
            catch (Exception e)
            {
                //profilePic.Source = new BitmapImage(new Uri(directory + "\\" + "unknown.png"));
                Console.WriteLine("FILE NOT FOUND");
            }
            greeting.Content = "Hey, " + user.getFirstName();
        }

        private void get_ride_but_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page7(user.getEmail()));
        }

        private void profile_but_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page5(user.getEmail()));
        }

        private void Ride_but_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page7(user.getEmail()));
        }

        private void schedule_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page6(user.getEmail()));
        }

        private void Settings_but_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page16(user.getEmail()));
        }

        private void Notification_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page10(user.getEmail()));
        }

        private void message_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page8(user.getEmail()));
        }
    }
}
