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
    /// Interaction logic for Searsh_page.xaml
    /// </summary>
    public partial class Searsh_page : Page
    {
        profileEntities db= new profileEntities();
        public Searsh_page()
        {
            InitializeComponent();
            user us = new user();
            dg_name.ItemsSource = db.users.ToList();
               
              
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user us = new user();
           
            
                dg_name.ItemsSource = db.users.Where(x => x.city == City_txt.Text).ToList();
            
        }
    }
}
