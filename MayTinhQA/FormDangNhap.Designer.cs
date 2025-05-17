
namespace MayTinhQA
{
    partial class frmdangnhap
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
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.linkLabel_quenmk = new System.Windows.Forms.LinkLabel();
            this.linkLabel_dangki = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndangnhap
            // 
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.Navy;
            this.btndangnhap.Location = new System.Drawing.Point(117, 280);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(115, 38);
            this.btndangnhap.TabIndex = 2;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(100, 174);
            this.txttaikhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttaikhoan.Multiline = true;
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(184, 29);
            this.txttaikhoan.TabIndex = 4;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(100, 212);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmatkhau.Multiline = true;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(184, 29);
            this.txtmatkhau.TabIndex = 5;
            // 
            // linkLabel_quenmk
            // 
            this.linkLabel_quenmk.AutoSize = true;
            this.linkLabel_quenmk.Location = new System.Drawing.Point(46, 250);
            this.linkLabel_quenmk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_quenmk.Name = "linkLabel_quenmk";
            this.linkLabel_quenmk.Size = new System.Drawing.Size(86, 13);
            this.linkLabel_quenmk.TabIndex = 10;
            this.linkLabel_quenmk.TabStop = true;
            this.linkLabel_quenmk.Text = "Quên mật khẩu?";
            this.linkLabel_quenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_quenmk_LinkClicked);
            // 
            // linkLabel_dangki
            // 
            this.linkLabel_dangki.AutoSize = true;
            this.linkLabel_dangki.Location = new System.Drawing.Point(241, 250);
            this.linkLabel_dangki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_dangki.Name = "linkLabel_dangki";
            this.linkLabel_dangki.Size = new System.Drawing.Size(46, 13);
            this.linkLabel_dangki.TabIndex = 11;
            this.linkLabel_dangki.TabStop = true;
            this.linkLabel_dangki.Text = "Đăng kí";
            this.linkLabel_dangki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_dangki_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MayTinhQA.Properties.Resources.pass_icon;
            this.pictureBox3.Location = new System.Drawing.Point(49, 212);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MayTinhQA.Properties.Resources.user_icon;
            this.pictureBox2.Location = new System.Drawing.Point(49, 174);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MayTinhQA.Properties.Resources.login_icon;
            this.pictureBox1.Location = new System.Drawing.Point(49, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 333);
            this.Controls.Add(this.linkLabel_dangki);
            this.Controls.Add(this.linkLabel_quenmk);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.btndangnhap);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmdangnhap";
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel_quenmk;
        private System.Windows.Forms.LinkLabel linkLabel_dangki;
    }
}