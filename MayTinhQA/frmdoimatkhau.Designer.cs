
namespace MayTinhQA
{
    partial class frmdoimatkhau
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
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.txtnhaplaimk = new System.Windows.Forms.TextBox();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.btndoimk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(223, 62);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(181, 26);
            this.txtmkcu.TabIndex = 0;
            // 
            // txtnhaplaimk
            // 
            this.txtnhaplaimk.Location = new System.Drawing.Point(223, 165);
            this.txtnhaplaimk.Name = "txtnhaplaimk";
            this.txtnhaplaimk.Size = new System.Drawing.Size(181, 26);
            this.txtnhaplaimk.TabIndex = 1;
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(223, 112);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(181, 26);
            this.txtmkmoi.TabIndex = 2;
            // 
            // btndoimk
            // 
            this.btndoimk.Location = new System.Drawing.Point(223, 211);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(129, 51);
            this.btndoimk.TabIndex = 3;
            this.btndoimk.Text = "Đổi mật khẩu";
            this.btndoimk.UseVisualStyleBackColor = true;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu mới";
            // 
            // frmdoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 317);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndoimk);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.txtnhaplaimk);
            this.Controls.Add(this.txtmkcu);
            this.Name = "frmdoimatkhau";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmdoimatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.TextBox txtnhaplaimk;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}