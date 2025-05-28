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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvgd = new System.Windows.Forms.DataGridView();
            this.chartgd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvpk = new System.Windows.Forms.DataGridView();
            this.chartpk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btntopcus = new Guna.UI2.WinForms.Guna2Button();
            this.txttopcus = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartgd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartpk)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvgd
            // 
            this.dgvgd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgd.Location = new System.Drawing.Point(3, 0);
            this.dgvgd.Name = "dgvgd";
            this.dgvgd.RowHeadersWidth = 62;
            this.dgvgd.RowTemplate.Height = 28;
            this.dgvgd.Size = new System.Drawing.Size(420, 320);
            this.dgvgd.TabIndex = 5;
            // 
            // chartgd
            // 
            chartArea3.Name = "ChartArea1";
            this.chartgd.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartgd.Legends.Add(legend3);
            this.chartgd.Location = new System.Drawing.Point(0, 326);
            this.chartgd.Name = "chartgd";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Số Giao Dịch";
            this.chartgd.Series.Add(series3);
            this.chartgd.Size = new System.Drawing.Size(420, 268);
            this.chartgd.TabIndex = 3;
            this.chartgd.Text = "chart1";
            // 
            // dgvpk
            // 
            this.dgvpk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpk.Location = new System.Drawing.Point(429, 0);
            this.dgvpk.Name = "dgvpk";
            this.dgvpk.RowHeadersWidth = 62;
            this.dgvpk.RowTemplate.Height = 28;
            this.dgvpk.Size = new System.Drawing.Size(394, 208);
            this.dgvpk.TabIndex = 6;
            // 
            // chartpk
            // 
            chartArea4.Name = "ChartArea1";
            this.chartpk.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartpk.Legends.Add(legend4);
            this.chartpk.Location = new System.Drawing.Point(429, 326);
            this.chartpk.Name = "chartpk";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Phân Khúc Khách Hàng";
            this.chartpk.Series.Add(series4);
            this.chartpk.Size = new System.Drawing.Size(394, 268);
            this.chartpk.TabIndex = 7;
            this.chartpk.Text = "chart1";
            // 
            // btntopcus
            // 
            this.btntopcus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntopcus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntopcus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntopcus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntopcus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btntopcus.ForeColor = System.Drawing.Color.White;
            this.btntopcus.Location = new System.Drawing.Point(429, 214);
            this.btntopcus.Name = "btntopcus";
            this.btntopcus.Size = new System.Drawing.Size(394, 48);
            this.btntopcus.TabIndex = 8;
            this.btntopcus.Text = "Khách hàng mua nhiều nhất";
            this.btntopcus.Click += new System.EventHandler(this.btntopcus_Click);
            // 
            // txttopcus
            // 
            this.txttopcus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttopcus.DefaultText = "";
            this.txttopcus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttopcus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttopcus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttopcus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttopcus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttopcus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttopcus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttopcus.Location = new System.Drawing.Point(429, 257);
            this.txttopcus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttopcus.Name = "txttopcus";
            this.txttopcus.PlaceholderText = "";
            this.txttopcus.SelectedText = "";
            this.txttopcus.Size = new System.Drawing.Size(394, 63);
            this.txttopcus.TabIndex = 9;
            this.txttopcus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UC_Behaviour
            // 
            this.Controls.Add(this.txttopcus);
            this.Controls.Add(this.btntopcus);
            this.Controls.Add(this.chartpk);
            this.Controls.Add(this.dgvpk);
            this.Controls.Add(this.dgvgd);
            this.Controls.Add(this.chartgd);
            this.Name = "UC_Behaviour";
            this.Size = new System.Drawing.Size(1282, 597);
            this.Load += new System.EventHandler(this.UC_Behaviour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartgd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartpk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartphankhuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartgiaodich;
        private System.Windows.Forms.DataGridView dgvthongke;
        private System.Windows.Forms.DataGridView dgvphankhuc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView dgvgd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartgd;
        private System.Windows.Forms.DataGridView dgvpk;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartpk;
        private Guna.UI2.WinForms.Guna2Button btntopcus;
        private Guna.UI2.WinForms.Guna2TextBox txttopcus;
    }
}
