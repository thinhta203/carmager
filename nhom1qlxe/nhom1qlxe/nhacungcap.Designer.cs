namespace nhom1qlxe
{
    partial class nhacungcap
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
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgNhaCungCap = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lablesllncc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(493, 38);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(238, 22);
            this.txtemail.TabIndex = 78;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(493, -4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(238, 22);
            this.txtsdt.TabIndex = 77;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(154, 83);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(238, 22);
            this.txtdiachi.TabIndex = 76;
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(154, 38);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(238, 22);
            this.txttenncc.TabIndex = 75;
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(154, -4);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(238, 22);
            this.txtmancc.TabIndex = 74;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(637, 486);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(104, 38);
            this.btnthoat.TabIndex = 73;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(505, 486);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(104, 38);
            this.btnxoa.TabIndex = 72;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(381, 486);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(104, 38);
            this.btnsua.TabIndex = 71;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(258, 486);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(104, 38);
            this.btnthem.TabIndex = 70;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // dgNhaCungCap
            // 
            this.dgNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhaCungCap.Location = new System.Drawing.Point(65, 131);
            this.dgNhaCungCap.Name = "dgNhaCungCap";
            this.dgNhaCungCap.RowHeadersWidth = 51;
            this.dgNhaCungCap.RowTemplate.Height = 24;
            this.dgNhaCungCap.Size = new System.Drawing.Size(676, 332);
            this.dgNhaCungCap.TabIndex = 69;
            this.dgNhaCungCap.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgNhaCungCap_CellMouseClick_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tên NCC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã NCC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, -74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 32);
            this.label1.TabIndex = 63;
            this.label1.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 79;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lablesllncc
            // 
            this.lablesllncc.AutoSize = true;
            this.lablesllncc.Location = new System.Drawing.Point(12, 497);
            this.lablesllncc.Name = "lablesllncc";
            this.lablesllncc.Size = new System.Drawing.Size(160, 16);
            this.lablesllncc.TabIndex = 80;
            this.lablesllncc.Text = "Số Lượng Nhà Cung Cấp :";
            // 
            // nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.lablesllncc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttenncc);
            this.Controls.Add(this.txtmancc);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgNhaCungCap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "nhacungcap";
            this.Text = "nhacungcap";
            this.Load += new System.EventHandler(this.nhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgNhaCungCap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lablesllncc;
    }
}