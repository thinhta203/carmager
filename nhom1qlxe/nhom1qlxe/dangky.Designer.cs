namespace nhom1qlxe
{
    partial class dangky
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
            this.txtdangkymk = new System.Windows.Forms.TextBox();
            this.txtdangkytk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdangkymk
            // 
            this.txtdangkymk.Location = new System.Drawing.Point(96, 60);
            this.txtdangkymk.Name = "txtdangkymk";
            this.txtdangkymk.Size = new System.Drawing.Size(100, 22);
            this.txtdangkymk.TabIndex = 0;
            // 
            // txtdangkytk
            // 
            this.txtdangkytk.Location = new System.Drawing.Point(97, 9);
            this.txtdangkytk.Name = "txtdangkytk";
            this.txtdangkytk.Size = new System.Drawing.Size(100, 22);
            this.txtdangkytk.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đăng Ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(97, 102);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 22);
            this.idtxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nhom1qlxe.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(310, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.txtdangkytk);
            this.Controls.Add(this.txtdangkymk);
            this.Name = "dangky";
            this.Text = "dangky";
            this.Load += new System.EventHandler(this.dangky_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdangkymk;
        private System.Windows.Forms.TextBox txtdangkytk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}