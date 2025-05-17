
namespace MayTinhQA
{
    partial class frmkhachhang
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.datagridkhach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txthovatenkhach = new System.Windows.Forms.TextBox();
            this.txtsdtkhach = new System.Windows.Forms.TextBox();
            this.txtdiachikhach = new System.Windows.Forms.TextBox();
            this.txtemailkhach = new System.Windows.Forms.TextBox();
            this.dtpkhach = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidkhachhang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridkhach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(368, 27);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 53);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(477, 27);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 53);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(368, 105);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 53);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XOÁ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(477, 105);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(79, 53);
            this.btncapnhat.TabIndex = 3;
            this.btncapnhat.Text = "CẬP NHẬT";
            this.btncapnhat.UseVisualStyleBackColor = true;
            // 
            // datagridkhach
            // 
            this.datagridkhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridkhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.datagridkhach.Location = new System.Drawing.Point(11, 188);
            this.datagridkhach.Margin = new System.Windows.Forms.Padding(2);
            this.datagridkhach.Name = "datagridkhach";
            this.datagridkhach.RowHeadersWidth = 62;
            this.datagridkhach.RowTemplate.Height = 28;
            this.datagridkhach.Size = new System.Drawing.Size(585, 157);
            this.datagridkhach.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ và tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // txthovatenkhach
            // 
            this.txthovatenkhach.Location = new System.Drawing.Point(110, 37);
            this.txthovatenkhach.Margin = new System.Windows.Forms.Padding(2);
            this.txthovatenkhach.Name = "txthovatenkhach";
            this.txthovatenkhach.Size = new System.Drawing.Size(163, 20);
            this.txthovatenkhach.TabIndex = 10;
            // 
            // txtsdtkhach
            // 
            this.txtsdtkhach.Location = new System.Drawing.Point(110, 94);
            this.txtsdtkhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtsdtkhach.Name = "txtsdtkhach";
            this.txtsdtkhach.Size = new System.Drawing.Size(163, 20);
            this.txtsdtkhach.TabIndex = 11;
            // 
            // txtdiachikhach
            // 
            this.txtdiachikhach.Location = new System.Drawing.Point(110, 67);
            this.txtdiachikhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtdiachikhach.Name = "txtdiachikhach";
            this.txtdiachikhach.Size = new System.Drawing.Size(163, 20);
            this.txtdiachikhach.TabIndex = 12;
            // 
            // txtemailkhach
            // 
            this.txtemailkhach.Location = new System.Drawing.Point(110, 161);
            this.txtemailkhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtemailkhach.Name = "txtemailkhach";
            this.txtemailkhach.Size = new System.Drawing.Size(163, 20);
            this.txtemailkhach.TabIndex = 13;
            // 
            // dtpkhach
            // 
            this.dtpkhach.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkhach.Location = new System.Drawing.Point(110, 125);
            this.dtpkhach.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkhach.Name = "dtpkhach";
            this.dtpkhach.Size = new System.Drawing.Size(163, 20);
            this.dtpkhach.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ho va ten";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dia chi";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "So dien thoai";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngay sinh";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "id";
            // 
            // txtidkhachhang
            // 
            this.txtidkhachhang.Location = new System.Drawing.Point(110, 7);
            this.txtidkhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.txtidkhachhang.Name = "txtidkhachhang";
            this.txtidkhachhang.Size = new System.Drawing.Size(163, 20);
            this.txtidkhachhang.TabIndex = 10;
            // 
            // frmkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 356);
            this.Controls.Add(this.dtpkhach);
            this.Controls.Add(this.txtemailkhach);
            this.Controls.Add(this.txtdiachikhach);
            this.Controls.Add(this.txtsdtkhach);
            this.Controls.Add(this.txtidkhachhang);
            this.Controls.Add(this.txthovatenkhach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridkhach);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmkhachhang";
            this.Text = "KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmkhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridkhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.DataGridView datagridkhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthovatenkhach;
        private System.Windows.Forms.TextBox txtsdtkhach;
        private System.Windows.Forms.TextBox txtdiachikhach;
        private System.Windows.Forms.TextBox txtemailkhach;
        private System.Windows.Forms.DateTimePicker dtpkhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidkhachhang;
    }
}