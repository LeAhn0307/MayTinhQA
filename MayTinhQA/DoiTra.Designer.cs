
namespace MayTinhQA
{
    partial class frmdoitra
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
            this.btnexcel = new System.Windows.Forms.Button();
            this.dgvPhieudoitra = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntao = new System.Windows.Forms.Button();
            this.dtpngaytao = new System.Windows.Forms.DateTimePicker();
            this.txtidnhanvien = new System.Windows.Forms.TextBox();
            this.txtidsanpham = new System.Windows.Forms.TextBox();
            this.txtidphieudoitra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieudoitra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(555, 179);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(178, 41);
            this.btnexcel.TabIndex = 58;
            this.btnexcel.Text = "XUẤT FILE EXCEL";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // dgvPhieudoitra
            // 
            this.dgvPhieudoitra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieudoitra.Location = new System.Drawing.Point(67, 241);
            this.dgvPhieudoitra.Name = "dgvPhieudoitra";
            this.dgvPhieudoitra.RowHeadersWidth = 62;
            this.dgvPhieudoitra.RowTemplate.Height = 28;
            this.dgvPhieudoitra.Size = new System.Drawing.Size(666, 200);
            this.dgvPhieudoitra.TabIndex = 57;
            this.dgvPhieudoitra.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieudoitra_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "PHIẾU ĐỎI TRẢ";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(298, 179);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(83, 41);
            this.btnxoa.TabIndex = 55;
            this.btnxoa.Text = "XOÁ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(436, 179);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(83, 41);
            this.btnsua.TabIndex = 54;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntao
            // 
            this.btntao.Location = new System.Drawing.Point(181, 179);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(83, 41);
            this.btntao.TabIndex = 53;
            this.btntao.Text = "TẠO ";
            this.btntao.UseVisualStyleBackColor = true;
            this.btntao.Click += new System.EventHandler(this.btntao_Click);
            // 
            // dtpngaytao
            // 
            this.dtpngaytao.Location = new System.Drawing.Point(181, 135);
            this.dtpngaytao.Name = "dtpngaytao";
            this.dtpngaytao.Size = new System.Drawing.Size(200, 26);
            this.dtpngaytao.TabIndex = 52;
            // 
            // txtidnhanvien
            // 
            this.txtidnhanvien.Location = new System.Drawing.Point(555, 132);
            this.txtidnhanvien.Name = "txtidnhanvien";
            this.txtidnhanvien.Size = new System.Drawing.Size(178, 26);
            this.txtidnhanvien.TabIndex = 51;
            // 
            // txtidsanpham
            // 
            this.txtidsanpham.Location = new System.Drawing.Point(555, 98);
            this.txtidsanpham.Name = "txtidsanpham";
            this.txtidsanpham.Size = new System.Drawing.Size(178, 26);
            this.txtidsanpham.TabIndex = 50;
            // 
            // txtidphieudoitra
            // 
            this.txtidphieudoitra.Location = new System.Drawing.Point(181, 95);
            this.txtidphieudoitra.Name = "txtidphieudoitra";
            this.txtidphieudoitra.Size = new System.Drawing.Size(200, 26);
            this.txtidphieudoitra.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Ngày tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã phiếu";
            // 
            // frmdoitra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.dgvPhieudoitra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btntao);
            this.Controls.Add(this.dtpngaytao);
            this.Controls.Add(this.txtidnhanvien);
            this.Controls.Add(this.txtidsanpham);
            this.Controls.Add(this.txtidphieudoitra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmdoitra";
            this.Text = "PHIẾU ĐỔI TRẢ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieudoitra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.DataGridView dgvPhieudoitra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntao;
        private System.Windows.Forms.DateTimePicker dtpngaytao;
        private System.Windows.Forms.TextBox txtidnhanvien;
        private System.Windows.Forms.TextBox txtidsanpham;
        private System.Windows.Forms.TextBox txtidphieudoitra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}