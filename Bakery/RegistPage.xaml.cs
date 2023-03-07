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
    /// Логика взаимодействия для RegistPage.xaml
    /// </summary>
    public partial class RegistPage : Page
    {
        bakeryEntities bakery = new bakeryEntities();
        public RegistPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTB.Text == "" || PassTB.Text == "" || NameTB.Text == "")
            {
                MessageBox.Show("Error");
            }
            if(bakery.user.Select(x=>x.name + " " + x.login + " " + x.pass).Contains(NameTB.Text + " " + LoginTB.Text + " " + PassTB.Text)){
                MessageBox.Show("This user already exists");
            }
            else
            {
                user newUser = new user()
                {
                    name = NameTB.Text,
                    login = LoginTB.Text,
                    pass = NameTB.Text,
                    type = "пользователь"
                };
                bakery.user.Add(newUser);
                bakery.SaveChanges();
                MessageBox.Show("Success");
            }
        }
    }
}
