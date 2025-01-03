using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom1qlxe
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnthongkhachhang_Click(object sender, EventArgs e)
        {
            khachhang khachhang = new khachhang();
            khachhang.Show();
        }

        private void btnThongtinnhanvien_Click(object sender, EventArgs e)
        {
            nhanvien nhanvien = new nhanvien();
            nhanvien.Show();
        }

        private void btnthongtinxemay_Click(object sender, EventArgs e)
        {
            Xemay xemay = new Xemay();
            xemay.Show();
        }

        private void btnncc_Click(object sender, EventArgs e)
        {
            nhacungcap nhacungcap = new nhacungcap();
            nhacungcap.Show();
        }

        private void btnthongtinhoadon_Click(object sender, EventArgs e)
        {
            hoadon hoadon = new hoadon();
            hoadon.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Thanhtoan thanhtoan = new Thanhtoan();
            thanhtoan.Show();
        }

        private void btnquanly_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
