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
    /// Interaction logic for Delete_AdminPage.xaml
    /// </summary>
    public partial class Delete_AdminPage : Page
    {
        profileEntities db = new profileEntities();
        public Delete_AdminPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Searsh_page ss = new Searsh_page();
            this.NavigationService.Navigate(ss);    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            user us = new user();
            int dd = int.Parse(phone_txt.Text);
            us = db.users.FirstOrDefault(x => x.phone_number ==dd);
            us.phone_number = dd;
            db.users.Remove(us);
            db.SaveChanges();
            MessageBox.Show("Record Deleted");
        }
    }
}
