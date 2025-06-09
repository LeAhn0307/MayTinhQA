namespace MayTinhQA
{
    partial class FormEmail
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxKhachHang = new System.Windows.Forms.ComboBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.labelName);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1010, 78);
            this.guna2GradientPanel1.TabIndex = 16;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::MayTinhQA.Properties.Resources.white_cross;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(966, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(39, 43);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(14, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(146, 29);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Soạn Email";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(14, 370);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(842, 255);
            this.txtMessage.TabIndex = 18;
            this.txtMessage.Text = "";
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
            this.btnGui.Location = new System.Drawing.Point(20, 663);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(208, 63);
            this.btnGui.TabIndex = 20;
            this.btnGui.Text = "Gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // comboBoxKhachHang
            // 
            this.comboBoxKhachHang.FormattingEnabled = true;
            this.comboBoxKhachHang.Location = new System.Drawing.Point(14, 104);
            this.comboBoxKhachHang.Name = "comboBoxKhachHang";
            this.comboBoxKhachHang.Size = new System.Drawing.Size(180, 28);
            this.comboBoxKhachHang.TabIndex = 21;
            // 
            // FormEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 783);
            this.Controls.Add(this.comboBoxKhachHang);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmail";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.RichTextBox txtMessage;
        private Guna.UI2.WinForms.Guna2Button btnGui;
        private System.Windows.Forms.ComboBox comboBoxKhachHang;
    }
}