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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private order _currentOrder = new order();
        public AddEditPage(order selectedOrder)
        {
            if(selectedOrder != null)
            {
                _currentOrder = selectedOrder;
            }
            InitializeComponent();
            DataContext = _currentOrder;
            cb.ItemsSource = bakeryEntities.GetContext().seller.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentOrder.product))
                errors.AppendLine("No product");
            if (string.IsNullOrWhiteSpace(_currentOrder.amount))
                errors.AppendLine("No amount");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
            }
            else
            {
                bakeryEntities.GetContext().order.Add(_currentOrder); //добавление данных
            }
            try
            {
                bakeryEntities.GetContext().SaveChanges();
                NavigationService.GoBack();
            }
            catch(Exception ex) { 
            MessageBox.Show(ex.ToString()); 
            }
        }
    }
}
