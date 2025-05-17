
namespace MayTinhQA
{
    partial class frmnhanvien
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
            this.label5 = new System.Windows.Forms.Label();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtidnhanvien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Chức vụ";
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(144, 66);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(220, 26);
            this.txttennhanvien.TabIndex = 6;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(144, 123);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(220, 26);
            this.txtchucvu.TabIndex = 9;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(404, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(138, 82);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(559, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(138, 82);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(712, 3);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(138, 82);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "XOÁ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtidnhanvien
            // 
            this.txtidnhanvien.Location = new System.Drawing.Point(144, 3);
            this.txtidnhanvien.Name = "txtidnhanvien";
            this.txtidnhanvien.Size = new System.Drawing.Size(220, 26);
            this.txtidnhanvien.TabIndex = 15;
            this.txtidnhanvien.TextChanged += new System.EventHandler(this.txtidkhachhang_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(43, 229);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.Size = new System.Drawing.Size(807, 302);
            this.dgvNhanVien.TabIndex = 16;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridnhanvien_CellClick);
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridnhanvien_CellContentClick_1);
            this.dgvNhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridnhanvien_RowEnter_1);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(404, 123);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(138, 26);
            this.btntimkiem.TabIndex = 17;
            this.btntimkiem.Text = "TÌM KIẾM";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(559, 123);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(291, 26);
            this.txttimkiem.TabIndex = 18;
            // 
            // frmnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 560);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.txtidnhanvien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtchucvu);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmnhanvien";
            this.Text = "NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frmnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtidnhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}

