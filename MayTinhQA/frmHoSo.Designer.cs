
namespace MayTinhQA
{
    partial class frmHoSo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttennguoidung = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(67, 120);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(119, 20);
            this.lblTenNhanVien.TabIndex = 1;
            this.lblTenNhanVien.Text = "Tên người dùng";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(192, 245);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(90, 54);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Location = new System.Drawing.Point(67, 162);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(48, 20);
            this.lblVaiTro.TabIndex = 3;
            this.lblVaiTro.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chức vụ";
            // 
            // txttennguoidung
            // 
            this.txttennguoidung.Location = new System.Drawing.Point(192, 117);
            this.txttennguoidung.Name = "txttennguoidung";
            this.txttennguoidung.Size = new System.Drawing.Size(247, 26);
            this.txttennguoidung.TabIndex = 7;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(192, 201);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(247, 26);
            this.txtchucvu.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(192, 159);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(247, 26);
            this.txtemail.TabIndex = 10;
            // 
            // frmHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 371);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtchucvu);
            this.Controls.Add(this.txttennguoidung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblVaiTro);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "frmHoSo";
            this.Text = "HỒ SƠ";
            this.Load += new System.EventHandler(this.frmHoSo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttennguoidung;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txtemail;
    }
}