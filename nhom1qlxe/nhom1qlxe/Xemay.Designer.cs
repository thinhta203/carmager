namespace nhom1qlxe
{
    partial class Xemay
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
            this.dgXeMay = new System.Windows.Forms.DataGridView();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txttenxe = new System.Windows.Forms.TextBox();
            this.txtmaxe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbbxemay = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgXeMay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(499, 459);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(104, 38);
            this.btnthoat.TabIndex = 58;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(389, 459);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(104, 38);
            this.btnxoa.TabIndex = 57;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(279, 459);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(104, 38);
            this.btnsua.TabIndex = 56;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(169, 459);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(104, 38);
            this.btnthem.TabIndex = 55;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // dgXeMay
            // 
            this.dgXeMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgXeMay.Location = new System.Drawing.Point(64, 193);
            this.dgXeMay.Name = "dgXeMay";
            this.dgXeMay.RowHeadersWidth = 51;
            this.dgXeMay.RowTemplate.Height = 24;
            this.dgXeMay.Size = new System.Drawing.Size(677, 260);
            this.dgXeMay.TabIndex = 54;
            this.dgXeMay.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgXeMay_CellMouseClick_1);
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(508, 77);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(233, 22);
            this.txtgia.TabIndex = 53;
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(508, 35);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(233, 22);
            this.txtmancc.TabIndex = 52;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(153, 122);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(233, 22);
            this.txtsoluong.TabIndex = 51;
            // 
            // txttenxe
            // 
            this.txttenxe.Location = new System.Drawing.Point(153, 77);
            this.txttenxe.Name = "txttenxe";
            this.txttenxe.Size = new System.Drawing.Size(233, 22);
            this.txttenxe.TabIndex = 50;
            // 
            // txtmaxe
            // 
            this.txtmaxe.Location = new System.Drawing.Point(153, 35);
            this.txtmaxe.Name = "txtmaxe";
            this.txtmaxe.Size = new System.Drawing.Size(233, 22);
            this.txtmaxe.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Mã NCC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tên Xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mã Xe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, -46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "QUẢN LÝ XE MÁY";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(531, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 59;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbbxemay
            // 
            this.cbbxemay.FormattingEnabled = true;
            this.cbbxemay.Location = new System.Drawing.Point(0, 0);
            this.cbbxemay.Name = "cbbxemay";
            this.cbbxemay.Size = new System.Drawing.Size(121, 24);
            this.cbbxemay.TabIndex = 60;
            this.cbbxemay.SelectedIndexChanged += new System.EventHandler(this.cbbxemay_SelectedIndexChanged);
            // 
            // Xemay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.cbbxemay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgXeMay);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtmancc);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txttenxe);
            this.Controls.Add(this.txtmaxe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Xemay";
            this.Text = "Xemay";
            this.Load += new System.EventHandler(this.Xemay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgXeMay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgXeMay;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txttenxe;
        private System.Windows.Forms.TextBox txtmaxe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbbxemay;
    }
}