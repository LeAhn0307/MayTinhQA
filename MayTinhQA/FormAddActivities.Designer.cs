namespace MayTinhQA
{
    partial class FormAddActivities
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.comboBoxldv = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpngaytao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtiddichvu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttennhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendichvu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnluu = new Guna.UI2.WinForms.Guna2Button();
            this.btnhuy = new Guna.UI2.WinForms.Guna2Button();
            this.txtghichu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnchonkhachhang = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.listboxkhachhang = new System.Windows.Forms.ListBox();
            this.linkLabelnhanvien = new System.Windows.Forms.LinkLabel();
            this.tooltipnv = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.guna2GradientPanel1.Controls.Add(this.labelName);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(836, 51);
            this.guna2GradientPanel1.TabIndex = 16;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(9, 15);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(139, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Thêm hoạt động";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // comboBoxldv
            // 
            this.comboBoxldv.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxldv.BorderRadius = 12;
            this.comboBoxldv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxldv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxldv.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxldv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxldv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxldv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxldv.ItemHeight = 30;
            this.comboBoxldv.Location = new System.Drawing.Point(466, 93);
            this.comboBoxldv.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxldv.Name = "comboBoxldv";
            this.comboBoxldv.Size = new System.Drawing.Size(249, 36);
            this.comboBoxldv.TabIndex = 33;
            this.comboBoxldv.SelectedIndexChanged += new System.EventHandler(this.comboBoxldv_SelectedIndexChanged);
            // 
            // dtpngaytao
            // 
            this.dtpngaytao.BorderRadius = 10;
            this.dtpngaytao.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.dtpngaytao.Checked = true;
            this.dtpngaytao.FillColor = System.Drawing.Color.White;
            this.dtpngaytao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpngaytao.Location = new System.Drawing.Point(246, 93);
            this.dtpngaytao.Margin = new System.Windows.Forms.Padding(2);
            this.dtpngaytao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpngaytao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpngaytao.Name = "dtpngaytao";
            this.dtpngaytao.Size = new System.Drawing.Size(188, 32);
            this.dtpngaytao.TabIndex = 32;
            this.dtpngaytao.Value = new System.DateTime(2025, 5, 20, 16, 25, 25, 736);
            // 
            // txtiddichvu
            // 
            this.txtiddichvu.BorderRadius = 12;
            this.txtiddichvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtiddichvu.DefaultText = "";
            this.txtiddichvu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtiddichvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtiddichvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtiddichvu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtiddichvu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtiddichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiddichvu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtiddichvu.Location = new System.Drawing.Point(466, 201);
            this.txtiddichvu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtiddichvu.Name = "txtiddichvu";
            this.txtiddichvu.PlaceholderText = "";
            this.txtiddichvu.SelectedText = "";
            this.txtiddichvu.Size = new System.Drawing.Size(217, 32);
            this.txtiddichvu.TabIndex = 26;
            this.txtiddichvu.Visible = false;
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.BorderRadius = 12;
            this.txttennhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttennhanvien.DefaultText = "";
            this.txttennhanvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttennhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttennhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttennhanvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttennhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennhanvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttennhanvien.Location = new System.Drawing.Point(9, 159);
            this.txttennhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.PlaceholderText = "";
            this.txttennhanvien.SelectedText = "";
            this.txttennhanvien.Size = new System.Drawing.Size(217, 32);
            this.txttennhanvien.TabIndex = 24;
            this.txttennhanvien.TextChanged += new System.EventHandler(this.txttennhanvien_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(254, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ngày tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên hoạt động";
            // 
            // txttendichvu
            // 
            this.txttendichvu.BorderRadius = 12;
            this.txttendichvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttendichvu.DefaultText = "";
            this.txttendichvu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttendichvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttendichvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttendichvu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttendichvu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttendichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendichvu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttendichvu.Location = new System.Drawing.Point(9, 93);
            this.txttendichvu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttendichvu.Name = "txttendichvu";
            this.txttendichvu.PlaceholderText = "";
            this.txttendichvu.SelectedText = "";
            this.txttendichvu.Size = new System.Drawing.Size(217, 32);
            this.txttendichvu.TabIndex = 21;
            // 
            // btnluu
            // 
            this.btnluu.BorderRadius = 12;
            this.btnluu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnluu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnluu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnluu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnluu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.White;
            this.btnluu.Location = new System.Drawing.Point(13, 461);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(139, 42);
            this.btnluu.TabIndex = 35;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
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
            this.btnhuy.Location = new System.Drawing.Point(170, 461);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(101, 42);
            this.btnhuy.TabIndex = 36;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // txtghichu
            // 
            this.txtghichu.AcceptsReturn = true;
            this.txtghichu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtghichu.DefaultText = "";
            this.txtghichu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtghichu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtghichu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtghichu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtghichu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtghichu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtghichu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtghichu.Location = new System.Drawing.Point(9, 237);
            this.txtghichu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.PlaceholderText = "";
            this.txtghichu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtghichu.SelectedText = "";
            this.txtghichu.Size = new System.Drawing.Size(815, 218);
            this.txtghichu.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 216);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(475, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Loại hoạt động";
            // 
            // btnchonkhachhang
            // 
            this.btnchonkhachhang.BorderRadius = 12;
            this.btnchonkhachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnchonkhachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnchonkhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnchonkhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnchonkhachhang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btnchonkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchonkhachhang.ForeColor = System.Drawing.Color.White;
            this.btnchonkhachhang.Location = new System.Drawing.Point(465, 158);
            this.btnchonkhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.btnchonkhachhang.Name = "btnchonkhachhang";
            this.btnchonkhachhang.Size = new System.Drawing.Size(126, 30);
            this.btnchonkhachhang.TabIndex = 35;
            this.btnchonkhachhang.Text = "Chọn khách hàng";
            this.btnchonkhachhang.Click += new System.EventHandler(this.btnchonkhachhan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(254, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = " Khách hàng";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // listboxkhachhang
            // 
            this.listboxkhachhang.FormattingEnabled = true;
            this.listboxkhachhang.Location = new System.Drawing.Point(245, 158);
            this.listboxkhachhang.Name = "listboxkhachhang";
            this.listboxkhachhang.Size = new System.Drawing.Size(205, 30);
            this.listboxkhachhang.TabIndex = 39;
            this.listboxkhachhang.SelectedIndexChanged += new System.EventHandler(this.listboxkhachhang_SelectedIndexChanged);
            // 
            // linkLabelnhanvien
            // 
            this.linkLabelnhanvien.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabelnhanvien.AutoSize = true;
            this.linkLabelnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelnhanvien.ForeColor = System.Drawing.Color.Black;
            this.linkLabelnhanvien.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelnhanvien.LinkColor = System.Drawing.Color.Black;
            this.linkLabelnhanvien.Location = new System.Drawing.Point(15, 139);
            this.linkLabelnhanvien.Name = "linkLabelnhanvien";
            this.linkLabelnhanvien.Size = new System.Drawing.Size(124, 16);
            this.linkLabelnhanvien.TabIndex = 40;
            this.linkLabelnhanvien.TabStop = true;
            this.linkLabelnhanvien.Text = "Nhân viên phụ trách";
            this.linkLabelnhanvien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tooltipnv
            // 
            this.tooltipnv.AllowLinksHandling = true;
            this.tooltipnv.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // FormAddActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(836, 512);
            this.Controls.Add(this.linkLabelnhanvien);
            this.Controls.Add(this.listboxkhachhang);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnchonkhachhang);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.comboBoxldv);
            this.Controls.Add(this.dtpngaytao);
            this.Controls.Add(this.txtiddichvu);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttendichvu);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddActivities";
            this.Text = "FormAddActivities";
            this.Load += new System.EventHandler(this.FormAddActivities_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxldv;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpngaytao;
        private Guna.UI2.WinForms.Guna2TextBox txtiddichvu;
        private Guna.UI2.WinForms.Guna2TextBox txttennhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txttendichvu;
        private Guna.UI2.WinForms.Guna2Button btnluu;
        private Guna.UI2.WinForms.Guna2Button btnhuy;
        private Guna.UI2.WinForms.Guna2TextBox txtghichu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnchonkhachhang;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.ListBox listboxkhachhang;
        private System.Windows.Forms.LinkLabel linkLabelnhanvien;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tooltipnv;
    }
}