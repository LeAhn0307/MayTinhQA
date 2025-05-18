
namespace MayTinhQA
{
    partial class frmbaohanh
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
            this.btnxuatexcel = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntao = new System.Windows.Forms.Button();
            this.dtpngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.dtpngaytao = new System.Windows.Forms.DateTimePicker();
            this.txtidnhanvien = new System.Windows.Forms.TextBox();
            this.txtidsanpham = new System.Windows.Forms.TextBox();
            this.txtidphieubaohanh = new System.Windows.Forms.TextBox();
            this.dgvPhieubaohanh = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieubaohanh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.Location = new System.Drawing.Point(436, 199);
            this.btnxuatexcel.Name = "btnxuatexcel";
            this.btnxuatexcel.Size = new System.Drawing.Size(299, 41);
            this.btnxuatexcel.TabIndex = 47;
            this.btnxuatexcel.Text = "XUẤT FILE EXCEL";
            this.btnxuatexcel.UseVisualStyleBackColor = true;
            this.btnxuatexcel.Click += new System.EventHandler(this.btnxuatexcel_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(544, 152);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(83, 41);
            this.btnxoa.TabIndex = 46;
            this.btnxoa.Text = "XOÁ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(652, 152);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(83, 41);
            this.btnsua.TabIndex = 45;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntao
            // 
            this.btntao.Location = new System.Drawing.Point(436, 152);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(83, 41);
            this.btntao.TabIndex = 44;
            this.btntao.Text = "TẠO ";
            this.btntao.UseVisualStyleBackColor = true;
            this.btntao.Click += new System.EventHandler(this.btntao_Click);
            // 
            // dtpngayketthuc
            // 
            this.dtpngayketthuc.Location = new System.Drawing.Point(183, 162);
            this.dtpngayketthuc.Name = "dtpngayketthuc";
            this.dtpngayketthuc.Size = new System.Drawing.Size(200, 26);
            this.dtpngayketthuc.TabIndex = 43;
            // 
            // dtpngaytao
            // 
            this.dtpngaytao.Location = new System.Drawing.Point(183, 123);
            this.dtpngaytao.Name = "dtpngaytao";
            this.dtpngaytao.Size = new System.Drawing.Size(200, 26);
            this.dtpngaytao.TabIndex = 42;
            // 
            // txtidnhanvien
            // 
            this.txtidnhanvien.Location = new System.Drawing.Point(557, 120);
            this.txtidnhanvien.Name = "txtidnhanvien";
            this.txtidnhanvien.Size = new System.Drawing.Size(178, 26);
            this.txtidnhanvien.TabIndex = 41;
            // 
            // txtidsanpham
            // 
            this.txtidsanpham.Location = new System.Drawing.Point(557, 86);
            this.txtidsanpham.Name = "txtidsanpham";
            this.txtidsanpham.Size = new System.Drawing.Size(178, 26);
            this.txtidsanpham.TabIndex = 40;
            // 
            // txtidphieubaohanh
            // 
            this.txtidphieubaohanh.Location = new System.Drawing.Point(183, 83);
            this.txtidphieubaohanh.Name = "txtidphieubaohanh";
            this.txtidphieubaohanh.Size = new System.Drawing.Size(200, 26);
            this.txtidphieubaohanh.TabIndex = 39;
            // 
            // dgvPhieubaohanh
            // 
            this.dgvPhieubaohanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieubaohanh.Location = new System.Drawing.Point(69, 259);
            this.dgvPhieubaohanh.Name = "dgvPhieubaohanh";
            this.dgvPhieubaohanh.RowHeadersWidth = 62;
            this.dgvPhieubaohanh.RowTemplate.Height = 28;
            this.dgvPhieubaohanh.Size = new System.Drawing.Size(666, 183);
            this.dgvPhieubaohanh.TabIndex = 38;
            this.dgvPhieubaohanh.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieubaohanh_RowEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mã sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ngày tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "PHIẾU BẢO HÀNH";
            // 
            // frmbaohanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxuatexcel);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btntao);
            this.Controls.Add(this.dtpngayketthuc);
            this.Controls.Add(this.dtpngaytao);
            this.Controls.Add(this.txtidnhanvien);
            this.Controls.Add(this.txtidsanpham);
            this.Controls.Add(this.txtidphieubaohanh);
            this.Controls.Add(this.dgvPhieubaohanh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmbaohanh";
            this.Text = "PHIẾU BẢO HÀNH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieubaohanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnxuatexcel;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntao;
        private System.Windows.Forms.DateTimePicker dtpngayketthuc;
        private System.Windows.Forms.DateTimePicker dtpngaytao;
        private System.Windows.Forms.TextBox txtidnhanvien;
        private System.Windows.Forms.TextBox txtidsanpham;
        private System.Windows.Forms.TextBox txtidphieubaohanh;
        private System.Windows.Forms.DataGridView dgvPhieubaohanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}