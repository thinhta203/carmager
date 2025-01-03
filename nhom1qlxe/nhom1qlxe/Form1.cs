using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nhom1qlxe
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)

        {


            string chuoiKetNoi = @"Data Source=DESKTOP-93BAI9D;User ID=TOAN1;Password=110103;Unicode=True";
            string tenDangNhap = txttaikhoan.Text;
            string matKhau = txtmatkhau.Text;

            if (LaTaiKhoanHopLe(chuoiKetNoi, tenDangNhap, matKhau))
            {
                Home Home = new Home();
                Home.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }
        private bool LaTaiKhoanHopLe(string chuoiKetNoi, string tenDangNhap, string matKhau)
        {
            using (OracleConnection ketNoi = new OracleConnection(chuoiKetNoi))
            {
                try
                {
                    ketNoi.Open();

                    string truyVan = "SELECT COUNT(*) FROM NGUOIDUNG WHERE TAIKHOAN = :tenDangNhap AND MATKHAU = :matKhau";
                    OracleCommand lenh = new OracleCommand(truyVan, ketNoi);
                    lenh.Parameters.Add(":tenDangNhap", OracleType.VarChar).Value = tenDangNhap;
                    lenh.Parameters.Add(":matKhau", OracleType.VarChar).Value = matKhau;

                    int dem = Convert.ToInt32(lenh.ExecuteScalar());

                    return dem > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
        }

        private void buttondangky_Click(object sender, EventArgs e)
        {
            dangky dangky = new dangky();
            dangky.Show();
        }
    }
}
