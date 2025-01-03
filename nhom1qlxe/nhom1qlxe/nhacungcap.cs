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
    public partial class nhacungcap : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        public nhacungcap()
        {
            InitializeComponent();
        }

        private void nhacungcap_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
            NguonNCC();
        }
        public void NguonNCC()
        {
            sql = "select * from NCC";

            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            dgNhaCungCap.DataSource = dt;
            lablesllncc.Text = "Có " + (dgNhaCungCap.RowCount - 1) + "   NCCt";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //Khởi tạo
            
        }
        private void dgNhaCungCap_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int dong = e.RowIndex;

            txtmancc.Text = dgNhaCungCap.Rows[dong].Cells[0].Value.ToString();
            txttenncc.Text = dgNhaCungCap.Rows[dong].Cells[1].Value.ToString();
            txtdiachi.Text = dgNhaCungCap.Rows[dong].Cells[2].Value.ToString();
            txtsdt.Text = dgNhaCungCap.Rows[dong].Cells[3].Value.ToString();
            txtemail.Text = dgNhaCungCap.Rows[dong].Cells[4].Value.ToString();
        }

        private void dgNhaCungCap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        public void XoaTrang()
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
        }

        public bool TrungThem(string manhap)
        {
            sql = "select * from NCC where MANCC = '" + manhap + "'";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        

        

  

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            string MaNCC = txtmancc.Text;
            string TenNCC = txttenncc.Text;
            string DiaChi = txtdiachi.Text;
            string SDT = txtsdt.Text;
            string Email = txtemail.Text;

            if (TrungThem(txtmancc.Text) == true)
            {
                MessageBox.Show("Trùng Mã NCC", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            sql = "insert into NCC(MANCC, TENNCC, DIACHI, SDT, EMAIL) values ('" + txtmancc.Text + "', '" + txttenncc.Text
                + "','" + txtdiachi.Text + "', '" + txtsdt.Text + "', '" + txtemail.Text + "')";

            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonNCC();
            XoaTrang();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            sql = "update NCC" + " set TENNCC = '" + txttenncc.Text + "',  DIACHI = '" + txtdiachi.Text
                + "', SDT = '" + txtsdt.Text + "', EMAIL = '" + txtemail.Text + "' where MANCC = '" + txtmancc.Text + "' ";

            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonNCC();
            XoaTrang();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            sql = "delete from NCC where MANCC = '" + txtmancc.Text + "' ";
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonNCC();
            XoaTrang();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
            XoaTrang();
        }
        public void TimKiem()
        {
            string matim = textBox1.Text;
            sql = "select * from NCC where MANCC Like'%" + textBox1.Text + "%' or TENNCC Like'%" + textBox1.Text + "%'";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgNhaCungCap.DataSource = dt;
        }
    }
}

