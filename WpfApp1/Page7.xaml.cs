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
    /// Interaction logic for Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        person user;
        person thePick;
        public Page7(string usr_email)
        {
            user = new person(usr_email);
            InitializeComponent();

            Setup_my_pool(user.getEmail());
            Setup_get_pool("GET");
            Setup_give_pool("GIVE");

            promt.Visibility = Visibility.Collapsed;

        }
        public void Setup_give_pool(string find)
        {
            string[] my_pools = user.Load_pools(find);

            string[] pool_info;

            //block 1
            pool_info = my_pools[0].Split('|');

            person tmp_usr = new person(pool_info[0]);
            info21.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();

            string directory = Directory.GetCurrentDirectory();
            pic21.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));

            rating21.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time21.Content = pool_info[2] + " on " + pool_info[4];
            dest21.Content = pool_info[3];

            //block 2
            pool_info = my_pools[1].Split('|');

            tmp_usr = new person(pool_info[0]);
            info22.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();

            pic22.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));

            rating22.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time22.Content = pool_info[2] + " on " + pool_info[4];
            dest22.Content = pool_info[3];

            //block 3
            pool_info = my_pools[2].Split('|');

            tmp_usr = new person(pool_info[0]);
            info23.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();

            pic23.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));

            rating23.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time23.Content = pool_info[2] + " on " + pool_info[4];
            dest23.Content = pool_info[3];

            //block 4
            pool_info = my_pools[3].Split('|');

            tmp_usr = new person(pool_info[0]);
            info24.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();

            pic24.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));

            rating24.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time24.Content = pool_info[2] + " on " + pool_info[4];
            dest24.Content = pool_info[3];

            //block 5
            pool_info = my_pools[4].Split('|');

            tmp_usr = new person(pool_info[0]);
            info25.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();

            pic25.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));

            rating25.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time25.Content = pool_info[2] + " on " + pool_info[4];
            dest25.Content = pool_info[3];

            //block 6
            pool_info = my_pools[5].Split('|');

            tmp_usr = new person(pool_info[0]);
            info26.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();

            pic26.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));

            rating26.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time26.Content = pool_info[2] + " on " + pool_info[4];
            dest26.Content = pool_info[3];

        }
        public void Setup_get_pool(string find)
        {
            string[] my_pools = user.Load_pools(find);

            string[] pool_info;

            //block 1
            if (my_pools[0] == null)
            {
                return;
            }
            pool_info = my_pools[0].Split('|');

            person tmp_usr = new person(pool_info[0]);
            info11.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();

            string directory = Directory.GetCurrentDirectory();
            try
            {
                pic11.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));
            }
            catch (Exception ex)
            {
                pic2.Source = new BitmapImage(new Uri(@"C:\Users\Ahmad\Documents\WpfApp1\WpfApp1\unkown.png"));
                Console.WriteLine("Error loading file");
            }

            rating11.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time11.Content = pool_info[2] + " on " + pool_info[4];
            dest11.Content = pool_info[3];

            //block 2
            if (my_pools[1] == null)
            {
                return;
            }
            pool_info = my_pools[1].Split('|');

            tmp_usr = new person(pool_info[0]);
            info12.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();
            try
            {
                pic12.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));
            }
            catch (Exception ex)
            {
                pic2.Source = new BitmapImage(new Uri(@"C:\Users\Ahmad\Documents\WpfApp1\WpfApp1\unkown.png"));
                Console.WriteLine("Error loading file");
            }
            rating12.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time12.Content = pool_info[2] + " on " + pool_info[4];
            dest12.Content = pool_info[3];

            //block 3
            if (my_pools[2] == null)
            {
                return;
            }
            pool_info = my_pools[2].Split('|');

            tmp_usr = new person(pool_info[0]);
            info13.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();
            try
            {
                pic13.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));
            }
            catch (Exception ex)
            {
                pic2.Source = new BitmapImage(new Uri(@"C:\Users\Ahmad\Documents\WpfApp1\WpfApp1\unkown.png"));
                Console.WriteLine("Error loading file");
            }
            rating13.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time13.Content = pool_info[2] + " on " + pool_info[4];
            dest13.Content = pool_info[3];

            //block 4
            if (my_pools[3] == null)
            {
                return;
            }
            pool_info = my_pools[3].Split('|');

            tmp_usr = new person(pool_info[0]);
            info14.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();
            try
            {
                pic14.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));
            }
            catch (Exception ex)
            {
                pic2.Source = new BitmapImage(new Uri(@"C:\Users\Ahmad\Documents\WpfApp1\WpfApp1\unkown.png"));
                Console.WriteLine("Error loading file");
            }
            rating14.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time14.Content = pool_info[2] + " on " + pool_info[4];
            dest14.Content = pool_info[3];

            //block 5
            if (my_pools[4] == null)
            {
                return;
            }
            pool_info = my_pools[4].Split('|');

            tmp_usr = new person(pool_info[0]);
            info15.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();
            try
            {
                pic15.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));
            }
            catch (Exception ex)
            {
                pic2.Source = new BitmapImage(new Uri(@"C:\Users\Ahmad\Documents\WpfApp1\WpfApp1\unkown.png"));
                Console.WriteLine("Error loading file");
            }
            rating15.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time15.Content = pool_info[2] + " on " + pool_info[4];
            dest15.Content = pool_info[3];

            //block 6
            if (my_pools[5] == null)
            {
                return;
            }
            pool_info = my_pools[5].Split('|');

            tmp_usr = new person(pool_info[0]);
            info16.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();
            try
            {
                pic16.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));
            }
            catch (Exception ex)
            {
                pic2.Source = new BitmapImage(new Uri(@"C:\Users\Ahmad\Documents\WpfApp1\WpfApp1\unkown.png"));
                Console.WriteLine("Error loading file");
            }
            rating16.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time16.Content = pool_info[2] + " on " + pool_info[4];
            dest16.Content = pool_info[3];

        }
        public void Setup_my_pool(string find)
        {
            string[] my_pools = user.Load_pools(find);

            string[] pool_info;

            if(my_pools[0] == null)
            {
                return;
            }
            //block 1
            pool_info = my_pools[0].Split('|');

            person tmp_usr = new person(pool_info[0]);
            info1.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();

            string directory = Directory.GetCurrentDirectory();

            try
            {
                pic1.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));
            }
            catch (Exception ex)
            {
                pic2.Source = new BitmapImage(new Uri(@"C:\Users\Ahmad\Documents\WpfApp1\WpfApp1\unkown.png"));
                Console.WriteLine("Error loading file");
            }
            rating1.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time1.Content = pool_info[2] + " on " + pool_info[4];
            dest1.Content = pool_info[3];

            //block 2
            if (my_pools[1] == null)
            {
                return;
            }
            pool_info = my_pools[1].Split('|');

            tmp_usr = new person(pool_info[0]);
            info2.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();

            try
            {
                pic2.Source = new BitmapImage(new Uri(directory + "\\" + tmp_usr.getPhotoPath()));
            }
            catch (Exception ex)
            {
                pic2.Source = new BitmapImage(new Uri(@"C:\Users\Ahmad\Documents\WpfApp1\WpfApp1\unkown.png"));
                Console.WriteLine("Error loading file");
            }
            rating2.Source = new BitmapImage(new Uri(directory + "\\rating.png"));
            time2.Content = pool_info[2] + " on " + pool_info[4];
            dest2.Content = pool_info[3];

            //block 3
            if (my_pools[2] == null)
            {
                return;
            }
            pool_info = my_pools[2].Split('|');

            tmp_usr = new person(pool_info[0]);
            info3.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();

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
            time3.Content = pool_info[2] + " on " + pool_info[4];
            dest3.Content = pool_info[3];

            //block 4
            if (my_pools[3] == null)
            {
                return;
            }
            pool_info = my_pools[3].Split('|');

            tmp_usr = new person(pool_info[0]);
            info4.Content = tmp_usr.getFirstName() + ": " + tmp_usr.getBio();
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
            time4.Content = pool_info[2] + " on " + pool_info[4];
            dest4.Content = pool_info[3];

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page4(user.getEmail()));
        }

        private void profile_but_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page5(user.getEmail()));
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

        private void schedule_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page6(user.getEmail()));
        }

        private void rect21_Click(object sender, RoutedEventArgs e)
        {
            prompt_setup(0, "GIVE");

        }
        public void prompt_setup(int index, string find)
        {
            
            string[] my_pools = user.Load_pools(find);

            string[] pool_info = my_pools[index].Split('|');

            thePick = new person(pool_info[0]);

            promt_name.Content = thePick.getFirstName() + " " + thePick.getLastName();
            promt_dest.Content = "Dest: " + pool_info[3];
            promt_time.Content = pool_info[2] + " on " + pool_info[4];
            try
            {
                string directory = Directory.GetCurrentDirectory();
                promt_pic.Source = new BitmapImage(new Uri(directory + "\\" + thePick.getPhotoPath()));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not find file");
            }

            promt.Visibility = Visibility.Visible;
        }
        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            
            promt.Visibility = Visibility.Collapsed;
        }

        private void rect22_Click(object sender, RoutedEventArgs e)
        {
            prompt_setup(1, "GIVE");
        }

        private void rect23_Click(object sender, RoutedEventArgs e)
        {
            prompt_setup(2, "GIVE");
        }

        private void rect11_Click(object sender, RoutedEventArgs e)
        {
            prompt_setup(0, "GET");
        }

        private void rect12_Click(object sender, RoutedEventArgs e)
        {
            prompt_setup(1, "GET");
        }

        private void rect13_Click(object sender, RoutedEventArgs e)
        {
            prompt_setup(1, "GET");
        }

        private void promt_pic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page5(user.getEmail(), thePick.getEmail()));
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            promt.Visibility = Visibility.Collapsed;
        }
    }
}
