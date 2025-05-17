
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtidkhachhang = new System.Windows.Forms.TextBox();
            this.dtpkhach = new System.Windows.Forms.DateTimePicker();
            this.txtemailkhach = new System.Windows.Forms.TextBox();
            this.txtdiachikhach = new System.Windows.Forms.TextBox();
            this.txtsdtkhach = new System.Windows.Forms.TextBox();
            this.txthovatenkhach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKhachhang = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.cbloaikhach = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID";
            // 
            // txtidkhachhang
            // 
            this.txtidkhachhang.Location = new System.Drawing.Point(110, 11);
            this.txtidkhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.txtidkhachhang.Name = "txtidkhachhang";
            this.txtidkhachhang.Size = new System.Drawing.Size(163, 20);
            this.txtidkhachhang.TabIndex = 10;
            // 
            // dtpkhach
            // 
            this.dtpkhach.CustomFormat = "dd/MM/yyyy";
            this.dtpkhach.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkhach.Location = new System.Drawing.Point(110, 156);
            this.dtpkhach.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkhach.Name = "dtpkhach";
            this.dtpkhach.Size = new System.Drawing.Size(163, 20);
            this.dtpkhach.TabIndex = 14;
            this.dtpkhach.Value = new System.DateTime(2025, 4, 2, 16, 55, 26, 0);
            // 
            // txtemailkhach
            // 
            this.txtemailkhach.Location = new System.Drawing.Point(110, 72);
            this.txtemailkhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtemailkhach.Name = "txtemailkhach";
            this.txtemailkhach.Size = new System.Drawing.Size(163, 20);
            this.txtemailkhach.TabIndex = 13;
            // 
            // txtdiachikhach
            // 
            this.txtdiachikhach.Location = new System.Drawing.Point(110, 129);
            this.txtdiachikhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtdiachikhach.Name = "txtdiachikhach";
            this.txtdiachikhach.Size = new System.Drawing.Size(163, 20);
            this.txtdiachikhach.TabIndex = 12;
            // 
            // txtsdtkhach
            // 
            this.txtsdtkhach.Location = new System.Drawing.Point(110, 102);
            this.txtsdtkhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtsdtkhach.Name = "txtsdtkhach";
            this.txtsdtkhach.Size = new System.Drawing.Size(163, 20);
            this.txtsdtkhach.TabIndex = 11;
            // 
            // txthovatenkhach
            // 
            this.txthovatenkhach.Location = new System.Drawing.Point(110, 44);
            this.txthovatenkhach.Margin = new System.Windows.Forms.Padding(2);
            this.txthovatenkhach.Name = "txthovatenkhach";
            this.txthovatenkhach.Size = new System.Drawing.Size(163, 20);
            this.txthovatenkhach.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ và tên";
            // 
            // dgvKhachhang
            // 
            this.dgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachhang.Location = new System.Drawing.Point(45, 190);
            this.dgvKhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhachhang.Name = "dgvKhachhang";
            this.dgvKhachhang.ReadOnly = true;
            this.dgvKhachhang.RowHeadersWidth = 62;
            this.dgvKhachhang.RowTemplate.Height = 28;
            this.dgvKhachhang.Size = new System.Drawing.Size(545, 173);
            this.dgvKhachhang.TabIndex = 4;
            this.dgvKhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridkhach_CellContentClick);
            this.dgvKhachhang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridkhach_RowEnter_1);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(301, 11);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(79, 53);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(495, 11);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(79, 53);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "XOÁ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(398, 11);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(79, 53);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(301, 154);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(79, 29);
            this.btntimkiem.TabIndex = 15;
            this.btntimkiem.Text = "TÌM KIẾM";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(398, 156);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(177, 20);
            this.txttimkiem.TabIndex = 16;
            // 
            // cbloaikhach
            // 
            this.cbloaikhach.FormattingEnabled = true;
            this.cbloaikhach.Items.AddRange(new object[] {
            "VIP",
            "Trung thành",
            "Tiềm năng",
            "Ngủ quên"});
            this.cbloaikhach.Location = new System.Drawing.Point(398, 121);
            this.cbloaikhach.Name = "cbloaikhach";
            this.cbloaikhach.Size = new System.Drawing.Size(177, 21);
            this.cbloaikhach.TabIndex = 17;
            this.cbloaikhach.SelectedIndexChanged += new System.EventHandler(this.cbloaikhach_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Loại khách hàng";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(301, 79);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 18;
            this.btnluu.Text = "LƯU";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Visible = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(398, 79);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 19;
            this.btnhuy.Text = "HỦY";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // frmkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 371);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.cbloaikhach);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dtpkhach);
            this.Controls.Add(this.txtemailkhach);
            this.Controls.Add(this.txtdiachikhach);
            this.Controls.Add(this.txtsdtkhach);
            this.Controls.Add(this.txtidkhachhang);
            this.Controls.Add(this.txthovatenkhach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKhachhang);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmkhachhang";
            this.Text = "KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmkhachhang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidkhachhang;
        private System.Windows.Forms.DateTimePicker dtpkhach;
        private System.Windows.Forms.TextBox txtemailkhach;
        private System.Windows.Forms.TextBox txtdiachikhach;
        private System.Windows.Forms.TextBox txtsdtkhach;
        private System.Windows.Forms.TextBox txthovatenkhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhachhang;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.ComboBox cbloaikhach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
    }
}