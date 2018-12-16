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
    /// Interaction logic for Page10.xaml
    /// </summary>
    public partial class Page10 : Page
    {
        person user;
        person rider, msg, con;
        public Page10(string usr_email)
        {
            InitializeComponent();
            promt.Visibility = Visibility.Collapsed;

            user = new person(usr_email);

            string directory = Directory.GetCurrentDirectory();
            string filepath = directory + "\\notification.txt";

            int i = 0;
            string[] notifcations = new string[50];
            string[] tmp_parts = new string[5];

            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    String line = sr.ReadLine();

                    tmp_parts = line.Split('|');

                    rider = new person(tmp_parts[0]);
                    req_name.Content = rider.getFirstName();

                    promt_pic.Source = new BitmapImage(new Uri(directory + "\\" + rider.getPhotoPath()));
                    req_pic.Source = new BitmapImage(new Uri(directory + "\\" + rider.getPhotoPath()));

                    promt_name.Content = rider.getFirstName() + " " + rider.getLastName();
                    promt_dest.Content = tmp_parts[2];


                    line = sr.ReadLine();
                    tmp_parts = line.Split('|');
                    msg = new person(tmp_parts[0]);

                    msg_name.Content = msg.getFirstName();
                    msg_pic.Source = new BitmapImage(new Uri(directory + "\\" + msg.getPhotoPath()));

                    msg_content.Content = tmp_parts[2];

                    line = sr.ReadLine();
                    tmp_parts = line.Split('|');

                    con = new person(tmp_parts[0]);

                    con_name.Content = msg.getFirstName();
                    con_pic.Source = new BitmapImage(new Uri(directory + "\\" + con.getPhotoPath()));

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Could not read notification file");
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page4(user.getEmail()));
        }

        private void profile_but_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page5(user.getEmail()));
        }
        private void Ride_but_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page7(user.getEmail()));
        }

        private void promt_pic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page5(user.getEmail(), rider.getEmail()));
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            request.Children.Clear();
            request.Height = 0;
            promt.Visibility = Visibility.Collapsed;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            promt.Visibility = Visibility.Collapsed;
        }

        private void req_button_Click(object sender, RoutedEventArgs e)
        {
            promt_name.Content = rider.getFirstName() + " " + rider.getLastName();
            promt_dest.Content = "Dest: HOME";
            promt_time.Content = "5:00 PM on 2018-04-12";

            promt.Visibility = Visibility.Visible;
        }

        private void msg_button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page8(user.getEmail()));

        }

        private void Settings_but_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page16(user.getEmail()));
        }

        private void message_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page8(user.getEmail()));
        }
    }
}
