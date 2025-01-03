namespace nhom1qlxe
{
    partial class Thanhtoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgThanhToan = new System.Windows.Forms.DataGridView();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmaxe = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(508, 445);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(104, 38);
            this.btnthoat.TabIndex = 97;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(398, 445);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(104, 38);
            this.btnxoa.TabIndex = 96;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(288, 445);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(104, 38);
            this.btnsua.TabIndex = 95;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(178, 445);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(104, 38);
            this.btnthem.TabIndex = 94;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // dgThanhToan
            // 
            this.dgThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgThanhToan.Location = new System.Drawing.Point(57, 172);
            this.dgThanhToan.Name = "dgThanhToan";
            this.dgThanhToan.RowHeadersWidth = 51;
            this.dgThanhToan.RowTemplate.Height = 24;
            this.dgThanhToan.Size = new System.Drawing.Size(689, 255);
            this.dgThanhToan.TabIndex = 93;
            this.dgThanhToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgThanhToan_CellContentClick);
            this.dgThanhToan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgThanhToan_CellMouseClick_1);
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(508, 75);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(238, 22);
            this.txtthanhtien.TabIndex = 92;
            this.txtthanhtien.TextChanged += new System.EventHandler(this.txtthanhtien_TextChanged);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(508, 33);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(238, 22);
            this.txtsoluong.TabIndex = 91;
            // 
            // txtmaxe
            // 
            this.txtmaxe.Location = new System.Drawing.Point(148, 75);
            this.txtmaxe.Name = "txtmaxe";
            this.txtmaxe.Size = new System.Drawing.Size(238, 22);
            this.txtmaxe.TabIndex = 90;
            // 
            // txtsohd
            // 
            this.txtsohd.Location = new System.Drawing.Point(148, 33);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(238, 22);
            this.txtsohd.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 88;
            this.label7.Text = "Thành Tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 87;
            this.label6.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 86;
            this.label3.Text = "Mã Xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 85;
            this.label2.Text = "Số HD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, -32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 84;
            this.label1.Text = "THANH TOÁN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(478, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 98;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgThanhToan);
            this.Controls.Add(this.txtthanhtien);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtmaxe);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Thanhtoan";
            this.Text = "Thanhtoan";
            this.Load += new System.EventHandler(this.Thanhtoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgThanhToan;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtmaxe;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}