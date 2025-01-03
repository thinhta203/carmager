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
    public partial class khachhang : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        public khachhang()
        {
            InitializeComponent();
        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
            KhachHang();

            
        }

        public void KhachHang()
        {

            sql = "SELECT * FROM KHACHHANG ";

            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
           
            dgThongTinKhachHang.DataSource = dt;
            sokhachhang.Text = "Có " + (dgThongTinKhachHang.RowCount - 1) + "   Khách hàng";
        }
        

        private void dgThongTinKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string MaKH = txtmakh.Text;
            string HoTen = txthoten.Text;
            string GioiTinh = txtgioitinh.Text;
            string DiaChi = txtdiachi.Text;
            string SDT = txtsdt.Text;
            string GhiChu = txtghichu.Text;

         
            if (TrungThem(txtmakh.Text) == true)
            {
                MessageBox.Show("Trùng Mã Khách Hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

          
            sql = "insert into KHACHHANG(MAKH, HOTEN, GIOITINH, DIACHI, SDT, GHICHU) values ('" + txtmakh.Text + "', '" + txthoten.Text
                + "','" + txtgioitinh.Text + "', '" + txtdiachi.Text + "', '" + txtsdt.Text + "', '" + txtghichu.Text + "')";


            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            KhachHang();
            XoaTrang();


        }
        public void XoaTrang()
        {
            txtmakh.Text = "";
            txthoten.Text = "";
            txtgioitinh.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtghichu.Text = "";
        }
        //sua
        public bool TrungThem(string manhap)
        {
            sql = "select * from KHACHHANG where MAKH = '" + manhap + "'";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            sql = "update KHACHHANG" + " set HOTEN = '" + txthoten.Text + "',  GIOITINH = '" + txtgioitinh.Text
                + "', DIACHI = '" + txtdiachi.Text + "', SDT = '" + txtsdt.Text + "', GHICHU = '" + txtghichu.Text
                + "' where MAKH = '" + txtmakh.Text + "' ";

            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            KhachHang();
            XoaTrang();
        }

       

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        public void TimKiem()
        {
            string matim = txttimkiem.Text;
            sql = "select * from KHACHHANG where MAKH Like'%" + txttimkiem.Text + "%' or HOTEN Like'%" + txttimkiem.Text + "%'";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgThongTinKhachHang.DataSource = dt;
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
            XoaTrang();
        }

        private void dgThongTinKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgThongTinKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int dong = e.RowIndex;
            
            txtmakh.Text = dgThongTinKhachHang.Rows[dong].Cells[0].Value.ToString();
            txthoten.Text = dgThongTinKhachHang.Rows[dong].Cells[1].Value.ToString();
            txtgioitinh.Text = dgThongTinKhachHang.Rows[dong].Cells[2].Value.ToString();
            txtdiachi.Text = dgThongTinKhachHang.Rows[dong].Cells[3].Value.ToString();
            txtsdt.Text = dgThongTinKhachHang.Rows[dong].Cells[4].Value.ToString();
            txtghichu.Text = dgThongTinKhachHang.Rows[dong].Cells[5].Value.ToString();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            sql = "delete from KHACHHANG where MAKH = '" + txtmakh.Text + "' ";
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            KhachHang();
            XoaTrang();
        }
      
        private void cbbkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            KhachHang();
            
        }
    }
}
