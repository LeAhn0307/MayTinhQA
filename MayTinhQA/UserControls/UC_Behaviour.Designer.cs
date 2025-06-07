namespace MayTinhQA.UserControls
{
    partial class UC_Behaviour
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartpk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvgd = new System.Windows.Forms.DataGridView();
            this.chartgd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvpk = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartpk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartgd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpk)).BeginInit();
            this.SuspendLayout();
            // 
            // chartpk
            // 
            chartArea1.Name = "ChartArea1";
            this.chartpk.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartpk.Legends.Add(legend1);
            this.chartpk.Location = new System.Drawing.Point(482, 223);
            this.chartpk.Name = "chartpk";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Phân Khúc Khách Hàng";
            this.chartpk.Series.Add(series1);
            this.chartpk.Size = new System.Drawing.Size(460, 268);
            this.chartpk.TabIndex = 4;
            this.chartpk.Text = "chart2";
            // 
            // dgvgd
            // 
            this.dgvgd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgd.Location = new System.Drawing.Point(3, 0);
            this.dgvgd.Name = "dgvgd";
            this.dgvgd.RowHeadersWidth = 62;
            this.dgvgd.RowTemplate.Height = 28;
            this.dgvgd.Size = new System.Drawing.Size(460, 208);
            this.dgvgd.TabIndex = 5;
            // 
            // chartgd
            // 
            chartArea2.Name = "ChartArea1";
            this.chartgd.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartgd.Legends.Add(legend2);
            this.chartgd.Location = new System.Drawing.Point(3, 223);
            this.chartgd.Name = "chartgd";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Số Giao Dịch";
            this.chartgd.Series.Add(series2);
            this.chartgd.Size = new System.Drawing.Size(460, 268);
            this.chartgd.TabIndex = 3;
            this.chartgd.Text = "chart1";
            // 
            // dgvpk
            // 
            this.dgvpk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpk.Location = new System.Drawing.Point(482, 0);
            this.dgvpk.Name = "dgvpk";
            this.dgvpk.RowHeadersWidth = 62;
            this.dgvpk.RowTemplate.Height = 28;
            this.dgvpk.Size = new System.Drawing.Size(460, 208);
            this.dgvpk.TabIndex = 6;
            // 
            // UC_Behaviour
            // 
            this.Controls.Add(this.dgvpk);
            this.Controls.Add(this.dgvgd);
            this.Controls.Add(this.chartpk);
            this.Controls.Add(this.chartgd);
            this.Name = "UC_Behaviour";
            this.Size = new System.Drawing.Size(1015, 541);
            this.Load += new System.EventHandler(this.UC_Behaviour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartpk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartgd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartphankhuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartgiaodich;
        private System.Windows.Forms.DataGridView dgvthongke;
        private System.Windows.Forms.DataGridView dgvphankhuc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartpk;
        private System.Windows.Forms.DataGridView dgvgd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartgd;
        private System.Windows.Forms.DataGridView dgvpk;
    }
}
