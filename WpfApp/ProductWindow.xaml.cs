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
using System.Windows.Shapes;
using BusinessObject;
using Services;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        ProductService productService = new ProductService();
        public ProductWindow()
        {
            InitializeComponent();
            DisplayProducts();
        }
        private void DisplayProducts()
        {
            productService.GenerateSampleData();
            elvProduct.ItemsSource = productService.GetProducts();


        }

        private void elvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void txtAdd_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Bạn muốn thêm sản phẩm mới?");
            Product p = new Product();
            p.Id = int.Parse(txtProduct.Text);
            p.Name = txtName.Text;
            p.Quantity = int.Parse(txtQuantity.Text);
            p.Price = double.Parse(txtPrice.Text);

            bool ret = productService.SaveProduct(p);
            if (ret)
            {
                elvProduct.ItemsSource = null; // Clear the current items source
                elvProduct.ItemsSource = productService.GetProducts(); // Refresh the list view

            }
            else
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm mới!");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
