using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ListWPF
{
    public partial class MainWindow : Window
    {
        List<int> dsDuLieu = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtGiaTri.Text, out int x))
            {
                dsDuLieu.Add(x);
                HienThiDanhSach();
                txtGiaTri.Text = "";
            }
        }

        void HienThiDanhSach()
        {
            lstDuLieu.Items.Clear();
            foreach (int x in dsDuLieu)
            {
                lstDuLieu.Items.Add(x);
            }
        }

        private void BtnChen_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtGiaTriChen.Text, out int x) &&
                int.TryParse(txtViTriChen.Text, out int vt) &&
                vt >= 0 && vt <= dsDuLieu.Count)
            {
                dsDuLieu.Insert(vt, x);
                HienThiDanhSach();
                txtViTriChen.Text = "";
                txtGiaTriChen.Text = "";
            }
        }

        private void BtnSapXepTang_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            HienThiDanhSach();
        }

        private void BtnSapXepGiam_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            dsDuLieu.Reverse();
            HienThiDanhSach();
        }

        private void BtnXoa1PhanTu_Click(object sender, RoutedEventArgs e)
        {
            if (lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần tử mới xóa được.", "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }

            dsDuLieu.RemoveAt(lstDuLieu.SelectedIndex);
            HienThiDanhSach();
        }

        private void BtnXoaNhieuPhanTu_Click(object sender, RoutedEventArgs e)
        {
            var itemsToRemove = new List<int>();
            foreach (int item in lstDuLieu.SelectedItems)
            {
                itemsToRemove.Add(item);
            }

            foreach (int item in itemsToRemove)
            {
                dsDuLieu.Remove(item);
            }

            HienThiDanhSach();
        }

        private void BtnXoaToanBoPhanTu_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Clear();
            HienThiDanhSach();
        }
    }
}
