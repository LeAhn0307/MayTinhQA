namespace MayTinhQA.UserControls
{
    partial class UC_Home
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 

            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(310, 247);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(613, 25);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Phần mềm Quản lý quan hệ khách hàng của công ty Quang Anh";
            // 

            // UC_Home
            // 
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1282, 597);
            this.ResumeLayout(false);

        }
    }
}
