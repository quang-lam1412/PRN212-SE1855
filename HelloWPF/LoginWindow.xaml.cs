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

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //ta giả đò làm đăn nhập 
            //nếu thành công thì vào mainwindow
            //nếu thất bại thì thông báo failed
            if (txtUserName.Text == "Lam" &&
                txtPassword.Text == "1412")
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
