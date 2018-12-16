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
    /// Interaction logic for Page9.xaml
    /// </summary>
    public partial class Page9 : Page
    {
        person user;
        person sender;
        int msg_count = 0;


        public Page9(string email, string sender_email)
        {
            InitializeComponent();
            user = new person(email);
            sender = new person(sender_email);

            
            string directory = Directory.GetCurrentDirectory();
            string filepath = directory + "Clark_msges";     //for other users use user.getFirstName() + "_msges"

            pic1.Source = new BitmapImage(new Uri(directory + "\\" + sender.getPhotoPath()));

            int i = 0;
            string [] messages = new string[50];
            string[] msg_parts = new string[4];

            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    String line = sr.ReadLine();
                    while (line != null)
                    {
                        if (messages[i].Contains(sender_email))
                        {
                            messages[i] = line;
                            i++;
                        }
                        line = sr.ReadLine();
                        
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Could not read messages.txt file");
            }

            //msg_parts = messages[0].Split('|');

            msg1.Content = "Hey clark, how are you";


            msg2.Content = "I'm good, hbu";


        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
        private void profile_but_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page5(user.getEmail()));
        }

        private void user_input_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (user_input.Text == "enter text message")
            {
                user_input.Text = "";
            }
        }

        private void user_input_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (user_input.Text == "")
            {
                user_input.Text = "enter text message";
            }
        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            if (msg_count == 0)
            {
                msg3.Content = user_input.Text;
                msg_count++;
            }
            else if (msg_count == 1)
            {
                msg4.Content = user_input.Text;
                msg_count++;
            }
            else if (msg_count == 2)
            {
                msg5.Content = user_input.Text;
                msg_count++;
            }
            else if (msg_count == 3)
            {
                msg6.Content = user_input.Text;
                msg_count++;
            }
            user_input.Text = "";
        }

    }
}
