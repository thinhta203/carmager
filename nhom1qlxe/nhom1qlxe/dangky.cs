using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom1qlxe
{
    public partial class dangky : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        public dangky()
        {
            InitializeComponent();
        }

        private void dangky_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chuoiKetNoi = @"Data Source=DESKTOP-93BAI9D;User ID=TOAN1;Password=110103;Unicode=True";
          
            string tenDangNhap = txtdangkytk.Text;
            string matKhau = txtdangkymk.Text;
            string id = idtxt.Text;


            if (DangKyTaiKhoan(chuoiKetNoi, tenDangNhap, matKhau, id))
            {
                MessageBox.Show("Đăng ký thành công!");
                // Thực hiện các hành động sau khi đăng ký thành công ở đây
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại.");
            }
        }

        

        private bool DangKyTaiKhoan(string chuoiKetNoi, string tenDangNhap, string matKhau, string id)
        {
            using (OracleConnection ketNoi = new OracleConnection(chuoiKetNoi))
            {
                try
                {
                    ketNoi.Open();

                    string truyVan = "INSERT INTO NGUOIDUNG (ID,TAIKHOAN, MATKHAU ) VALUES (:tenDangNhap, :matKhau, :ID)";
                    OracleCommand lenh = new OracleCommand(truyVan, ketNoi);
                    lenh.Parameters.Add(":tenDangNhap", OracleType.VarChar).Value = tenDangNhap;
                    lenh.Parameters.Add(":matKhau", OracleType.VarChar).Value = matKhau;
                    lenh.Parameters.Add(":ID", OracleType.VarChar).Value = id;

                    int ketQua = lenh.ExecuteNonQuery();

                    return ketQua > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
