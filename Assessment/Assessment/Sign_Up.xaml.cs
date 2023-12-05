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
    /// Interaction logic for Sign_Up.xaml
    /// </summary>
    public partial class Sign_Up : Page
    {
        string Gender;
        profileEntities db = new profileEntities();
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (IsValid(pass_txt.Password))
            {
                int gg = int.Parse(Age_txt.Text);
                if (Phonew_txt.Text.Length == 11 &&gg>=18 && gg<=60 )
                {
                    user us = new user();
                    us.passwordd = pass_txt.Password;
                    us.Age = int.Parse(Age_txt.Text);
                    us.phone_number = int.Parse(Phonew_txt.Text);
                    us.Gender = Gender;
                    us.city = Comp_txt.Text;
                    us.user_namee = usern_txt.Text;
                    db.users.Add(us);
                    db.SaveChanges();
                    MessageBox.Show("Added succ");
                }
                else
                    MessageBox.Show("the phone number shoud contain 11 and Age should 18 to 60");
            }
            else
                MessageBox.Show("The password should contain upper , lower , num , spatitielchar");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Gender = "Male";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Gender = "Female";
        }

        private void Button_Click_1(object sender, object e)
        {
            Sign_in ss = new Sign_in();
            this.NavigationService.Navigate(ss);
        }
        bool IsValid(string pass)
        {
            bool upper, lower, num, symbole;
            upper = lower = num = symbole = false;
            string spatitiel = "!@#$%^&*()";
            foreach (char c in pass)
            {
                if(c>='A' && c <= 'Z')
                {
                    upper = true;
                }
               else if (c >= 'a' && c <= 'z')
                {
                    lower = true;
                }
                else if (c >= '0' && c <= '9')
                {
                    num = true;
                }
                else if (spatitiel.Contains(c))
                {
                    symbole = true;
                }
            }
            return upper && lower && num && symbole;
        }
    }
}
