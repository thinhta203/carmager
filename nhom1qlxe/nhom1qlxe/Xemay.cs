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
    public partial class Xemay : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        public Xemay()
        {
            InitializeComponent();
        }

        private void Xemay_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.connectDB();
            NguonCB();
            NguonXeMay();
        }
        public void NguonXeMay()
        {
            sql = "SELECT * FROM XEMAY " + "WHERE MANCC = '" + cbbxemay.SelectedValue.ToString() + "'";

            //Khởi taoj
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            //Đẩy data
            dgXeMay.DataSource = dt;
           
        }
        public void NguonCB()
        {
            sql = "select * from NCC";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            cbbxemay.DataSource = dt;
            cbbxemay.DisplayMember = "TENNCC";
            cbbxemay.ValueMember = "MANCC";
        }



        private void frmQuanLyXeMay_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void dgXeMay_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int dong = e.RowIndex;

            txtmaxe.Text = dgXeMay.Rows[dong].Cells[0].Value.ToString();
            txttenxe.Text = dgXeMay.Rows[dong].Cells[1].Value.ToString();
            txtsoluong.Text = dgXeMay.Rows[dong].Cells[2].Value.ToString();
            txtmancc.Text = dgXeMay.Rows[dong].Cells[3].Value.ToString();
            txtgia.Text = dgXeMay.Rows[dong].Cells[4].Value.ToString();
        }

        private void dgXeMay_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        public void XoaTrang()
        {
            txtmaxe.Text = "";
            txttenxe.Text = "";
            txtsoluong.Text = "";
            txtmancc.Text = "";
            txtgia.Text = "";
        }

        public bool TrungThem(string manhap)
        {
            sql = "select * from XEMAY where MAXE = '" + manhap + "'";
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
            string MaXe = txtmaxe.Text;
            string TenXe = txttenxe.Text;
            string SoLuong = txtsoluong.Text;
            string MaNCC = txtmancc.Text;
            string Gia = txtgia.Text;

            //SV trùng
            if (TrungThem(txtmaxe.Text) == true)
            {
                MessageBox.Show("Trùng Mã Xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Thêm data
            sql = "insert into XEMAY(MAXE, TENXE, SOLUONG, MANCC, GIA) values ('" + txtmaxe.Text + "', '" + txttenxe.Text
                + "','" + txtsoluong.Text + "', '" + txtmancc.Text + "', '" + txtgia.Text + "')";


            //Kiểm tra kết nối
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonXeMay();
            XoaTrang();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            sql = "update XEMAY" + " set TENXE = '" + txttenxe.Text + "',  SOLUONG = '" + txtsoluong.Text
                + "', MANCC = '" + txtmancc.Text + "', GIA = '" + txtgia.Text + "' where MAXE = '" + txtmaxe.Text + "' ";

            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonXeMay();
            XoaTrang();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            sql = "delete from XEMAY where MAXE = '" + txtmaxe.Text + "' ";
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd = new OracleCommand(sql, conn);
            cmd.ExecuteNonQuery();
            NguonXeMay();
            XoaTrang();
        }
        public void TimKiem()
        {
            string matim = textBox1.Text;
            sql = "select * from XEMAY where MAXE Like'%" + textBox1.Text + "%' or TENXE Like'%" + textBox1.Text + "%'";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgXeMay.DataSource = dt;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
            XoaTrang();
        }

        private void cbbxemay_SelectedIndexChanged(object sender, EventArgs e)
        {
            NguonXeMay();
        }
    }
}
