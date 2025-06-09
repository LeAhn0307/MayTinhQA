
namespace MayTinhQA
{
    partial class frmhanhvi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartphankhuc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartgiaodich = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvphankhuc = new System.Windows.Forms.DataGridView();
            this.dgvthongke = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartphankhuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartgiaodich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphankhuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).BeginInit();
            this.SuspendLayout();
            // 
            // chartphankhuc
            // 
            chartArea3.Name = "ChartArea1";
            this.chartphankhuc.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartphankhuc.Legends.Add(legend3);
            this.chartphankhuc.Location = new System.Drawing.Point(619, 235);
            this.chartphankhuc.Name = "chartphankhuc";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Phân Khúc Khách Hàng";
            this.chartphankhuc.Series.Add(series3);
            this.chartphankhuc.Size = new System.Drawing.Size(445, 217);
            this.chartphankhuc.TabIndex = 7;
            this.chartphankhuc.Text = "chart1";
            // 
            // chartgiaodich
            // 
            chartArea4.Name = "ChartArea1";
            this.chartgiaodich.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartgiaodich.Legends.Add(legend4);
            this.chartgiaodich.Location = new System.Drawing.Point(84, 241);
            this.chartgiaodich.Name = "chartgiaodich";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Số Giao Dịch";
            this.chartgiaodich.Series.Add(series4);
            this.chartgiaodich.Size = new System.Drawing.Size(445, 211);
            this.chartgiaodich.TabIndex = 6;
            this.chartgiaodich.Text = "chart1";
            // 
            // dgvphankhuc
            // 
            this.dgvphankhuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphankhuc.Location = new System.Drawing.Point(619, 23);
            this.dgvphankhuc.Name = "dgvphankhuc";
            this.dgvphankhuc.RowHeadersWidth = 62;
            this.dgvphankhuc.RowTemplate.Height = 28;
            this.dgvphankhuc.Size = new System.Drawing.Size(445, 211);
            this.dgvphankhuc.TabIndex = 5;
            // 
            // dgvthongke
            // 
            this.dgvthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongke.Location = new System.Drawing.Point(84, 23);
            this.dgvthongke.Name = "dgvthongke";
            this.dgvthongke.RowHeadersWidth = 62;
            this.dgvthongke.RowTemplate.Height = 28;
            this.dgvthongke.Size = new System.Drawing.Size(445, 211);
            this.dgvthongke.TabIndex = 4;
            // 
            // frmhanhvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 635);
            this.Controls.Add(this.chartphankhuc);
            this.Controls.Add(this.chartgiaodich);
            this.Controls.Add(this.dgvphankhuc);
            this.Controls.Add(this.dgvthongke);
            this.Name = "frmhanhvi";
            this.Text = "HÀNH VI KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmhanhvi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartphankhuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartgiaodich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphankhuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartphankhuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartgiaodich;
        private System.Windows.Forms.DataGridView dgvphankhuc;
        private System.Windows.Forms.DataGridView dgvthongke;
    }
}