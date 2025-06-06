
namespace MayTinhQA
{
    partial class frmxoataikhoan
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
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(145, 184);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(148, 60);
            this.btnxoa.TabIndex = 0;
            this.btnxoa.Text = "XOÁ TÀI KHOẢN";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(321, 184);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(148, 60);
            this.btnhuy.TabIndex = 1;
            this.btnhuy.Text = "HUỶ";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bạn có chắc chắn muốn xóa tài khoản này?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font(".VnArial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(212, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "XOÁ TÀI KHOẢN";
            // 
            // frmxoataikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoa);
            this.Name = "frmxoataikhoan";
            this.Text = "Xoá Tài Khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}