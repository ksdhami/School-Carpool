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
    /// Interaction logic for Page8.xaml
    /// </summary>
    public partial class Page8 : Page
    {
        person user;
        string[] messages;
        public Page8(string email)
        {
            InitializeComponent();
            user = new person(email);

            // messages[0] = "TO | FROM | 0 | TIME | MESSAGE";

            string directory = Directory.GetCurrentDirectory();
            string filepath = directory + "\\messages.txt";

            int i = 0;
            messages = new string[50];
            string[] tmp_parts = new string[4];

            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    String line = sr.ReadLine();
                    while (line != null)
                    {
                        messages[i] = line;
                        i++;
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Could not read messages.txt file");
            }


            if (i > 0)
            {
                string[] tmp;
                for (int j = 0; j<i ; j++) {
                    tmp = messages[j].Split('|');

                    if(tmp[0] == user.getEmail())
                    {

                        Display_msg(j, tmp);

                    }
                }
            }
        }
        private void Display_msg(int msg_index, string[] parts)
        {
            string directory = Directory.GetCurrentDirectory();
            string msg = parts[3];
            string time = parts[2];

            person sender = new person(parts[1]);

            if (msg_index == 0)
            {
                name1.Content = sender.getFirstName();
                msg1.Content = msg;
                time1.Content = time;
                pic1.Source = new BitmapImage(new Uri(directory + "\\" + sender.getPhotoPath()));
            }

            else if (msg_index == 1)
            {
                name2.Content = sender.getFirstName();
                msg2.Content = msg;
                time2.Content = time;
                pic2.Source = new BitmapImage(new Uri(directory + "\\" + sender.getPhotoPath()));
            }
            else if (msg_index == 2)
            {
                name3.Content = sender.getFirstName();
                msg3.Content = msg;
                time3.Content = time;
                pic3.Source = new BitmapImage(new Uri(directory + "\\" + sender.getPhotoPath()));
            }
            else if (msg_index == 3)
            {
                name4.Content = sender.getFirstName();
                msg4.Content = msg;
                pic4.Source = new BitmapImage(new Uri(directory + "\\" + sender.getPhotoPath()));
            }
            else if (msg_index == 4)
            {
                name5.Content = sender.getFirstName();
                msg5.Content = msg;
                pic5.Source = new BitmapImage(new Uri(directory + "\\" + sender.getPhotoPath()));
            }
            else if (msg_index == 5)
            {
                name6.Content = sender.getFirstName();
                msg6.Content = msg;
                pic6.Source = new BitmapImage(new Uri(directory + "\\" + sender.getPhotoPath()));
            }
            else if (msg_index == 6)
            {
                name7.Content = sender.getFirstName();
                msg7.Content = msg;
                pic7.Source = new BitmapImage(new Uri(directory + "\\" + sender.getPhotoPath()));
            }
            else if (msg_index == 7)
            {
                name8.Content = sender.getFirstName();
                msg8.Content = msg;
                pic8.Source = new BitmapImage(new Uri(directory + "\\" + sender.getPhotoPath()));
            }
            else if (msg_index == 8)
            {
                name9.Content = sender.getFirstName();
                msg9.Content = msg;
                pic9.Source = new BitmapImage(new Uri(directory + "\\" + sender.getPhotoPath()));
            }
            else if (msg_index == 9)
            {
                name10.Content = sender.getFirstName();
                msg10.Content = msg;
                pic10.Source = new BitmapImage(new Uri(directory + "\\" + sender.getPhotoPath()));
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

        private void next1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page9(user.getEmail(), "mathew@test.ca"));
        }

        private void next2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page9(user.getEmail(), "emily@test.ca"));
        }
    }
}
