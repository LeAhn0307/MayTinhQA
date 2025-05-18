
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DMquanlykhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.DMkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.DMphanhoi = new System.Windows.Forms.ToolStripMenuItem();
            this.DMquanlygiaodich = new System.Windows.Forms.ToolStripMenuItem();
            this.DMdonhang = new System.Windows.Forms.ToolStripMenuItem();
            this.DMhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.DMkhuyenmai = new System.Windows.Forms.ToolStripMenuItem();
            this.DMlichsu = new System.Windows.Forms.ToolStripMenuItem();
            this.DMquanlydvkh = new System.Windows.Forms.ToolStripMenuItem();
            this.DMbaohanh = new System.Windows.Forms.ToolStripMenuItem();
            this.DMdoitra = new System.Windows.Forms.ToolStripMenuItem();
            this.DMquanlynhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.DMquanlysp = new System.Windows.Forms.ToolStripMenuItem();
            this.DMthongke = new System.Windows.Forms.ToolStripMenuItem();
            this.DMlichsugiaodich = new System.Windows.Forms.ToolStripMenuItem();
            this.DMphanhoikh = new System.Windows.Forms.ToolStripMenuItem();
            this.DMhanhvikh = new System.Windows.Forms.ToolStripMenuItem();
            this.DMnhucausp = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndangxuat
            // 
            this.btndangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangxuat.ForeColor = System.Drawing.Color.Navy;
            this.btndangxuat.Location = new System.Drawing.Point(817, 445);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(238, 59);
            this.btndangxuat.TabIndex = 0;
            this.btndangxuat.Text = "ĐĂNG XUẤT";
            this.btndangxuat.UseVisualStyleBackColor = true;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DMquanlykhachhang,
            this.DMquanlygiaodich,
            this.DMquanlydvkh,
            this.DMquanlynhanvien,
            this.DMquanlysp,
            this.DMthongke});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Nhân viên";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // DMquanlykhachhang
            // 
            this.DMquanlykhachhang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DMkhachhang,
            this.DMphanhoi});
            this.DMquanlykhachhang.Name = "DMquanlykhachhang";
            this.DMquanlykhachhang.Size = new System.Drawing.Size(185, 29);
            this.DMquanlykhachhang.Text = "Quản lý khách hàng";
            this.DMquanlykhachhang.Click += new System.EventHandler(this.khachHangToolStripMenuItem_Click_1);
            this.DMquanlykhachhang.DoubleClick += new System.EventHandler(this.khachHangToolStripMenuItem_DoubleClick);
            // 
            // DMkhachhang
            // 
            this.DMkhachhang.Name = "DMkhachhang";
            this.DMkhachhang.Size = new System.Drawing.Size(206, 34);
            this.DMkhachhang.Text = "Khách hàng";
            this.DMkhachhang.Click += new System.EventHandler(this.DMkhachhang_Click);
            // 
            // DMphanhoi
            // 
            this.DMphanhoi.Name = "DMphanhoi";
            this.DMphanhoi.Size = new System.Drawing.Size(206, 34);
            this.DMphanhoi.Text = "Phản hồi";
            // 
            // DMquanlygiaodich
            // 
            this.DMquanlygiaodich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DMdonhang,
            this.DMhoadon,
            this.DMkhuyenmai,
            this.DMlichsu});
            this.DMquanlygiaodich.Name = "DMquanlygiaodich";
            this.DMquanlygiaodich.Size = new System.Drawing.Size(167, 29);
            this.DMquanlygiaodich.Text = "Quản lý giao dịch";
            this.DMquanlygiaodich.Click += new System.EventHandler(this.donBanToolStripMenuItem_Click_1);
            // 
            // DMdonhang
            // 
            this.DMdonhang.Name = "DMdonhang";
            this.DMdonhang.Size = new System.Drawing.Size(206, 34);
            this.DMdonhang.Text = "Đơn hàng";
            this.DMdonhang.Click += new System.EventHandler(this.DMdonhang_Click);
            // 
            // DMhoadon
            // 
            this.DMhoadon.Name = "DMhoadon";
            this.DMhoadon.Size = new System.Drawing.Size(206, 34);
            this.DMhoadon.Text = "Hoá đơn";
            this.DMhoadon.Click += new System.EventHandler(this.DMhoadon_Click);
            // 
            // DMkhuyenmai
            // 
            this.DMkhuyenmai.Name = "DMkhuyenmai";
            this.DMkhuyenmai.Size = new System.Drawing.Size(206, 34);
            this.DMkhuyenmai.Text = "Khuyến mại";
            this.DMkhuyenmai.Click += new System.EventHandler(this.DMkhuyenmai_Click);
            // 
            // DMlichsu
            // 
            this.DMlichsu.Name = "DMlichsu";
            this.DMlichsu.Size = new System.Drawing.Size(206, 34);
            this.DMlichsu.Text = "Lịch sử";
            this.DMlichsu.Click += new System.EventHandler(this.DMlichsu_Click);
            // 
            // DMquanlydvkh
            // 
            this.DMquanlydvkh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DMbaohanh,
            this.DMdoitra});
            this.DMquanlydvkh.Name = "DMquanlydvkh";
            this.DMquanlydvkh.Size = new System.Drawing.Size(247, 29);
            this.DMquanlydvkh.Text = "Quản lý dịch vụ khách hàng";
            this.DMquanlydvkh.Click += new System.EventHandler(this.taiKhoanToolStripMenuItem_Click_1);
            // 
            // DMbaohanh
            // 
            this.DMbaohanh.Name = "DMbaohanh";
            this.DMbaohanh.Size = new System.Drawing.Size(188, 34);
            this.DMbaohanh.Text = "Bảo hành";
            // 
            // DMdoitra
            // 
            this.DMdoitra.Name = "DMdoitra";
            this.DMdoitra.Size = new System.Drawing.Size(188, 34);
            this.DMdoitra.Text = "Đổi trả";
            // 
            // DMquanlynhanvien
            // 
            this.DMquanlynhanvien.Name = "DMquanlynhanvien";
            this.DMquanlynhanvien.Size = new System.Drawing.Size(170, 29);
            this.DMquanlynhanvien.Text = "Quản lý nhân viên";
            this.DMquanlynhanvien.Click += new System.EventHandler(this.danhmucNV_Click);
            // 
            // DMquanlysp
            // 
            this.DMquanlysp.Name = "DMquanlysp";
            this.DMquanlysp.Size = new System.Drawing.Size(172, 29);
            this.DMquanlysp.Text = "Quản lý sản phẩm";
            this.DMquanlysp.Click += new System.EventHandler(this.DMquanlysp_Click);
            // 
            // DMthongke
            // 
            this.DMthongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DMlichsugiaodich,
            this.DMphanhoikh,
            this.DMhanhvikh,
            this.DMnhucausp});
            this.DMthongke.Name = "DMthongke";
            this.DMthongke.Size = new System.Drawing.Size(102, 29);
            this.DMthongke.Text = "Thống kê";
            // 
            // DMlichsugiaodich
            // 
            this.DMlichsugiaodich.Name = "DMlichsugiaodich";
            this.DMlichsugiaodich.Size = new System.Drawing.Size(311, 34);
            this.DMlichsugiaodich.Text = "Lịch sử giao dịch";
            this.DMlichsugiaodich.Click += new System.EventHandler(this.DMlichsugiaodich_Click);
            // 
            // DMphanhoikh
            // 
            this.DMphanhoikh.Name = "DMphanhoikh";
            this.DMphanhoikh.Size = new System.Drawing.Size(311, 34);
            this.DMphanhoikh.Text = "Phản hồi của khách hàng";
            // 
            // DMhanhvikh
            // 
            this.DMhanhvikh.Name = "DMhanhvikh";
            this.DMhanhvikh.Size = new System.Drawing.Size(311, 34);
            this.DMhanhvikh.Text = "Hành vi khách hàng";
            this.DMhanhvikh.Click += new System.EventHandler(this.DMhanhvikh_Click);
            // 
            // DMnhucausp
            // 
            this.DMnhucausp.Name = "DMnhucausp";
            this.DMnhucausp.Size = new System.Drawing.Size(311, 34);
            this.DMnhucausp.Text = "Nhu cầu sản phẩm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MayTinhQA.Properties.Resources.QA1;
            this.pictureBox2.Location = new System.Drawing.Point(519, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(536, 414);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MayTinhQA.Properties.Resources.QA2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 468);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 503);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndangxuat);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmhome";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.frmhome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DMquanlykhachhang;
        private System.Windows.Forms.ToolStripMenuItem DMquanlygiaodich;
        private System.Windows.Forms.ToolStripMenuItem DMquanlydvkh;
        private System.Windows.Forms.ToolStripMenuItem DMquanlynhanvien;
        private System.Windows.Forms.ToolStripMenuItem DMkhachhang;
        private System.Windows.Forms.ToolStripMenuItem DMphanhoi;
        private System.Windows.Forms.ToolStripMenuItem DMdonhang;
        private System.Windows.Forms.ToolStripMenuItem DMhoadon;
        private System.Windows.Forms.ToolStripMenuItem DMkhuyenmai;
        private System.Windows.Forms.ToolStripMenuItem DMlichsu;
        private System.Windows.Forms.ToolStripMenuItem DMbaohanh;
        private System.Windows.Forms.ToolStripMenuItem DMdoitra;
        private System.Windows.Forms.ToolStripMenuItem DMthongke;
        private System.Windows.Forms.ToolStripMenuItem DMlichsugiaodich;
        private System.Windows.Forms.ToolStripMenuItem DMphanhoikh;
        private System.Windows.Forms.ToolStripMenuItem DMquanlysp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem DMhanhvikh;
        private System.Windows.Forms.ToolStripMenuItem DMnhucausp;
    }
}