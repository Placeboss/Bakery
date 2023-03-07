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

namespace Bakery
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        bakeryEntities bakery;
        public AuthPage()
        {
            bakery = new bakeryEntities();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (loginTB.Text == "" || passTB.Text == "")
            {
                MessageBox.Show("INput all boxes");
                return;
            }
            if (bakery.user.Select(x => x.login + " " + x.pass + " " + x.type).Contains(loginTB.Text + " " + passTB.Text + " " + "админ"))
            {
                NavigationService.Navigate(new AdminPage());
                return;
            }
        }
    }
}
