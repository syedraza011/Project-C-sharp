namespace P2_CSC330
{
    partial class Form2
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
            this.buttonInsert = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSSN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pOSEmployeesTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSEmployeeSet = new P2_CSC330.POSEmployeeSet();
            this.pOS_EmployeesTBTableAdapter = new P2_CSC330.POSEmployeeSetTableAdapters.POS_EmployeesTBTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSEmployeeDataSet = new P2_CSC330.POSEmployeeDataSet();
            this.pOSEmployeesTBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pOS_EmployeesTBTableAdapter1 = new P2_CSC330.POSEmployeeDataSetTableAdapters.POS_EmployeesTBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pOSEmployeesTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSEmployeeSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSEmployeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSEmployeesTBBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(28, 548);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(151, 67);
            this.buttonInsert.TabIndex = 1;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.txtInsert_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(244, 548);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(151, 67);
            this.ButtonEdit.TabIndex = 2;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.txtUpdate_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(485, 548);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(151, 67);
            this.ButtonRemove.TabIndex = 3;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(703, 548);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(151, 67);
            this.ButtonReset.TabIndex = 4;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(97, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(95, 39);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Name";
            // 
            // textAddress
            // 
            this.textAddress.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textAddress.Location = new System.Drawing.Point(188, 116);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(733, 75);
            this.textAddress.TabIndex = 8;
            this.textAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textName.Location = new System.Drawing.Point(188, 23);
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(551, 75);
            this.textName.TabIndex = 9;
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPhone
            // 
            this.textPhone.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textPhone.Location = new System.Drawing.Point(188, 211);
            this.textPhone.Multiline = true;
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(551, 54);
            this.textPhone.TabIndex = 11;
            this.textPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone";
            // 
            // textSSN
            // 
            this.textSSN.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textSSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSSN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textSSN.Location = new System.Drawing.Point(188, 292);
            this.textSSN.Multiline = true;
            this.textSSN.Name = "textSSN";
            this.textSSN.Size = new System.Drawing.Size(551, 54);
            this.textSSN.TabIndex = 13;
            this.textSSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "SSN";
            // 
            // textSalary
            // 
            this.textSalary.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSalary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textSalary.Location = new System.Drawing.Point(188, 361);
            this.textSalary.Multiline = true;
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(551, 75);
            this.textSalary.TabIndex = 15;
            this.textSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 54);
            this.label5.TabIndex = 14;
            this.label5.Text = "Salary";
            // 
            // pOSEmployeesTBBindingSource
            // 
            this.pOSEmployeesTBBindingSource.DataMember = "POS_EmployeesTB";
            this.pOSEmployeesTBBindingSource.DataSource = this.pOSEmployeeSet;
            // 
            // pOSEmployeeSet
            // 
            this.pOSEmployeeSet.DataSetName = "POSEmployeeSet";
            this.pOSEmployeeSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOS_EmployeesTBTableAdapter
            // 
            this.pOS_EmployeesTBTableAdapter.ClearBeforeFill = true;
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
            this.sSNDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pOSEmployeesTBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 662);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1257, 350);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
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
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // pOSEmployeeDataSet
            // 
            this.pOSEmployeeDataSet.DataSetName = "POSEmployeeDataSet";
            this.pOSEmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOSEmployeesTBBindingSource1
            // 
            this.pOSEmployeesTBBindingSource1.DataMember = "POS_EmployeesTB";
            this.pOSEmployeesTBBindingSource1.DataSource = this.pOSEmployeeDataSet;
            // 
            // pOS_EmployeesTBTableAdapter1
            // 
            this.pOS_EmployeesTBTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1440, 999);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSSN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.buttonInsert);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOSEmployeesTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSEmployeeSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSEmployeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSEmployeesTBBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSSN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.Label label5;
        private POSEmployeeSet pOSEmployeeSet;
        private System.Windows.Forms.BindingSource pOSEmployeesTBBindingSource;
        private POSEmployeeSetTableAdapters.POS_EmployeesTBTableAdapter pOS_EmployeesTBTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private POSEmployeeDataSet pOSEmployeeDataSet;
        private System.Windows.Forms.BindingSource pOSEmployeesTBBindingSource1;
        private POSEmployeeDataSetTableAdapters.POS_EmployeesTBTableAdapter pOS_EmployeesTBTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
    }
}