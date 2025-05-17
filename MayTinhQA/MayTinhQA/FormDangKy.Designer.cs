
namespace MayTinhQA
{
    partial class frmdangki
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttentaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau_dk = new System.Windows.Forms.TextBox();
            this.txtxacnhanmk = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btndangki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(81, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(81, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(81, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(81, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // txttentaikhoan
            // 
            this.txttentaikhoan.Location = new System.Drawing.Point(234, 280);
            this.txttentaikhoan.Multiline = true;
            this.txttentaikhoan.Name = "txttentaikhoan";
            this.txttentaikhoan.Size = new System.Drawing.Size(242, 40);
            this.txttentaikhoan.TabIndex = 5;
            // 
            // txtmatkhau_dk
            // 
            this.txtmatkhau_dk.Location = new System.Drawing.Point(234, 338);
            this.txtmatkhau_dk.Multiline = true;
            this.txtmatkhau_dk.Name = "txtmatkhau_dk";
            this.txtmatkhau_dk.Size = new System.Drawing.Size(242, 40);
            this.txtmatkhau_dk.TabIndex = 6;
            // 
            // txtxacnhanmk
            // 
            this.txtxacnhanmk.Location = new System.Drawing.Point(234, 393);
            this.txtxacnhanmk.Multiline = true;
            this.txtxacnhanmk.Name = "txtxacnhanmk";
            this.txtxacnhanmk.Size = new System.Drawing.Size(242, 40);
            this.txtxacnhanmk.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(234, 449);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(242, 40);
            this.txtemail.TabIndex = 8;
            // 
            // btndangki
            // 
            this.btndangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangki.ForeColor = System.Drawing.Color.Navy;
            this.btndangki.Location = new System.Drawing.Point(234, 508);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(121, 56);
            this.btndangki.TabIndex = 9;
            this.btndangki.Text = "Đăng kí";
            this.btndangki.UseVisualStyleBackColor = true;
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MayTinhQA.Properties.Resources.dangki_icon;
            this.pictureBox1.Location = new System.Drawing.Point(85, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmdangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 592);
            this.Controls.Add(this.btndangki);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtxacnhanmk);
            this.Controls.Add(this.txtmatkhau_dk);
            this.Controls.Add(this.txttentaikhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmdangki";
            this.Text = "ĐĂNG KÍ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttentaikhoan;
        private System.Windows.Forms.TextBox txtmatkhau_dk;
        private System.Windows.Forms.TextBox txtxacnhanmk;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btndangki;
    }
}