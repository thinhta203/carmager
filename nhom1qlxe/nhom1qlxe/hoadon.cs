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
    public partial class hoadon : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        public hoadon()
        {
            InitializeComponent();
        }

        private void hoadon_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
            NguonHoaDon();
        }

        public void NguonHoaDon()
        {
            sql = "select * from HOADON";

            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            dgHoaDon.DataSource = dt;
        }
        private void dgHoaDon_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
                int dong = e.RowIndex;

                txtsohd.Text = dgHoaDon.Rows[dong].Cells[0].Value.ToString();
                txtngayhd.Text = dgHoaDon.Rows[dong].Cells[1].Value.ToString();
                txtmakh.Text = dgHoaDon.Rows[dong].Cells[2].Value.ToString();
                txtmanv.Text = dgHoaDon.Rows[dong].Cells[3].Value.ToString();
        }

        private void dgHoaDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
           
        }

        public void XoaTrang()
        {
            txtsohd.Text = "";
            txtngayhd.Text = "";
            txtmakh.Text = "";
            txtmanv.Text = "";
        }

        public bool TrungThem(string manhap)
        {
            sql = "select * from HOADON where SOHD = '" + manhap + "'";
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            
            string SoHD = txtsohd.Text;
            string NgayHD = txtngayhd.Text;
            string MaKH = txtmakh.Text;
            string MaNV = txtmanv.Text;

           
            if (TrungThem(txtsohd.Text) == true)
            {
                MessageBox.Show("Trùng Số Hóa Đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

          
            sql = "insert into HOADON(SOHD, NGAYHD, MAKH, MANV) values ('" + txtsohd.Text + "', to_date('" + txtngayhd.Text
                + "','DD/MM/YYYY'),'" + txtmakh.Text + "', '" + txtmanv.Text + "')";


            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonHoaDon();
            XoaTrang();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            sql = "update HOADON" + " set NGAYHD = to_date('" + txtngayhd.Text + "','DD/MM/YYYY'),  MAKH = '" + txtmakh.Text
              + "', MANV = '" + txtmanv.Text + "' where SOHD = '" + txtsohd.Text + "' ";

            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonHoaDon();
            XoaTrang();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            sql = "delete from HOADON where SOHD = '" + txtsohd.Text + "' ";
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonHoaDon();
            XoaTrang();
        }

      

        public void TimKiem()
        {
            string matim = textBox1.Text;
            sql = "select * from HOADON where SOHD Like'%" + textBox1.Text + "%' or MAKH Like'%" + textBox1.Text + "%'";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgHoaDon.DataSource = dt;
        }
          private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
            XoaTrang();
        }
       
    }
}
