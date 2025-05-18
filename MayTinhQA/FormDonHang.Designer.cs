namespace MayTinhQA
{
    partial class frmdonhang
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
            this.txtsanpham = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtiddonhang = new System.Windows.Forms.TextBox();
            this.txthovatenkhach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.datagriddonhang = new System.Windows.Forms.DataGridView();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.btngui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagriddonhang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsanpham
            // 
            this.txtsanpham.Location = new System.Drawing.Point(186, 114);
            this.txtsanpham.Name = "txtsanpham";
            this.txtsanpham.Size = new System.Drawing.Size(242, 26);
            this.txtsanpham.TabIndex = 29;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(186, 169);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(242, 26);
            this.txtsoluong.TabIndex = 27;
            // 
            // txtiddonhang
            // 
            this.txtiddonhang.Location = new System.Drawing.Point(186, 9);
            this.txtiddonhang.Name = "txtiddonhang";
            this.txtiddonhang.Size = new System.Drawing.Size(242, 26);
            this.txtiddonhang.TabIndex = 25;
            // 
            // txthovatenkhach
            // 
            this.txthovatenkhach.Location = new System.Drawing.Point(186, 54);
            this.txthovatenkhach.Name = "txthovatenkhach";
            this.txthovatenkhach.Size = new System.Drawing.Size(242, 26);
            this.txthovatenkhach.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sản phầm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Họ và tên KH";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(1017, 222);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(118, 82);
            this.btnxoa.TabIndex = 17;
            this.btnxoa.Text = "XOÁ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(1017, 17);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(118, 82);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // datagriddonhang
            // 
            this.datagriddonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagriddonhang.Location = new System.Drawing.Point(16, 243);
            this.datagriddonhang.Name = "datagriddonhang";
            this.datagriddonhang.RowHeadersWidth = 62;
            this.datagriddonhang.RowTemplate.Height = 28;
            this.datagriddonhang.Size = new System.Drawing.Size(910, 302);
            this.datagriddonhang.TabIndex = 30;
            this.datagriddonhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagriddonhang_CellContentClick);
            this.datagriddonhang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagriddonhang_RowEnter);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(1017, 118);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(118, 82);
            this.btnsua.TabIndex = 31;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(458, 8);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(118, 31);
            this.btntimkiem.TabIndex = 32;
            this.btntimkiem.Text = "TÌM KIẾM";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(598, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 26);
            this.textBox1.TabIndex = 33;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(1017, 432);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(136, 82);
            this.btnxacnhan.TabIndex = 15;
            this.btnxacnhan.Text = "XÁC NHẬN THANH TOÁN";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // btngui
            // 
            this.btngui.Location = new System.Drawing.Point(1017, 326);
            this.btngui.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btngui.Name = "btngui";
            this.btngui.Size = new System.Drawing.Size(112, 82);
            this.btngui.TabIndex = 34;
            this.btngui.Text = "GỬI";
            this.btngui.UseVisualStyleBackColor = true;
            this.btngui.Click += new System.EventHandler(this.btngui_Click);
            // 
            // frmdonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btngui);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.datagriddonhang);
            this.Controls.Add(this.txtsanpham);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtiddonhang);
            this.Controls.Add(this.txthovatenkhach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.btnthem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmdonhang";
            this.Text = "ĐƠN HÀNG";
            this.Load += new System.EventHandler(this.FormDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagriddonhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsanpham;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtiddonhang;
        private System.Windows.Forms.TextBox txthovatenkhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView datagriddonhang;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.Button btngui;
    }
}