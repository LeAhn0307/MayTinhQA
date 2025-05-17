
namespace MayTinhQA
{
    partial class frmquenmk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlaylaimk = new System.Windows.Forms.Button();
            this.txtemaildangki = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(80, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email đăng kí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(80, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả";
            // 
            // btnlaylaimk
            // 
            this.btnlaylaimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlaylaimk.ForeColor = System.Drawing.Color.Navy;
            this.btnlaylaimk.Location = new System.Drawing.Point(84, 412);
            this.btnlaylaimk.Name = "btnlaylaimk";
            this.btnlaylaimk.Size = new System.Drawing.Size(342, 49);
            this.btnlaylaimk.TabIndex = 3;
            this.btnlaylaimk.Text = "Lấy lại mật khẩu";
            this.btnlaylaimk.UseVisualStyleBackColor = true;
            this.btnlaylaimk.Click += new System.EventHandler(this.btnlaylaimk_Click);
            // 
            // txtemaildangki
            // 
            this.txtemaildangki.Location = new System.Drawing.Point(190, 292);
            this.txtemaildangki.Multiline = true;
            this.txtemaildangki.Name = "txtemaildangki";
            this.txtemaildangki.Size = new System.Drawing.Size(236, 37);
            this.txtemaildangki.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MayTinhQA.Properties.Resources.quenmk_icon;
            this.pictureBox1.Location = new System.Drawing.Point(84, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmquenmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 512);
            this.Controls.Add(this.txtemaildangki);
            this.Controls.Add(this.btnlaylaimk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmquenmk";
            this.Text = "QUÊN MẬT KHẨU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlaylaimk;
        private System.Windows.Forms.TextBox txtemaildangki;
    }
}