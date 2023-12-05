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

namespace Assessment
{
    /// <summary>
    /// Interaction logic for Profile_page.xaml
    /// </summary>
    public partial class Profile_page : Page
    {
        profileEntities db = new profileEntities();
        public Profile_page(string name )
        {
            InitializeComponent();
            dg_name.ItemsSource = db.users.Where(x=>x.user_namee==name).ToList();
            user us = new user();
            Profile_.Content="Profile " + name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sign_in ss = new Sign_in();
            this.NavigationService.Navigate(ss);
        }

        private void User_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
