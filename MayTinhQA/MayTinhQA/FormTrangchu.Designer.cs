
namespace MayTinhQA
{
    partial class frmhome
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
            this.btndangxuat = new System.Windows.Forms.Button();
            this.btnQuanlytaikhoan = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caiDatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndangxuat
            // 
            this.btndangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangxuat.ForeColor = System.Drawing.Color.Navy;
            this.btndangxuat.Location = new System.Drawing.Point(437, 11);
            this.btndangxuat.Margin = new System.Windows.Forms.Padding(2);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(85, 43);
            this.btndangxuat.TabIndex = 0;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.UseVisualStyleBackColor = true;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // btnQuanlytaikhoan
            // 
            this.btnQuanlytaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanlytaikhoan.ForeColor = System.Drawing.Color.Navy;
            this.btnQuanlytaikhoan.Location = new System.Drawing.Point(436, 71);
            this.btnQuanlytaikhoan.Name = "btnQuanlytaikhoan";
            this.btnQuanlytaikhoan.Size = new System.Drawing.Size(85, 51);
            this.btnQuanlytaikhoan.TabIndex = 1;
            this.btnQuanlytaikhoan.Text = "Quan ly tai khoan";
            this.btnQuanlytaikhoan.UseVisualStyleBackColor = true;
            this.btnQuanlytaikhoan.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khachHangToolStripMenuItem,
            this.caiDatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // khachHangToolStripMenuItem
            // 
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.khachHangToolStripMenuItem.Text = "Khach hang";
            this.khachHangToolStripMenuItem.Click += new System.EventHandler(this.khachHangToolStripMenuItem_Click);
            // 
            // caiDatToolStripMenuItem
            // 
            this.caiDatToolStripMenuItem.Name = "caiDatToolStripMenuItem";
            this.caiDatToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.caiDatToolStripMenuItem.Text = "Nhan Vien";
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnQuanlytaikhoan);
            this.Controls.Add(this.btndangxuat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmhome";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.frmhome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.Button btnQuanlytaikhoan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caiDatToolStripMenuItem;
    }
}