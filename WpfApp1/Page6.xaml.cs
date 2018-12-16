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
    /// Interaction logic for Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        person user;
        string[] my_pools = new string[50];
        string[] get_pools = new string[50];
        string[] give_pools = new string[50];

        public Page6(string usr_email)
        {
            InitializeComponent();
            user = new person(usr_email);

            my_pools = user.Load_pools(user.getEmail());
            get_pools = user.Load_pools("GET");
            give_pools = user.Load_pools("GIVE");

            //clark@theark.ca|GIVE|TIME|DEST|DATE|STATUS|POOLER_EMAIL
            Console.WriteLine(my_pools);
            string[] pool_info;

            if (my_pools[0] != null)
            {
                

                pool_info = my_pools[0].Split('|');

                person tmp_usr = new person(pool_info[0]);
                info2.Content = tmp_usr.getBio();

                string directory = Directory.GetCurrentDirectory();
                try
                {
                    pic2.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));
                }
                catch(Exception ex)
                {
                    pic2.Source = new BitmapImage(new Uri(@"C:\Users\Ahmad\Documents\WpfApp1\WpfApp1\unkown.png"));
                    Console.WriteLine("Error loading file");
                }

                rating2.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
                time2.Content = pool_info[2];
                dest2.Content = pool_info[3];

                pool_info = my_pools[1].Split('|');

                tmp_usr = new person(pool_info[0]);
                info3.Content = tmp_usr.getBio();

                try
                {
                    pic3.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));
                }
                catch (Exception ex)
                {
                    pic2.Source = new BitmapImage(new Uri(@"C:\Users\Ahmad\Documents\WpfApp1\WpfApp1\unkown.png"));
                    Console.WriteLine("Error loading file");
                }

                rating3.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
                time3.Content = pool_info[2];
                dest3.Content = pool_info[3];

                pool_info = my_pools[2].Split('|');

                tmp_usr = new person(pool_info[0]);
                info4.Content = tmp_usr.getBio();

                try
                {
                    pic4.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));
                }
                catch (Exception ex)
                {
                    pic2.Source = new BitmapImage(new Uri(@"C:\Users\Ahmad\Documents\WpfApp1\WpfApp1\unkown.png"));
                    Console.WriteLine("Error loading file");
                }

                rating4.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
                time4.Content = pool_info[2];
                dest4.Content = pool_info[3];

                pool_info = my_pools[3].Split('|');

                tmp_usr = new person(pool_info[0]);
                info5.Content = tmp_usr.getBio();

                try
                {
                    pic5.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));
                }
                catch (Exception ex)
                {
                    pic2.Source = new BitmapImage(new Uri(@"C:\Users\Ahmad\Documents\WpfApp1\WpfApp1\unkown.png"));
                    Console.WriteLine("Error loading file");
                }

                rating5.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
                time5.Content = pool_info[2];
                dest5.Content = pool_info[3];
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

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            string pool = user.getEmail() + "|" + status.Text + "|" + time.Text + "|" + destination.Text + "|" + date.Text + "|"+ "POOLER_EMAIL";
            user.AddPool(pool);

            status.Text = "GET";
            destination.Text = "HOME";
            time.Text = "";
            date.Text = "";
        }
    }
}
