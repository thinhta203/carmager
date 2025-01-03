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
    public partial class Thanhtoan : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        public Thanhtoan()
        {
            InitializeComponent();
        }

        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
            NguonThanhToan();
        }
        public void NguonThanhToan()
        {
            sql = "select * from CTHOADON";

            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            dgThanhToan.DataSource = dt;
        }
        private void dgThanhToan_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int dong = e.RowIndex;

            txtsohd.Text = dgThanhToan.Rows[dong].Cells[0].Value.ToString();
            txtmaxe.Text = dgThanhToan.Rows[dong].Cells[1].Value.ToString();
            txtsoluong.Text = dgThanhToan.Rows[dong].Cells[2].Value.ToString();
            txtthanhtien.Text = dgThanhToan.Rows[dong].Cells[3].Value.ToString();
        }
        private void dgThanhToan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

      

        public void XoaTrang()
        {
            txtsohd.Text = "";
            txtmaxe.Text = "";
            txtsoluong.Text = "";
            txtthanhtien.Text = "";
        }

        public bool TrungThem(string manhap)
        {
            sql = "select * from CTHOADON where SOHD = '" + manhap + "'";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

     
        

        private void btnxoa_Click(object sender, EventArgs e)
        {
            sql = "delete from CTHOADON where SOHD = '" + txtsohd.Text + "' ";
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonThanhToan();
            XoaTrang();
        }

        

        private void txtthanhtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            //Khởi tạo
            string SoHD = txtsohd.Text;
            string MaXe = txtmaxe.Text;
            string SoLuong = txtsoluong.Text;
            string ThanhTien = txtthanhtien.Text;

            //SV trùng
            if (TrungThem(txtsohd.Text) == true)
            {
                MessageBox.Show("Trùng Số Hóa Đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Thêm data
            sql = "insert into CTHOADON(SOHD, MAXE, SOLUONG, THANHTIEN) values ('" + txtsohd.Text + "', '" + txtmaxe.Text
                + "','" + txtsoluong.Text + "', '" + txtthanhtien.Text + "')";


            //Kiểm tra kết nối
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonThanhToan();
            XoaTrang();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            sql = "update CTHOADON" + " set MAXE = '" + txtmaxe.Text + "',  SOLUONG = '" + txtsoluong.Text
                + "', THANHTIEN = '" + txtthanhtien.Text + "' where SOHD = '" + txtsohd.Text + "' ";

            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonThanhToan();
            XoaTrang();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            sql = "delete from CTHOADON where SOHD = '" + txtsohd.Text + "' ";
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonThanhToan();
            XoaTrang();
        }
        public void TimKiem()
        {
            string matim = textBox1.Text;
            sql = "select * from CTHOADON where MANV SOHD'%" + textBox1.Text + "%' or MAXE Like'%" + textBox1.Text + "%'";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgThanhToan.DataSource = dt;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
            XoaTrang();
        }
    }
}
