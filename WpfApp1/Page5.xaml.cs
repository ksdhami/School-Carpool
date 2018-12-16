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
    /// Interaction logic for Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        person user;
        public Page5(string usr_email)
        {
            InitializeComponent();
            user = new person(usr_email);

            if (user.getPhotoPath() != "ENTER FILE NAME")
            {
                try
                {
                    string directory = Directory.GetCurrentDirectory();
                    profilePic.Source = new BitmapImage(new Uri(directory + "\\" + user.getPhotoPath()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Could not find profile picture: " + ex);
                }
            }


            bio.Text = user.getBio();
            Music.Text = user.getMusic();
            review.Content = user.getReviews();
            Name.Content = user.getFirstName() + " " + user.getLastName();  
        }

        public Page5 (string usr_email, string other_usr)
        {
            InitializeComponent();
            user = new person(usr_email);
            person tmp_user = new person(other_usr);

            profile_but.Background = Brushes.Black;

            if (tmp_user.getPhotoPath() != "ENTER FILE NAME")
            {
                try
                {
                    string directory = Directory.GetCurrentDirectory();
                    profilePic.Source = new BitmapImage(new Uri(directory + "\\" + tmp_user.getPhotoPath()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Could not find profile picture");
                }
            }
            bio.Text = tmp_user.getBio();
            Music.Text = tmp_user.getMusic();
            review.Content = tmp_user.getReviews();
            Name.Content = tmp_user.getFirstName() + " " + tmp_user.getLastName();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page4(user.getEmail()));
        }
        private void Ride_but_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page7(user.getEmail()));
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
