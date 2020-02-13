namespace P2_CSC330
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.ItemMenuBtn = new System.Windows.Forms.Button();
            this.CutomerMenuBtn = new System.Windows.Forms.Button();
            this.EmployeeMenuBtn = new System.Windows.Forms.Button();
            this.AdminBox = new System.Windows.Forms.GroupBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.AutoSize = true;
            this.checkOutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkOutBtn.Location = new System.Drawing.Point(36, 65);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(180, 100);
            this.checkOutBtn.TabIndex = 0;
            this.checkOutBtn.Text = "CheckOut";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.UseWaitCursor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // ItemMenuBtn
            // 
            this.ItemMenuBtn.Location = new System.Drawing.Point(292, 65);
            this.ItemMenuBtn.Name = "ItemMenuBtn";
            this.ItemMenuBtn.Size = new System.Drawing.Size(180, 100);
            this.ItemMenuBtn.TabIndex = 1;
            this.ItemMenuBtn.Text = "Item Menu";
            this.ItemMenuBtn.UseVisualStyleBackColor = true;
            this.ItemMenuBtn.Click += new System.EventHandler(this.ItemMenuBtn_Click);
            // 
            // CutomerMenuBtn
            // 
            this.CutomerMenuBtn.Location = new System.Drawing.Point(36, 194);
            this.CutomerMenuBtn.Name = "CutomerMenuBtn";
            this.CutomerMenuBtn.Size = new System.Drawing.Size(180, 100);
            this.CutomerMenuBtn.TabIndex = 2;
            this.CutomerMenuBtn.Text = "Customer Menu";
            this.CutomerMenuBtn.UseVisualStyleBackColor = true;
            this.CutomerMenuBtn.Click += new System.EventHandler(this.CutomerMenuBtn_Click);
            // 
            // EmployeeMenuBtn
            // 
            this.EmployeeMenuBtn.Location = new System.Drawing.Point(292, 194);
            this.EmployeeMenuBtn.Name = "EmployeeMenuBtn";
            this.EmployeeMenuBtn.Size = new System.Drawing.Size(180, 100);
            this.EmployeeMenuBtn.TabIndex = 3;
            this.EmployeeMenuBtn.Text = "Employee Menu";
            this.EmployeeMenuBtn.UseVisualStyleBackColor = true;
            this.EmployeeMenuBtn.Click += new System.EventHandler(this.EmployeeMenuBtn_Click);
            // 
            // AdminBox
            // 
            this.AdminBox.Controls.Add(this.EmployeeMenuBtn);
            this.AdminBox.Controls.Add(this.CutomerMenuBtn);
            this.AdminBox.Controls.Add(this.ItemMenuBtn);
            this.AdminBox.Controls.Add(this.checkOutBtn);
            this.AdminBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBox.Location = new System.Drawing.Point(470, 204);
            this.AdminBox.Name = "AdminBox";
            this.AdminBox.Size = new System.Drawing.Size(578, 363);
            this.AdminBox.TabIndex = 4;
            this.AdminBox.TabStop = false;
            this.AdminBox.Text = "Administrator Menu";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(133, 19);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(681, 52);
            this.WelcomeLabel.TabIndex = 5;
            this.WelcomeLabel.Text = "Welcome to Virtual Point of Sale Systems!!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 363);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1060, 774);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.AdminBox);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.AdminBox.ResumeLayout(false);
            this.AdminBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.Button ItemMenuBtn;
        private System.Windows.Forms.Button CutomerMenuBtn;
        private System.Windows.Forms.Button EmployeeMenuBtn;
        private System.Windows.Forms.GroupBox AdminBox;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}