namespace MayTinhQA.UserControls
{
    partial class UC_Email
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
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.btnChooseCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.cbTemplate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cbKhachHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAuto = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbAuto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpAutoSendTimer = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTrangThaiAuto = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGui
            // 
            this.btnGui.BorderRadius = 12;
            this.btnGui.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGui.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btnGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(83, 458);
            this.btnGui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(129, 42);
            this.btnGui.TabIndex = 23;
            this.btnGui.Text = "Gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnChooseCustomers
            // 
            this.btnChooseCustomers.BorderRadius = 12;
            this.btnChooseCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btnChooseCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseCustomers.ForeColor = System.Drawing.Color.White;
            this.btnChooseCustomers.Location = new System.Drawing.Point(425, 48);
            this.btnChooseCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseCustomers.Name = "btnChooseCustomers";
            this.btnChooseCustomers.Size = new System.Drawing.Size(248, 42);
            this.btnChooseCustomers.TabIndex = 25;
            this.btnChooseCustomers.Text = "Chọn khách hàng";
            this.btnChooseCustomers.Click += new System.EventHandler(this.btnChooseCustomers_Click);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbTemplate
            // 
            this.cbTemplate.BackColor = System.Drawing.Color.Transparent;
            this.cbTemplate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemplate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTemplate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTemplate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTemplate.ItemHeight = 30;
            this.cbTemplate.Location = new System.Drawing.Point(83, 170);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Size = new System.Drawing.Size(749, 36);
            this.cbTemplate.TabIndex = 29;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiDung.DefaultText = "";
            this.txtNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.Location = new System.Drawing.Point(83, 219);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PlaceholderText = "";
            this.txtNoiDung.SelectedText = "";
            this.txtNoiDung.Size = new System.Drawing.Size(749, 226);
            this.txtNoiDung.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(83, 97);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(749, 60);
            this.txtEmail.TabIndex = 31;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(79, 521);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(89, 20);
            this.lblTrangThai.TabIndex = 32;
            this.lblTrangThai.Text = "Trạng thái ";
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cbKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhachHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbKhachHang.ItemHeight = 30;
            this.cbKhachHang.Location = new System.Drawing.Point(83, 48);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(300, 36);
            this.cbKhachHang.TabIndex = 33;
            // 
            // btnAuto
            // 
            this.btnAuto.BorderRadius = 12;
            this.btnAuto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAuto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAuto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAuto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAuto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.ForeColor = System.Drawing.Color.White;
            this.btnAuto.Location = new System.Drawing.Point(3, 361);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(211, 42);
            this.btnAuto.TabIndex = 34;
            this.btnAuto.Text = "Tự động gửi";
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblTrangThaiAuto);
            this.guna2Panel1.Controls.Add(this.dtpAutoSendTimer);
            this.guna2Panel1.Controls.Add(this.cbAuto);
            this.guna2Panel1.Controls.Add(this.btnAuto);
            this.guna2Panel1.Location = new System.Drawing.Point(881, 97);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(355, 478);
            this.guna2Panel1.TabIndex = 36;
            // 
            // cbAuto
            // 
            this.cbAuto.BackColor = System.Drawing.Color.Transparent;
            this.cbAuto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAuto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAuto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbAuto.ItemHeight = 30;
            this.cbAuto.Location = new System.Drawing.Point(21, 73);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(315, 36);
            this.cbAuto.TabIndex = 36;
            // 
            // dtpAutoSendTimer
            // 
            this.dtpAutoSendTimer.Checked = true;
            this.dtpAutoSendTimer.FillColor = System.Drawing.Color.White;
            this.dtpAutoSendTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpAutoSendTimer.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpAutoSendTimer.Location = new System.Drawing.Point(21, 140);
            this.dtpAutoSendTimer.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAutoSendTimer.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAutoSendTimer.Name = "dtpAutoSendTimer";
            this.dtpAutoSendTimer.Size = new System.Drawing.Size(206, 36);
            this.dtpAutoSendTimer.TabIndex = 37;
            this.dtpAutoSendTimer.Value = new System.DateTime(2025, 6, 9, 11, 7, 19, 731);
            // 
            // lblTrangThaiAuto
            // 
            this.lblTrangThaiAuto.AutoSize = true;
            this.lblTrangThaiAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiAuto.Location = new System.Drawing.Point(3, 424);
            this.lblTrangThaiAuto.Name = "lblTrangThaiAuto";
            this.lblTrangThaiAuto.Size = new System.Drawing.Size(89, 20);
            this.lblTrangThaiAuto.TabIndex = 37;
            this.lblTrangThaiAuto.Text = "Trạng thái ";
            // 
            // UC_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.cbTemplate);
            this.Controls.Add(this.btnChooseCustomers);
            this.Controls.Add(this.btnGui);
            this.Name = "UC_Email";
            this.Size = new System.Drawing.Size(1282, 597);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnGui;
        private Guna.UI2.WinForms.Guna2Button btnChooseCustomers;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTemplate;
        private Guna.UI2.WinForms.Guna2TextBox txtNoiDung;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblTrangThai;
        private Guna.UI2.WinForms.Guna2ComboBox cbKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnAuto;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbAuto;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpAutoSendTimer;
        private System.Windows.Forms.Label lblTrangThaiAuto;
    }
}
