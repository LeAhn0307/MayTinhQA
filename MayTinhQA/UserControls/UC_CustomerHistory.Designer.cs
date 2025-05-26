namespace MayTinhQA.UserControls
{
    partial class UC_CustomerHistory
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
            this.btntk = new System.Windows.Forms.Button();
            this.txttktheotenkhach = new System.Windows.Forms.TextBox();
            this.txttktheomahoadon = new System.Windows.Forms.TextBox();
            this.lbltongsogiaodich = new System.Windows.Forms.Label();
            this.dgvlichsugiaodich = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlichsugiaodich)).BeginInit();
            this.SuspendLayout();
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(201, 367);
            this.btntk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(97, 54);
            this.btntk.TabIndex = 9;
            this.btntk.Text = "TÌM KIẾM";
            this.btntk.UseVisualStyleBackColor = true;
            // 
            // txttktheotenkhach
            // 
            this.txttktheotenkhach.Location = new System.Drawing.Point(323, 367);
            this.txttktheotenkhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttktheotenkhach.Name = "txttktheotenkhach";
            this.txttktheotenkhach.Size = new System.Drawing.Size(116, 22);
            this.txttktheotenkhach.TabIndex = 8;
            // 
            // txttktheomahoadon
            // 
            this.txttktheomahoadon.Location = new System.Drawing.Point(323, 399);
            this.txttktheomahoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttktheomahoadon.Name = "txttktheomahoadon";
            this.txttktheomahoadon.Size = new System.Drawing.Size(116, 22);
            this.txttktheomahoadon.TabIndex = 7;
            // 
            // lbltongsogiaodich
            // 
            this.lbltongsogiaodich.AutoSize = true;
            this.lbltongsogiaodich.Location = new System.Drawing.Point(858, 367);
            this.lbltongsogiaodich.Name = "lbltongsogiaodich";
            this.lbltongsogiaodich.Size = new System.Drawing.Size(115, 16);
            this.lbltongsogiaodich.TabIndex = 6;
            this.lbltongsogiaodich.Text = "Tổng số giao dịch";
            // 
            // dgvlichsugiaodich
            // 
            this.dgvlichsugiaodich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlichsugiaodich.Location = new System.Drawing.Point(201, 15);
            this.dgvlichsugiaodich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvlichsugiaodich.Name = "dgvlichsugiaodich";
            this.dgvlichsugiaodich.RowHeadersWidth = 62;
            this.dgvlichsugiaodich.RowTemplate.Height = 28;
            this.dgvlichsugiaodich.Size = new System.Drawing.Size(886, 332);
            this.dgvlichsugiaodich.TabIndex = 5;
            // 
            // UC_CustomerHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.txttktheotenkhach);
            this.Controls.Add(this.txttktheomahoadon);
            this.Controls.Add(this.lbltongsogiaodich);
            this.Controls.Add(this.dgvlichsugiaodich);
            this.Name = "UC_CustomerHistory";
            this.Size = new System.Drawing.Size(1282, 597);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlichsugiaodich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.TextBox txttktheotenkhach;
        private System.Windows.Forms.TextBox txttktheomahoadon;
        private System.Windows.Forms.Label lbltongsogiaodich;
        private System.Windows.Forms.DataGridView dgvlichsugiaodich;
    }
}
