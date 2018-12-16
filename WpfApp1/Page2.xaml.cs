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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        string[] fields = new string[13];

        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fields[0] = email.Text; 
            fields[1] = password.Password.ToString(); 
            fields[2] = Fname.Text;
            fields[3] = Lname.Text; 
            fields[4] = address.Text;
            fields[5] = postalCode.Text;
            fields[6] = univercity.Text;
            fields[7] = profilePic.Text;

            NavigationService.Navigate(new Page3(fields));
        }

        private void address_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (address.Text == "Street Address")
            {
                address.Text = "";
            }
        }
        private void address_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (address.Text == "")
            {
                address.Text = "Street Address";
            }
        }

        private void postalCode_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (postalCode.Text == "")
            {
                postalCode.Text = "Postal Code";
            }
        }

        private void postalCode_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (postalCode.Text == "Postal Code")
            {
                postalCode.Text = "";
            }
        }

        private void Fname_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (Fname.Text == "First Name")
            {
                Fname.Text = "";
            }
        }

        private void Fname_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (Fname.Text == "")
            {
                Fname.Text = "First Name";
            }
        }
        private void Lname_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (Lname.Text == "Last Name")
            {
                Lname.Text = "";
            }
        }

        private void Lname_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (Lname.Text == "")
            {
                Lname.Text = "Last Name";
            }
        }

        private void profilePic_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (profilePic.Text == "ENTER FILE NAME")
            {
                profilePic.Text = "";
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
                    Photo.Source = new BitmapImage(new Uri(directory+ "\\" +profilePic.Text));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Could not find file");
                    profilePic.Text = "ENTER FILE NAME";
                }

            }
        }
    }
}
