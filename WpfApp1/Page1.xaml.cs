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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String user_email = email.Text;
            String user_pass = pass.Password.ToString();

            person usr = new person(user_email);
     
           
           if (user_pass == usr.getPassword())
           {
                this.NavigationService.Navigate(new Page4(user_email));
           }
        }

        /*
        private void email_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (email.Text == "Email")
            {
                email.Text = "";
            }
        }

        private void password_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
            }
        }

        private void password_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
            }
        }

        private void email_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Email";
            }
        }
        */

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
        }



        /*
        private void password_TextInput(object sender, TextCompositionEventArgs e)
        {
            String tmp = "";
            tmp = password.Text;
            if (tmp != "")
            {
                String newchar = tmp.Replace("*", "");
                user_pass = user_pass + newchar;

                password.Text = tmp.Replace(newchar, "*");
            }
        }
        */
    }
}
