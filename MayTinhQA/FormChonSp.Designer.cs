namespace MayTinhQA
{
    partial class FormChonSp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelxoatimkiem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picboxsort = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelloaitieuchi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvsanpham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BornDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnchon = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnxoatimkiem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btntimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnhuy = new Guna.UI2.WinForms.Guna2Button();
            this.picboxrs = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelloaidichvu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbloaisp = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxsort)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnxoatimkiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelxoatimkiem
            // 
            this.labelxoatimkiem.BackColor = System.Drawing.Color.Transparent;
            this.labelxoatimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelxoatimkiem.Location = new System.Drawing.Point(259, 79);
            this.labelxoatimkiem.Name = "labelxoatimkiem";
            this.labelxoatimkiem.Size = new System.Drawing.Size(11, 18);
            this.labelxoatimkiem.TabIndex = 31;
            this.labelxoatimkiem.Text = "X";
            this.labelxoatimkiem.Visible = false;
            this.labelxoatimkiem.Click += new System.EventHandler(this.labelxoatimkiem_Click);
            // 
            // picboxsort
            // 
            this.picboxsort.Image = global::MayTinhQA.Properties.Resources.sort;
            this.picboxsort.ImageRotate = 0F;
            this.picboxsort.Location = new System.Drawing.Point(185, 124);
            this.picboxsort.Name = "picboxsort";
            this.picboxsort.Size = new System.Drawing.Size(23, 27);
            this.picboxsort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxsort.TabIndex = 30;
            this.picboxsort.TabStop = false;
            this.picboxsort.Click += new System.EventHandler(this.picboxsort_Click);
            // 
            // labelloaitieuchi
            // 
            this.labelloaitieuchi.BackColor = System.Drawing.Color.Transparent;
            this.labelloaitieuchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloaitieuchi.Location = new System.Drawing.Point(143, 124);
            this.labelloaitieuchi.Name = "labelloaitieuchi";
            this.labelloaitieuchi.Size = new System.Drawing.Size(11, 18);
            this.labelloaitieuchi.TabIndex = 29;
            this.labelloaitieuchi.Text = "X";
            this.labelloaitieuchi.Visible = false;
            this.labelloaitieuchi.Click += new System.EventHandler(this.labelloaitieuchi_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
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
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(836, 50);
            this.guna2GradientPanel1.TabIndex = 27;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(9, 15);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(134, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Chọn sản phẩm";
            // 
            // Action
            // 
            this.Action.HeaderText = "";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.Width = 125;
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
            this.cbbFilter.Location = new System.Drawing.Point(0, 115);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.Size = new System.Drawing.Size(179, 36);
            this.cbbFilter.TabIndex = 28;
            this.cbbFilter.SelectedIndexChanged += new System.EventHandler(this.cbbFilter_SelectedIndexChanged);
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvsanpham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvsanpham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvsanpham.ColumnHeadersHeight = 35;
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.BornDate,
            this.Address,
            this.PhoneNumber,
            this.Email});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsanpham.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvsanpham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.dgvsanpham.Location = new System.Drawing.Point(0, 225);
            this.dgvsanpham.Margin = new System.Windows.Forms.Padding(2);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsanpham.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvsanpham.RowHeadersVisible = false;
            this.dgvsanpham.RowHeadersWidth = 48;
            this.dgvsanpham.RowTemplate.Height = 24;
            this.dgvsanpham.Size = new System.Drawing.Size(835, 304);
            this.dgvsanpham.TabIndex = 25;
            this.dgvsanpham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvsanpham.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvsanpham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvsanpham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvsanpham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvsanpham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvsanpham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.dgvsanpham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvsanpham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvsanpham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvsanpham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvsanpham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvsanpham.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvsanpham.ThemeStyle.ReadOnly = false;
            this.dgvsanpham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvsanpham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvsanpham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvsanpham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvsanpham.ThemeStyle.RowsStyle.Height = 24;
            this.dgvsanpham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvsanpham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvsanpham.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellValueChanged);
            this.dgvsanpham.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvsanpham_DataBindingComplete);
            this.dgvsanpham.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvsanpham_Paint);
            this.dgvsanpham.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvsanpham_MouseClick);
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Mã khách hàng";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Tên khách hàng";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            // 
            // BornDate
            // 
            this.BornDate.HeaderText = "Ngày sinh";
            this.BornDate.MinimumWidth = 6;
            this.BornDate.Name = "BornDate";
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Số điện thoại";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
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
            this.btnchon.Location = new System.Drawing.Point(670, 56);
            this.btnchon.Margin = new System.Windows.Forms.Padding(2);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(78, 41);
            this.btnchon.TabIndex = 22;
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
            this.txtSearch.Location = new System.Drawing.Point(0, 67);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(280, 41);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnxoatimkiem
            // 
            this.btnxoatimkiem.Image = global::MayTinhQA.Properties.Resources.xoa;
            this.btnxoatimkiem.ImageRotate = 0F;
            this.btnxoatimkiem.Location = new System.Drawing.Point(244, 77);
            this.btnxoatimkiem.Name = "btnxoatimkiem";
            this.btnxoatimkiem.Size = new System.Drawing.Size(26, 20);
            this.btnxoatimkiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnxoatimkiem.TabIndex = 26;
            this.btnxoatimkiem.TabStop = false;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BorderRadius = 12;
            this.btntimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntimkiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.Color.White;
            this.btntimkiem.Location = new System.Drawing.Point(285, 67);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(101, 41);
            this.btntimkiem.TabIndex = 23;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
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
            this.btnhuy.Location = new System.Drawing.Point(752, 56);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(78, 41);
            this.btnhuy.TabIndex = 24;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // picboxrs
            // 
            this.picboxrs.FillColor = System.Drawing.SystemColors.Control;
            this.picboxrs.Image = global::MayTinhQA.Properties.Resources.reset;
            this.picboxrs.ImageRotate = 0F;
            this.picboxrs.Location = new System.Drawing.Point(214, 124);
            this.picboxrs.Name = "picboxrs";
            this.picboxrs.Size = new System.Drawing.Size(24, 27);
            this.picboxrs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxrs.TabIndex = 32;
            this.picboxrs.TabStop = false;
            this.picboxrs.Visible = false;
            this.picboxrs.Click += new System.EventHandler(this.picboxrs_Click);
            // 
            // labelloaidichvu
            // 
            this.labelloaidichvu.BackColor = System.Drawing.Color.Transparent;
            this.labelloaidichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloaidichvu.Location = new System.Drawing.Point(143, 166);
            this.labelloaidichvu.Name = "labelloaidichvu";
            this.labelloaidichvu.Size = new System.Drawing.Size(11, 18);
            this.labelloaidichvu.TabIndex = 34;
            this.labelloaidichvu.Text = "X";
            this.labelloaidichvu.Visible = false;
            this.labelloaidichvu.Click += new System.EventHandler(this.labelloaidichvu_Click);
            // 
            // cbbloaisp
            // 
            this.cbbloaisp.BackColor = System.Drawing.Color.Transparent;
            this.cbbloaisp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.cbbloaisp.BorderRadius = 12;
            this.cbbloaisp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbloaisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbloaisp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbloaisp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbloaisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbbloaisp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbloaisp.ItemHeight = 30;
            this.cbbloaisp.Location = new System.Drawing.Point(0, 157);
            this.cbbloaisp.Name = "cbbloaisp";
            this.cbbloaisp.Size = new System.Drawing.Size(179, 36);
            this.cbbloaisp.TabIndex = 33;
            this.cbbloaisp.SelectedIndexChanged += new System.EventHandler(this.cbbloaisp_SelectedIndexChanged);
            // 
            // FormChonSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 530);
            this.Controls.Add(this.labelloaidichvu);
            this.Controls.Add(this.cbbloaisp);
            this.Controls.Add(this.picboxrs);
            this.Controls.Add(this.labelxoatimkiem);
            this.Controls.Add(this.picboxsort);
            this.Controls.Add(this.labelloaitieuchi);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.cbbFilter);
            this.Controls.Add(this.dgvsanpham);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnxoatimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnhuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChonSp";
            this.Text = "FormChonSp";
            this.Load += new System.EventHandler(this.FormChonSp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxsort)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnxoatimkiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labelxoatimkiem;
        private Guna.UI2.WinForms.Guna2PictureBox picboxsort;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelloaitieuchi;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private Guna.UI2.WinForms.Guna2ComboBox cbbFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BornDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private Guna.UI2.WinForms.Guna2Button btnchon;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2PictureBox btnxoatimkiem;
        private Guna.UI2.WinForms.Guna2Button btntimkiem;
        private Guna.UI2.WinForms.Guna2Button btnhuy;
        private Guna.UI2.WinForms.Guna2PictureBox picboxrs;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelloaidichvu;
        private Guna.UI2.WinForms.Guna2ComboBox cbbloaisp;
    }
}