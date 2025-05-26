namespace MayTinhQA.UserControls
{
    partial class UC_CustomerNeeds
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpketthuc = new System.Windows.Forms.DateTimePicker();
            this.dtpbatdau = new System.Windows.Forms.DateTimePicker();
            this.cbxsp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.btnphantich = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpketthuc
            // 
            this.dtpketthuc.Location = new System.Drawing.Point(404, 82);
            this.dtpketthuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpketthuc.Name = "dtpketthuc";
            this.dtpketthuc.Size = new System.Drawing.Size(178, 22);
            this.dtpketthuc.TabIndex = 15;
            // 
            // dtpbatdau
            // 
            this.dtpbatdau.Location = new System.Drawing.Point(404, 42);
            this.dtpbatdau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpbatdau.Name = "dtpbatdau";
            this.dtpbatdau.Size = new System.Drawing.Size(178, 22);
            this.dtpbatdau.TabIndex = 14;
            // 
            // cbxsp
            // 
            this.cbxsp.FormattingEnabled = true;
            this.cbxsp.Location = new System.Drawing.Point(404, 7);
            this.cbxsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxsp.Name = "cbxsp";
            this.cbxsp.Size = new System.Drawing.Size(178, 24);
            this.cbxsp.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chọn sản phẩm";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(275, 124);
            this.dgvKetQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 62;
            this.dgvKetQua.RowTemplate.Height = 28;
            this.dgvKetQua.Size = new System.Drawing.Size(735, 466);
            this.dgvKetQua.TabIndex = 9;
            // 
            // btnphantich
            // 
            this.btnphantich.Location = new System.Drawing.Point(605, 7);
            this.btnphantich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnphantich.Name = "btnphantich";
            this.btnphantich.Size = new System.Drawing.Size(101, 37);
            this.btnphantich.TabIndex = 8;
            this.btnphantich.Text = "PHÂN TÍCH";
            this.btnphantich.UseVisualStyleBackColor = true;
            // 
            // UC_CustomerNeeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpketthuc);
            this.Controls.Add(this.dtpbatdau);
            this.Controls.Add(this.cbxsp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.btnphantich);
            this.Name = "UC_CustomerNeeds";
            this.Size = new System.Drawing.Size(1282, 597);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpketthuc;
        private System.Windows.Forms.DateTimePicker dtpbatdau;
        private System.Windows.Forms.ComboBox cbxsp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Button btnphantich;
    }
}
