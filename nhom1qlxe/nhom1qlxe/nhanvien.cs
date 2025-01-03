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
    public partial class nhanvien : Form
    {

        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";

        public nhanvien()
        {
            InitializeComponent();
        }

        private void nhanvien_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
            NhanVien();
        }

        public void NhanVien()
        {
            sql = "select * from NHANVIEN";
            //Khởi taoj
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            //Đẩy data
            dgNhanVien.DataSource = dt;
            lbdemnhanvien.Text = "Có " + (dgNhanVien.RowCount - 1) + "   Nhân Viên";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
        private void dgNhanVien_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int dong = e.RowIndex;

            //gán data cho textbox
            txtmanv.Text = dgNhanVien.Rows[dong].Cells[0].Value.ToString();
            txthoten.Text = dgNhanVien.Rows[dong].Cells[1].Value.ToString();
            txtngaysinh.Text = dgNhanVien.Rows[dong].Cells[2].Value.ToString();
            txtgioitinh.Text = dgNhanVien.Rows[dong].Cells[3].Value.ToString();
            txtquequan.Text = dgNhanVien.Rows[dong].Cells[4].Value.ToString();
            txtcmnd.Text = dgNhanVien.Rows[dong].Cells[5].Value.ToString();
            txtsdt.Text = dgNhanVien.Rows[dong].Cells[6].Value.ToString();
        }

      

        public void XoaTrang()
        {
            txtmanv.Text = "";
            txthoten.Text = "";
            txtngaysinh.Text = "";
            txtgioitinh.Text = "";
            txtquequan.Text = "";
            txtcmnd.Text = "";
            txtsdt.Text = "";
        }

        public bool TrungThem(string manhap)
        {
            sql = "select * from NHANVIEN where MANV = '" + manhap + "'";
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
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            string MaNV = txtmanv.Text;
            string HoTen = txthoten.Text;
            string NgaySinh = txtngaysinh.Text;
            string GioiTinh = txtgioitinh.Text;
            string QueQuan = txtquequan.Text;
            string Cmnd = txtcmnd.Text;
            string Sdt = txtsdt.Text;

            //SV trùng
            if (TrungThem(txtmanv.Text) == true)
            {
                MessageBox.Show("Trùng Mã Nhân Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Thêm data
            sql = "insert into NHANVIEN(MANV, HOTEN, NGAYSINH, GIOITINH, QUEQUAN, CMND, SDT) values ('" + txtmanv.Text + "', '" + txthoten.Text
                + "', '" + txtngaysinh.Text + "', '" + txtgioitinh.Text + "', '" + txtquequan.Text
                + "', '" + txtcmnd.Text + "', '" + txtsdt.Text + "')";


            //Kiểm tra kết nối
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NhanVien();
            XoaTrang();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            sql = "update NHANVIEN" + " set HOTEN = '" + txthoten.Text + "',  NGAYSINH ='" + txtngaysinh.Text
                + "', GIOITINH = '" + txtgioitinh.Text + "', QUEQUAN = '" + txtquequan.Text
                + "', CMND = '" + txtcmnd.Text + "', SDT = '" + txtsdt.Text + "' where MANV = '" + txtmanv.Text + "' ";

            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NhanVien();
            XoaTrang();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            sql = "delete from NHANVIEN where MANV = '" + txtmanv.Text + "' ";
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NhanVien();
            XoaTrang();
        }

        private void txtdemsonv_TextChanged(object sender, EventArgs e)
        {
            
            sql = "select count(*) from NHANVIEN'%";
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void lbdemnhanvien_Click(object sender, EventArgs e)
        {

        }
        public void TimKiem()
        {
            string matim = textBox1.Text;
            sql = "select * from NHANVIEN where MANV Like'%" + textBox1.Text + "%' or HOTEN Like'%" + textBox1.Text + "%'";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgNhanVien.DataSource = dt;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
            XoaTrang();
        }

        private void dgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

