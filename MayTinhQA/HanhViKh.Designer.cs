
namespace MayTinhQA
{
    partial class frmhanhvikh
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvthongke = new System.Windows.Forms.DataGridView();
            this.dgvphankhuc = new System.Windows.Forms.DataGridView();
            this.chartxuhuong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphankhuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartxuhuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvthongke
            // 
            this.dgvthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongke.Location = new System.Drawing.Point(12, 12);
            this.dgvthongke.Name = "dgvthongke";
            this.dgvthongke.RowHeadersWidth = 62;
            this.dgvthongke.RowTemplate.Height = 28;
            this.dgvthongke.Size = new System.Drawing.Size(564, 211);
            this.dgvthongke.TabIndex = 0;
            // 
            // dgvphankhuc
            // 
            this.dgvphankhuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphankhuc.Location = new System.Drawing.Point(12, 229);
            this.dgvphankhuc.Name = "dgvphankhuc";
            this.dgvphankhuc.RowHeadersWidth = 62;
            this.dgvphankhuc.RowTemplate.Height = 28;
            this.dgvphankhuc.Size = new System.Drawing.Size(564, 211);
            this.dgvphankhuc.TabIndex = 1;
            // 
            // chartxuhuong
            // 
            chartArea1.Name = "ChartArea1";
            this.chartxuhuong.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartxuhuong.Legends.Add(legend1);
            this.chartxuhuong.Location = new System.Drawing.Point(605, 12);
            this.chartxuhuong.Name = "chartxuhuong";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số Giao Dịch";
            this.chartxuhuong.Series.Add(series1);
            this.chartxuhuong.Size = new System.Drawing.Size(430, 428);
            this.chartxuhuong.TabIndex = 2;
            this.chartxuhuong.Text = "chart1";
            // 
            // frmhanhvikh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 459);
            this.Controls.Add(this.chartxuhuong);
            this.Controls.Add(this.dgvphankhuc);
            this.Controls.Add(this.dgvthongke);
            this.Name = "frmhanhvikh";
            this.Text = "HÀNH VI KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmhanhvikh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphankhuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartxuhuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvthongke;
        private System.Windows.Forms.DataGridView dgvphankhuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartxuhuong;
    }
}