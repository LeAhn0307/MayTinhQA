namespace MayTinhQA
{
    partial class FormChonNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picboxrs = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picboxsort = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelloaitieuchi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelxoatimkiem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvnhanvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnchon = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnhuy = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxsort)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxrs
            // 
            this.picboxrs.FillColor = System.Drawing.SystemColors.Control;
            this.picboxrs.Image = global::MayTinhQA.Properties.Resources.reset;
            this.picboxrs.ImageRotate = 0F;
            this.picboxrs.Location = new System.Drawing.Point(287, 143);
            this.picboxrs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxrs.Name = "picboxrs";
            this.picboxrs.Size = new System.Drawing.Size(32, 33);
            this.picboxrs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxrs.TabIndex = 32;
            this.picboxrs.TabStop = false;
            this.picboxrs.Visible = false;
            this.picboxrs.Click += new System.EventHandler(this.picboxrs_Click);
            // 
            // picboxsort
            // 
            this.picboxsort.Image = global::MayTinhQA.Properties.Resources.sort;
            this.picboxsort.ImageRotate = 0F;
            this.picboxsort.Location = new System.Drawing.Point(248, 143);
            this.picboxsort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxsort.Name = "picboxsort";
            this.picboxsort.Size = new System.Drawing.Size(31, 33);
            this.picboxsort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxsort.TabIndex = 30;
            this.picboxsort.TabStop = false;
            this.picboxsort.Click += new System.EventHandler(this.picboxsort_Click);
            // 
            // labelloaitieuchi
            // 
            this.labelloaitieuchi.BackColor = System.Drawing.Color.Transparent;
            this.labelloaitieuchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloaitieuchi.Location = new System.Drawing.Point(192, 143);
            this.labelloaitieuchi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelloaitieuchi.Name = "labelloaitieuchi";
            this.labelloaitieuchi.Size = new System.Drawing.Size(14, 22);
            this.labelloaitieuchi.TabIndex = 29;
            this.labelloaitieuchi.Text = "X";
            this.labelloaitieuchi.Visible = false;
            this.labelloaitieuchi.Click += new System.EventHandler(this.labelloaitieuchi_Click);
            // 
            // cbbFilter
            // 
            this.cbbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbbFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.cbbFilter.BorderRadius = 12;
            this.cbbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbFilter.ItemHeight = 30;
            this.cbbFilter.Location = new System.Drawing.Point(1, 132);
            this.cbbFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.Size = new System.Drawing.Size(237, 36);
            this.cbbFilter.TabIndex = 28;
            this.cbbFilter.SelectedIndexChanged += new System.EventHandler(this.cbbFilter_SelectedIndexChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.guna2GradientPanel1.Controls.Add(this.labelName);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(545, 62);
            this.guna2GradientPanel1.TabIndex = 27;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(12, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(164, 25);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Chọn nhân viên";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // Action
            // 
            this.Action.HeaderText = "";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.Width = 125;
            // 
            // labelxoatimkiem
            // 
            this.labelxoatimkiem.BackColor = System.Drawing.Color.Transparent;
            this.labelxoatimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelxoatimkiem.Location = new System.Drawing.Point(287, 89);
            this.labelxoatimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelxoatimkiem.Name = "labelxoatimkiem";
            this.labelxoatimkiem.Size = new System.Drawing.Size(14, 22);
            this.labelxoatimkiem.TabIndex = 31;
            this.labelxoatimkiem.Text = "X";
            this.labelxoatimkiem.Visible = false;
            this.labelxoatimkiem.Click += new System.EventHandler(this.labelxoatimkiem_Click);
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvnhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvnhanvien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvnhanvien.ColumnHeadersHeight = 35;
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvnhanvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvnhanvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.dgvnhanvien.Location = new System.Drawing.Point(0, 213);
            this.dgvnhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnhanvien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvnhanvien.RowHeadersVisible = false;
            this.dgvnhanvien.RowHeadersWidth = 48;
            this.dgvnhanvien.RowTemplate.Height = 24;
            this.dgvnhanvien.Size = new System.Drawing.Size(545, 283);
            this.dgvnhanvien.TabIndex = 13;
            this.dgvnhanvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvnhanvien.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvnhanvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvnhanvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvnhanvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvnhanvien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvnhanvien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.dgvnhanvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvnhanvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvnhanvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvnhanvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvnhanvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvnhanvien.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvnhanvien.ThemeStyle.ReadOnly = false;
            this.dgvnhanvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvnhanvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvnhanvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvnhanvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvnhanvien.ThemeStyle.RowsStyle.Height = 24;
            this.dgvnhanvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvnhanvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvnhanvien.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellValueChanged);
            this.dgvnhanvien.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvnhanvien_ColumnHeaderMouseClick);
            this.dgvnhanvien.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvnhanvien_DataBindingComplete);
            this.dgvnhanvien.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvnhanvien_Paint);
            this.dgvnhanvien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvnhanvien_MouseClick);
            // 
            // btnchon
            // 
            this.btnchon.BorderRadius = 12;
            this.btnchon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnchon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnchon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnchon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnchon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btnchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.ForeColor = System.Drawing.Color.White;
            this.btnchon.Location = new System.Drawing.Point(15, 521);
            this.btnchon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(104, 50);
            this.btnchon.TabIndex = 23;
            this.btnchon.Text = "Chọn";
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.txtSearch.BorderRadius = 12;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(1, 73);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(317, 50);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(345, 73);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(135, 50);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Text = "Tìm kiếm";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BorderRadius = 12;
            this.btnhuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhuy.FillColor = System.Drawing.Color.Red;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.ForeColor = System.Drawing.Color.White;
            this.btnhuy.Location = new System.Drawing.Point(136, 521);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(104, 50);
            this.btnhuy.TabIndex = 25;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // FormChonNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 585);
            this.Controls.Add(this.dgvnhanvien);
            this.Controls.Add(this.picboxrs);
            this.Controls.Add(this.picboxsort);
            this.Controls.Add(this.labelloaitieuchi);
            this.Controls.Add(this.cbbFilter);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.labelxoatimkiem);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnhuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChonNhanVien";
            this.Text = "FormChonNhanVien";
            this.Load += new System.EventHandler(this.FormChonNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxsort)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picboxrs;
        private Guna.UI2.WinForms.Guna2PictureBox picboxsort;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelloaitieuchi;
        private Guna.UI2.WinForms.Guna2ComboBox cbbFilter;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelxoatimkiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvnhanvien;
        private Guna.UI2.WinForms.Guna2Button btnchon;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnhuy;
    }
}