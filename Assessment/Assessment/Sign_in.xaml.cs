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
    /// Interaction logic for Sign_in.xaml
    /// </summary>
    public partial class Sign_in : Page
    {
        profileEntities db = new profileEntities();
        public Sign_in()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Comb_name.Text == "User")
            {
                if (user_txt.Text != "" && pass_txt.Password != "")
                {
                    user us = new user();

                    us = db.users.FirstOrDefault(x => x.user_namee == user_txt.Text);

                    if (us.passwordd == pass_txt.Password)
                    {
                        string name = user_txt.Text;
                        Profile_page pp = new Profile_page(name);
                        this.NavigationService.Navigate(pp);
                    }
                    else
                        MessageBox.Show("please write the password correct");
                }
                else
                    MessageBox.Show("Please enter the user name and pasword");
            }
            else if (Comb_name.Text=="Admin")
            {
                if (user_txt.Text != "" && pass_txt.Password != "")
                {
                    Adminn us = new Adminn();

                    us = db.Adminns.FirstOrDefault(x => x.Admin_username == user_txt.Text);

                    if (us.Adminn_password == pass_txt.Password)
                    {
                       Delete_AdminPage de = new Delete_AdminPage();
                        this.NavigationService.Navigate(de);
                    }
                    else
                        MessageBox.Show("please write the password correct");
                }
                else
                    MessageBox.Show("Please enter the user name and pasword");
            }
           
         
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Forget_Password ll = new Forget_Password();
            this.NavigationService.Navigate(ll);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Sign_Up up = new Sign_Up(); 
            this.NavigationService.Navigate(up);
        }
    }
}
