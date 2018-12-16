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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        string[] tmp_fields = new string[13];
        public Page3(string[] fields)
        {
            InitializeComponent();
            for (int i = 0; i < 13; i++)
            {
                tmp_fields[i] = fields[i];
            }
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            tmp_fields[8] = bio.Text;
            tmp_fields[9] = id.Text;
            tmp_fields[10] = license.Text;
            tmp_fields[11] = music.Text;
            tmp_fields[12] = "NEW USER";

            person usr = new person(tmp_fields);

            usr.SavePerson();
            this.NavigationService.Navigate(new Page4(tmp_fields[0]));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
        }

        private void music_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (music.Text == "jazz, hip-hop, ...")
            {
                music.Text = "";
            }
        }

        private void music_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (music.Text == "")
            {
                music.Text = "jazz, hip-hop, ...";
            }
        }

        private void bio_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (bio.Text == "")
            {
                bio.Text = "What do you like to do?";
            }
        }

        private void bio_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (bio.Text == "What do you like to do?")
            {
                bio.Text = "";
            }
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

        
    }
}
