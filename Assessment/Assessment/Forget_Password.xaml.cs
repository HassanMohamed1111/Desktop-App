using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Forget_Password.xaml
    /// </summary>
    public partial class Forget_Password : Page
    {
        profileEntities db = new profileEntities();
        public Forget_Password()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user us = new user();
            int ph = int.Parse(phone_txt.Text);
            us = db.users.FirstOrDefault(x => x.phone_number == ph);
            us.passwordd = newpass.Password;
            if (conf_txt.Password == newpass.Password)
            {
                db.users.AddOrUpdate(us);
                db.SaveChanges();
                MessageBox.Show("Password Updated Succ");
            }
            else
                MessageBox.Show("Invalid");
         
        }
    }
}
