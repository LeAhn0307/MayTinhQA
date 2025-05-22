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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartphankhuc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartgiaodich = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvthongke = new System.Windows.Forms.DataGridView();
            this.dgvphankhuc = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartphankhuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartgiaodich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphankhuc)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartphankhuc
            // 
            chartArea9.Name = "ChartArea1";
            this.chartphankhuc.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartphankhuc.Legends.Add(legend9);
            this.chartphankhuc.Location = new System.Drawing.Point(700, 328);
            this.chartphankhuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartphankhuc.Name = "chartphankhuc";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Legend = "Legend1";
            series9.Name = "Phân Khúc Khách Hàng";
            this.chartphankhuc.Series.Add(series9);
            this.chartphankhuc.Size = new System.Drawing.Size(465, 192);
            this.chartphankhuc.TabIndex = 4;
            this.chartphankhuc.Text = "chart1";
            // 
            // chartgiaodich
            // 
            chartArea10.Name = "ChartArea1";
            this.chartgiaodich.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartgiaodich.Legends.Add(legend10);
            this.chartgiaodich.Location = new System.Drawing.Point(52, 333);
            this.chartgiaodich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartgiaodich.Name = "chartgiaodich";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Số Giao Dịch";
            this.chartgiaodich.Series.Add(series10);
            this.chartgiaodich.Size = new System.Drawing.Size(487, 187);
            this.chartgiaodich.TabIndex = 5;
            this.chartgiaodich.Text = "chart1";
            // 
            // dgvthongke
            // 
            this.dgvthongke.BackgroundColor = System.Drawing.Color.White;
            this.dgvthongke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongke.Location = new System.Drawing.Point(37, 24);
            this.dgvthongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvthongke.Name = "dgvthongke";
            this.dgvthongke.RowHeadersWidth = 62;
            this.dgvthongke.RowTemplate.Height = 28;
            this.dgvthongke.Size = new System.Drawing.Size(487, 262);
            this.dgvthongke.TabIndex = 6;
            // 
            // dgvphankhuc
            // 
            this.dgvphankhuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvphankhuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvphankhuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphankhuc.Location = new System.Drawing.Point(50, 24);
            this.dgvphankhuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvphankhuc.Name = "dgvphankhuc";
            this.dgvphankhuc.RowHeadersWidth = 62;
            this.dgvphankhuc.RowTemplate.Height = 28;
            this.dgvphankhuc.Size = new System.Drawing.Size(465, 262);
            this.dgvphankhuc.TabIndex = 7;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dgvphankhuc);
            this.guna2Panel1.Location = new System.Drawing.Point(641, 13);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(565, 539);
            this.guna2Panel1.TabIndex = 8;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvthongke);
            this.guna2Panel2.Location = new System.Drawing.Point(15, 13);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(590, 539);
            this.guna2Panel2.TabIndex = 9;
            // 
            // UC_Behaviour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chartgiaodich);
            this.Controls.Add(this.chartphankhuc);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "UC_Behaviour";
            this.Size = new System.Drawing.Size(1282, 597);
            ((System.ComponentModel.ISupportInitialize)(this.chartphankhuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartgiaodich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphankhuc)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartphankhuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartgiaodich;
        private System.Windows.Forms.DataGridView dgvthongke;
        private System.Windows.Forms.DataGridView dgvphankhuc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
