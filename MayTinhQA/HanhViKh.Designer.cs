
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvthongke = new System.Windows.Forms.DataGridView();
            this.dgvphankhuc = new System.Windows.Forms.DataGridView();
            this.chartgiaodich = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartphankhuc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphankhuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartgiaodich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartphankhuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvthongke
            // 
            this.dgvthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongke.Location = new System.Drawing.Point(12, 12);
            this.dgvthongke.Name = "dgvthongke";
            this.dgvthongke.RowHeadersWidth = 62;
            this.dgvthongke.RowTemplate.Height = 28;
            this.dgvthongke.Size = new System.Drawing.Size(445, 211);
            this.dgvthongke.TabIndex = 0;
            // 
            // dgvphankhuc
            // 
            this.dgvphankhuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphankhuc.Location = new System.Drawing.Point(547, 12);
            this.dgvphankhuc.Name = "dgvphankhuc";
            this.dgvphankhuc.RowHeadersWidth = 62;
            this.dgvphankhuc.RowTemplate.Height = 28;
            this.dgvphankhuc.Size = new System.Drawing.Size(445, 211);
            this.dgvphankhuc.TabIndex = 1;
            // 
            // chartgiaodich
            // 
            chartArea1.Name = "ChartArea1";
            this.chartgiaodich.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartgiaodich.Legends.Add(legend1);
            this.chartgiaodich.Location = new System.Drawing.Point(12, 230);
            this.chartgiaodich.Name = "chartgiaodich";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số Giao Dịch";
            this.chartgiaodich.Series.Add(series1);
            this.chartgiaodich.Size = new System.Drawing.Size(445, 211);
            this.chartgiaodich.TabIndex = 2;
            this.chartgiaodich.Text = "chart1";
            // 
            // chartphankhuc
            // 
            chartArea2.Name = "ChartArea1";
            this.chartphankhuc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartphankhuc.Legends.Add(legend2);
            this.chartphankhuc.Location = new System.Drawing.Point(547, 224);
            this.chartphankhuc.Name = "chartphankhuc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Phân Khúc Khách Hàng";
            this.chartphankhuc.Series.Add(series2);
            this.chartphankhuc.Size = new System.Drawing.Size(445, 217);
            this.chartphankhuc.TabIndex = 3;
            this.chartphankhuc.Text = "chart1";
            // 
            // frmhanhvikh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 459);
            this.Controls.Add(this.chartphankhuc);
            this.Controls.Add(this.chartgiaodich);
            this.Controls.Add(this.dgvphankhuc);
            this.Controls.Add(this.dgvthongke);
            this.Name = "frmhanhvikh";
            this.Text = "HÀNH VI KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmhanhvikh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphankhuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartgiaodich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartphankhuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvthongke;
        private System.Windows.Forms.DataGridView dgvphankhuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartgiaodich;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartphankhuc;
    }
}