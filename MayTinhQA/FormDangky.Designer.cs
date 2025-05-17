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
            this.btndangki = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtxacnhanmk = new System.Windows.Forms.TextBox();
            this.txtmatkhau_dk = new System.Windows.Forms.TextBox();
            this.txttentaikhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndangki
            // 
            this.btndangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangki.ForeColor = System.Drawing.Color.Navy;
            this.btndangki.Location = new System.Drawing.Point(181, 333);
            this.btndangki.Margin = new System.Windows.Forms.Padding(2);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(81, 36);
            this.btndangki.TabIndex = 19;
            this.btndangki.Text = "Đăng kí";
            this.btndangki.UseVisualStyleBackColor = true;
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(181, 295);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(163, 27);
            this.txtemail.TabIndex = 18;
            // 
            // txtxacnhanmk
            // 
            this.txtxacnhanmk.Location = new System.Drawing.Point(181, 258);
            this.txtxacnhanmk.Margin = new System.Windows.Forms.Padding(2);
            this.txtxacnhanmk.Multiline = true;
            this.txtxacnhanmk.Name = "txtxacnhanmk";
            this.txtxacnhanmk.Size = new System.Drawing.Size(163, 27);
            this.txtxacnhanmk.TabIndex = 17;
            // 
            // txtmatkhau_dk
            // 
            this.txtmatkhau_dk.Location = new System.Drawing.Point(181, 223);
            this.txtmatkhau_dk.Margin = new System.Windows.Forms.Padding(2);
            this.txtmatkhau_dk.Multiline = true;
            this.txtmatkhau_dk.Name = "txtmatkhau_dk";
            this.txtmatkhau_dk.Size = new System.Drawing.Size(163, 27);
            this.txtmatkhau_dk.TabIndex = 16;
            // 
            // txttentaikhoan
            // 
            this.txttentaikhoan.Location = new System.Drawing.Point(181, 185);
            this.txttentaikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txttentaikhoan.Multiline = true;
            this.txttentaikhoan.Name = "txttentaikhoan";
            this.txttentaikhoan.Size = new System.Drawing.Size(163, 27);
            this.txttentaikhoan.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(79, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(79, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(79, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(79, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên tài khoản:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MayTinhQA.Properties.Resources.dangki_icon;
            this.pictureBox1.Location = new System.Drawing.Point(82, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 375);
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
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndangki;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtxacnhanmk;
        private System.Windows.Forms.TextBox txtmatkhau_dk;
        private System.Windows.Forms.TextBox txttentaikhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}