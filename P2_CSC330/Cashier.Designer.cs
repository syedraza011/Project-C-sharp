namespace P2_CSC330
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CashierBox = new System.Windows.Forms.GroupBox();
            this.CustomerMenuBtn = new System.Windows.Forms.Button();
            this.ItemMenuBtn = new System.Windows.Forms.Button();
            this.CheckOutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CashierBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 329);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome to Virtual Point of Sale Systems!!";
            // 
            // CashierBox
            // 
            this.CashierBox.Controls.Add(this.CustomerMenuBtn);
            this.CashierBox.Controls.Add(this.ItemMenuBtn);
            this.CashierBox.Controls.Add(this.CheckOutBtn);
            this.CashierBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierBox.Location = new System.Drawing.Point(493, 187);
            this.CashierBox.Name = "CashierBox";
            this.CashierBox.Size = new System.Drawing.Size(521, 345);
            this.CashierBox.TabIndex = 11;
            this.CashierBox.TabStop = false;
            this.CashierBox.Text = "Cashier Menu";
            // 
            // CustomerMenuBtn
            // 
            this.CustomerMenuBtn.Location = new System.Drawing.Point(323, 197);
            this.CustomerMenuBtn.Name = "CustomerMenuBtn";
            this.CustomerMenuBtn.Size = new System.Drawing.Size(180, 100);
            this.CustomerMenuBtn.TabIndex = 2;
            this.CustomerMenuBtn.Text = "Customer Menu";
            this.CustomerMenuBtn.UseVisualStyleBackColor = true;
            this.CustomerMenuBtn.Click += new System.EventHandler(this.CustomerMenuBtn_Click);
            // 
            // ItemMenuBtn
            // 
            this.ItemMenuBtn.Location = new System.Drawing.Point(50, 197);
            this.ItemMenuBtn.Name = "ItemMenuBtn";
            this.ItemMenuBtn.Size = new System.Drawing.Size(180, 100);
            this.ItemMenuBtn.TabIndex = 1;
            this.ItemMenuBtn.Text = "Item Menu";
            this.ItemMenuBtn.UseVisualStyleBackColor = true;
            this.ItemMenuBtn.Click += new System.EventHandler(this.ItemMenuBtn_Click);
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.Location = new System.Drawing.Point(166, 59);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.Size = new System.Drawing.Size(180, 100);
            this.CheckOutBtn.TabIndex = 0;
            this.CheckOutBtn.Text = "CheckOut";
            this.CheckOutBtn.UseVisualStyleBackColor = true;
            this.CheckOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1077, 687);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CashierBox);
            this.Name = "Cashier";
            this.Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CashierBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CashierBox;
        private System.Windows.Forms.Button CustomerMenuBtn;
        private System.Windows.Forms.Button ItemMenuBtn;
        private System.Windows.Forms.Button CheckOutBtn;
    }
}