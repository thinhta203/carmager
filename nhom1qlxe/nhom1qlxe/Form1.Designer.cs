namespace nhom1qlxe
{
    partial class Form1
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
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.buttondangky = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(127, 21);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(210, 22);
            this.txttaikhoan.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(127, 73);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(210, 22);
            this.txtmatkhau.TabIndex = 7;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(32, 139);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(99, 38);
            this.btndangnhap.TabIndex = 8;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(194, 139);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(85, 38);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // buttondangky
            // 
            this.buttondangky.Location = new System.Drawing.Point(332, 139);
            this.buttondangky.Name = "buttondangky";
            this.buttondangky.Size = new System.Drawing.Size(75, 38);
            this.buttondangky.TabIndex = 10;
            this.buttondangky.Text = "Đăng Ký";
            this.buttondangky.UseVisualStyleBackColor = true;
            this.buttondangky.Click += new System.EventHandler(this.buttondangky_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nhom1qlxe.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 210);
            this.Controls.Add(this.buttondangky);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttaikhoan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button buttondangky;
    }
}

