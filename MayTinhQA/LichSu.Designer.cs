
namespace MayTinhQA
{
    partial class frmlichsu
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
            this.dgvlichsugiaodich = new System.Windows.Forms.DataGridView();
            this.lbltongsogiaodich = new System.Windows.Forms.Label();
            this.txttktheomahoadon = new System.Windows.Forms.TextBox();
            this.txttktheotenkhach = new System.Windows.Forms.TextBox();
            this.btntk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlichsugiaodich)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlichsugiaodich
            // 
            this.dgvlichsugiaodich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlichsugiaodich.Location = new System.Drawing.Point(64, 38);
            this.dgvlichsugiaodich.Name = "dgvlichsugiaodich";
            this.dgvlichsugiaodich.RowHeadersWidth = 62;
            this.dgvlichsugiaodich.RowTemplate.Height = 28;
            this.dgvlichsugiaodich.Size = new System.Drawing.Size(593, 248);
            this.dgvlichsugiaodich.TabIndex = 0;
            // 
            // lbltongsogiaodich
            // 
            this.lbltongsogiaodich.AutoSize = true;
            this.lbltongsogiaodich.Location = new System.Drawing.Point(524, 308);
            this.lbltongsogiaodich.Name = "lbltongsogiaodich";
            this.lbltongsogiaodich.Size = new System.Drawing.Size(133, 20);
            this.lbltongsogiaodich.TabIndex = 1;
            this.lbltongsogiaodich.Text = "Tổng số giao dịch";
            // 
            // txttktheomahoadon
            // 
            this.txttktheomahoadon.Location = new System.Drawing.Point(198, 346);
            this.txttktheomahoadon.Name = "txttktheomahoadon";
            this.txttktheomahoadon.Size = new System.Drawing.Size(130, 26);
            this.txttktheomahoadon.TabIndex = 2;
            // 
            // txttktheotenkhach
            // 
            this.txttktheotenkhach.Location = new System.Drawing.Point(198, 305);
            this.txttktheotenkhach.Name = "txttktheotenkhach";
            this.txttktheotenkhach.Size = new System.Drawing.Size(130, 26);
            this.txttktheotenkhach.TabIndex = 3;
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(64, 305);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(109, 67);
            this.btntk.TabIndex = 4;
            this.btntk.Text = "TÌM KIẾM";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // frmlichsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 421);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.txttktheotenkhach);
            this.Controls.Add(this.txttktheomahoadon);
            this.Controls.Add(this.lbltongsogiaodich);
            this.Controls.Add(this.dgvlichsugiaodich);
            this.Name = "frmlichsu";
            this.Text = "LỊCH SỬ GIAO DỊCH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlichsugiaodich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlichsugiaodich;
        private System.Windows.Forms.Label lbltongsogiaodich;
        private System.Windows.Forms.TextBox txttktheomahoadon;
        private System.Windows.Forms.TextBox txttktheotenkhach;
        private System.Windows.Forms.Button btntk;
    }
}