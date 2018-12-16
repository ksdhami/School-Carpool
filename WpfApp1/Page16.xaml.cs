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
    /// Interaction logic for Page16.xaml
    /// </summary>
    public partial class Page16 : Page
    {
        person user;
        public Page16(string usr_email)
        {
            InitializeComponent();
            user = new person(usr_email);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page4(user.getEmail()));
        }

        private void profile_but_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page5(user.getEmail()));
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page5(user.getEmail()));
        }
        private void Ride_but_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page7(user.getEmail()));
        }

        private void Notification_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page10(user.getEmail()));
        }

        private void message_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page8(user.getEmail()));
        }

        private void license_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (license.Text == "enter file name")
            {
                license.Text = "";
            }
        }

        private void license_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (license.Text == "")
            {
                license.Text = "enter file name";
            }
        }

        private void id_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (id.Text == "")
            {
                id.Text = "enter file name";
            }
        }

        private void id_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (id.Text == "enter file name")
            {
                id.Text = "";
            }
        }

        private void profilePic_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (profilePic.Text == "")
            {
                profilePic.Text = "ENTER FILE NAME";
            }
            else
            {
                try
                {
                    string directory = Directory.GetCurrentDirectory();
                    Photo.Source = new BitmapImage(new Uri(directory + "\\" + profilePic.Text));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Could not find file");
                    profilePic.Text = "ENTER FILE NAME";
                }

            }
        }

        private void profilePic_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (profilePic.Text == "ENTER FILE NAME")
            {
                profilePic.Text = "";
            }
        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }
    }
}
