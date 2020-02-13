namespace P2_CSC330
{
    partial class Customer
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
            this.TextInsert = new System.Windows.Forms.Button();
            this.textUpdate = new System.Windows.Forms.Button();
            this.textRemove = new System.Windows.Forms.Button();
            this.textReset = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSpendings = new System.Windows.Forms.TextBox();
            this.txtSpending = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spendingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSCustomerTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSCustomerSet = new P2_CSC330.POSCustomerSet();
            this.pOS_CustomerTBTableAdapter = new P2_CSC330.POSCustomerSetTableAdapters.POS_CustomerTBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSCustomerTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSCustomerSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TextInsert
            // 
            this.TextInsert.Location = new System.Drawing.Point(28, 387);
            this.TextInsert.Name = "TextInsert";
            this.TextInsert.Size = new System.Drawing.Size(191, 78);
            this.TextInsert.TabIndex = 0;
            this.TextInsert.Text = "Insert";
            this.TextInsert.UseVisualStyleBackColor = true;
            this.TextInsert.Click += new System.EventHandler(this.TextInsert_Click);
            // 
            // textUpdate
            // 
            this.textUpdate.Location = new System.Drawing.Point(282, 387);
            this.textUpdate.Name = "textUpdate";
            this.textUpdate.Size = new System.Drawing.Size(191, 78);
            this.textUpdate.TabIndex = 1;
            this.textUpdate.Text = "Update";
            this.textUpdate.UseVisualStyleBackColor = true;
            this.textUpdate.Click += new System.EventHandler(this.textUpdate_Click);
            // 
            // textRemove
            // 
            this.textRemove.Location = new System.Drawing.Point(555, 387);
            this.textRemove.Name = "textRemove";
            this.textRemove.Size = new System.Drawing.Size(191, 78);
            this.textRemove.TabIndex = 2;
            this.textRemove.Text = "Remove";
            this.textRemove.UseVisualStyleBackColor = true;
            this.textRemove.Click += new System.EventHandler(this.textRemove_Click);
            // 
            // textReset
            // 
            this.textReset.Location = new System.Drawing.Point(851, 387);
            this.textReset.Name = "textReset";
            this.textReset.Size = new System.Drawing.Size(191, 78);
            this.textReset.TabIndex = 3;
            this.textReset.Text = "Reset";
            this.textReset.UseVisualStyleBackColor = true;
            this.textReset.Click += new System.EventHandler(this.textReset_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(90, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(105, 43);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(198, 56);
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(385, 63);
            this.textName.TabIndex = 5;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(198, 129);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(853, 75);
            this.textAddress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "Address";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(198, 215);
            this.textPhone.Multiline = true;
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(385, 63);
            this.textPhone.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 43);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone";
            // 
            // textSpendings
            // 
            this.textSpendings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSpendings.Font = new System.Drawing.Font("Modern No. 20", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSpendings.Location = new System.Drawing.Point(813, 220);
            this.textSpendings.Multiline = true;
            this.textSpendings.Name = "textSpendings";
            this.textSpendings.Size = new System.Drawing.Size(184, 49);
            this.textSpendings.TabIndex = 11;
            this.textSpendings.Text = "0.00";
            this.textSpendings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSpending
            // 
            this.txtSpending.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpending.Location = new System.Drawing.Point(636, 226);
            this.txtSpending.Name = "txtSpending";
            this.txtSpending.Size = new System.Drawing.Size(149, 43);
            this.txtSpending.TabIndex = 10;
            this.txtSpending.Text = "Spendings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.spendingsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pOSCustomerTBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 531);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 377);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // spendingsDataGridViewTextBoxColumn
            // 
            this.spendingsDataGridViewTextBoxColumn.DataPropertyName = "Spendings";
            this.spendingsDataGridViewTextBoxColumn.HeaderText = "Spendings";
            this.spendingsDataGridViewTextBoxColumn.Name = "spendingsDataGridViewTextBoxColumn";
            // 
            // pOSCustomerTBBindingSource
            // 
            this.pOSCustomerTBBindingSource.DataMember = "POS_CustomerTB";
            this.pOSCustomerTBBindingSource.DataSource = this.pOSCustomerSet;
            // 
            // pOSCustomerSet
            // 
            this.pOSCustomerSet.DataSetName = "POSCustomerSet";
            this.pOSCustomerSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOS_CustomerTBTableAdapter
            // 
            this.pOS_CustomerTBTableAdapter.ClearBeforeFill = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1342, 931);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textSpendings);
            this.Controls.Add(this.txtSpending);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.textReset);
            this.Controls.Add(this.textRemove);
            this.Controls.Add(this.textUpdate);
            this.Controls.Add(this.TextInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Customer";
            this.Text = "Customer Menu";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSCustomerTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSCustomerSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TextInsert;
        private System.Windows.Forms.Button textUpdate;
        private System.Windows.Forms.Button textRemove;
        private System.Windows.Forms.Button textReset;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSpendings;
        private System.Windows.Forms.Label txtSpending;
        private System.Windows.Forms.DataGridView dataGridView1;
        private POSCustomerSet pOSCustomerSet;
        private System.Windows.Forms.BindingSource pOSCustomerTBBindingSource;
        private POSCustomerSetTableAdapters.POS_CustomerTBTableAdapter pOS_CustomerTBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spendingsDataGridViewTextBoxColumn;
    }
}