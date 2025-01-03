namespace nhom1qlxe
{
    partial class hoadon
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
            this.dgHoaDon = new System.Windows.Forms.DataGridView();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txtngayhd = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(535, 466);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(104, 38);
            this.btnthoat.TabIndex = 89;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(403, 466);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(104, 38);
            this.btnxoa.TabIndex = 88;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(271, 466);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(104, 38);
            this.btnsua.TabIndex = 87;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(125, 466);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(104, 38);
            this.btnthem.TabIndex = 86;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // dgHoaDon
            // 
            this.dgHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHoaDon.Location = new System.Drawing.Point(68, 182);
            this.dgHoaDon.Name = "dgHoaDon";
            this.dgHoaDon.RowHeadersWidth = 51;
            this.dgHoaDon.RowTemplate.Height = 24;
            this.dgHoaDon.Size = new System.Drawing.Size(666, 278);
            this.dgHoaDon.TabIndex = 85;
            this.dgHoaDon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgHoaDon_CellMouseClick_1);
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(498, 135);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(238, 22);
            this.txtmanv.TabIndex = 84;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(498, 88);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(238, 22);
            this.txtmakh.TabIndex = 83;
            // 
            // txtngayhd
            // 
            this.txtngayhd.Location = new System.Drawing.Point(150, 135);
            this.txtngayhd.Name = "txtngayhd";
            this.txtngayhd.Size = new System.Drawing.Size(238, 22);
            this.txtngayhd.TabIndex = 82;
            // 
            // txtsohd
            // 
            this.txtsohd.Location = new System.Drawing.Point(150, 82);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(238, 22);
            this.txtsohd.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 80;
            this.label7.Text = "Mã NV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "Mã KH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Ngày HD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Số HD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 76;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(535, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 22);
            this.textBox1.TabIndex = 90;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 516);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgHoaDon);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.txtngayhd);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "hoadon";
            this.Text = "hoadon";
            this.Load += new System.EventHandler(this.hoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgHoaDon;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txtngayhd;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}