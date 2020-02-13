namespace P2_CSC330
{
    partial class CheckOut
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
            this.btnClear = new System.Windows.Forms.Button();
            this.BackSpace = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.QuickItemMenuBtn = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.textBoxTotalDue = new System.Windows.Forms.TextBox();
            this.labelAmountDue = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.textItemSearch = new System.Windows.Forms.TextBox();
            this.labelDisc = new System.Windows.Forms.Label();
            this.One = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelF3 = new System.Windows.Forms.Label();
            this.Two = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.qunatityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSCheckoutTBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pOSCheckoutDataSet = new P2_CSC330.POSCheckoutDataSet();
            this.Three = new System.Windows.Forms.Button();
            this.labelUnitprice = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.txtNetPrice = new System.Windows.Forms.TextBox();
            this.labelNetPrice = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.BoxforTotal = new System.Windows.Forms.GroupBox();
            this.texTotalCount = new System.Windows.Forms.TextBox();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.labelPayment = new System.Windows.Forms.Label();
            this.textBoxTotalPayment = new System.Windows.Forms.TextBox();
            this.textTotalTax = new System.Windows.Forms.TextBox();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelChangeDue = new System.Windows.Forms.Label();
            this.textBoxTotalChange = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxTotalDiscount = new System.Windows.Forms.TextBox();
            this.F5Btn = new System.Windows.Forms.Button();
            this.F6Btn = new System.Windows.Forms.Button();
            this.QuickCutsomerMenuBtn = new System.Windows.Forms.Button();
            this.pOSCheckoutTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOS_CheckoutTBTableAdapter = new P2_CSC330.POSCheckoutDataSetTableAdapters.POS_CheckoutTBTableAdapter();
            this.F4Btn = new System.Windows.Forms.Button();
            this.F7Btn = new System.Windows.Forms.Button();
            this.F9Btn = new System.Windows.Forms.Button();
            this.F8Btn = new System.Windows.Forms.Button();
            this.RemoveItemBtn = new System.Windows.Forms.Button();
            this.txtCusSpendings = new System.Windows.Forms.TextBox();
            this.labelCusSpendings = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.labelCusName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchCustomerBtn = new System.Windows.Forms.Button();
            this.lblCustId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSCheckoutTBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSCheckoutDataSet)).BeginInit();
            this.BoxforTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSCheckoutTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(839, 435);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 25);
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BackSpace
            // 
            this.BackSpace.Location = new System.Drawing.Point(150, 285);
            this.BackSpace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(45, 47);
            this.BackSpace.TabIndex = 52;
            this.BackSpace.Text = "Back";
            this.BackSpace.UseVisualStyleBackColor = true;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(57, 286);
            this.Enter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(45, 47);
            this.Enter.TabIndex = 49;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(103, 286);
            this.ClearAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(45, 47);
            this.ClearAll.TabIndex = 48;
            this.ClearAll.Text = "Clear";
            this.ClearAll.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(10, 286);
            this.Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(46, 47);
            this.Clear.TabIndex = 45;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.Location = new System.Drawing.Point(100, 304);
            this.PaymentBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(124, 49);
            this.PaymentBtn.TabIndex = 43;
            this.PaymentBtn.Text = "Payment";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // PlusMinus
            // 
            this.PlusMinus.Location = new System.Drawing.Point(150, 235);
            this.PlusMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(45, 47);
            this.PlusMinus.TabIndex = 41;
            this.PlusMinus.Text = "+/-";
            this.PlusMinus.UseVisualStyleBackColor = true;
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(57, 235);
            this.Zero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(45, 47);
            this.Zero.TabIndex = 40;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(103, 235);
            this.Stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(45, 47);
            this.Stop.TabIndex = 39;
            this.Stop.Text = ".";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(10, 235);
            this.Nine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(46, 47);
            this.Nine.TabIndex = 38;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(150, 187);
            this.Eight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(45, 47);
            this.Eight.TabIndex = 37;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(103, 187);
            this.Seven.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(45, 47);
            this.Seven.TabIndex = 36;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(57, 187);
            this.Six.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(45, 47);
            this.Six.TabIndex = 35;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(10, 187);
            this.Five.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(45, 47);
            this.Five.TabIndex = 34;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // QuickItemMenuBtn
            // 
            this.QuickItemMenuBtn.Location = new System.Drawing.Point(6, 71);
            this.QuickItemMenuBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuickItemMenuBtn.Name = "QuickItemMenuBtn";
            this.QuickItemMenuBtn.Size = new System.Drawing.Size(62, 65);
            this.QuickItemMenuBtn.TabIndex = 62;
            this.QuickItemMenuBtn.Text = "Quick Item Menu";
            this.QuickItemMenuBtn.UseVisualStyleBackColor = true;
            this.QuickItemMenuBtn.Click += new System.EventHandler(this.QuickItemMenuBtn_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(150, 139);
            this.Four.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(45, 47);
            this.Four.TabIndex = 33;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // textBoxTotalDue
            // 
            this.textBoxTotalDue.Location = new System.Drawing.Point(100, 156);
            this.textBoxTotalDue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTotalDue.Multiline = true;
            this.textBoxTotalDue.Name = "textBoxTotalDue";
            this.textBoxTotalDue.Size = new System.Drawing.Size(104, 38);
            this.textBoxTotalDue.TabIndex = 64;
            // 
            // labelAmountDue
            // 
            this.labelAmountDue.AutoSize = true;
            this.labelAmountDue.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountDue.Location = new System.Drawing.Point(21, 164);
            this.labelAmountDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmountDue.Name = "labelAmountDue";
            this.labelAmountDue.Size = new System.Drawing.Size(75, 17);
            this.labelAmountDue.TabIndex = 63;
            this.labelAmountDue.Text = "Net Total";
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(540, 17);
            this.txtDisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDisc.Multiline = true;
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(70, 32);
            this.txtDisc.TabIndex = 59;
            this.txtDisc.Text = "$0.00";
            this.txtDisc.TextChanged += new System.EventHandler(this.txtDisc_TextChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(464, 17);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnitPrice.Multiline = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(70, 32);
            this.txtUnitPrice.TabIndex = 58;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(390, 18);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(70, 32);
            this.txtQty.TabIndex = 57;
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtName.Location = new System.Drawing.Point(168, 18);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 32);
            this.txtName.TabIndex = 56;
            // 
            // textItemSearch
            // 
            this.textItemSearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textItemSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textItemSearch.Location = new System.Drawing.Point(5, 21);
            this.textItemSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textItemSearch.Multiline = true;
            this.textItemSearch.Name = "textItemSearch";
            this.textItemSearch.Size = new System.Drawing.Size(63, 29);
            this.textItemSearch.TabIndex = 55;
            this.textItemSearch.TextChanged += new System.EventHandler(this.textItemSearch_TextChanged);
            // 
            // labelDisc
            // 
            this.labelDisc.AutoSize = true;
            this.labelDisc.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisc.Location = new System.Drawing.Point(558, 2);
            this.labelDisc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDisc.Name = "labelDisc";
            this.labelDisc.Size = new System.Drawing.Size(33, 16);
            this.labelDisc.TabIndex = 51;
            this.labelDisc.Text = "Disc";
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(10, 139);
            this.One.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(45, 47);
            this.One.TabIndex = 30;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(227, 3);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 16);
            this.labelName.TabIndex = 46;
            this.labelName.Text = "Discription";
            // 
            // labelF3
            // 
            this.labelF3.AutoSize = true;
            this.labelF3.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelF3.Location = new System.Drawing.Point(4, 3);
            this.labelF3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelF3.Name = "labelF3";
            this.labelF3.Size = new System.Drawing.Size(143, 16);
            this.labelF3.TabIndex = 44;
            this.labelF3.Text = "Press F3 to view List";
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(57, 139);
            this.Two.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(45, 47);
            this.Two.TabIndex = 31;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qunatityDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.productTotalDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.pOSCheckoutTBBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(196, 71);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(444, 384);
            this.dataGridView.TabIndex = 42;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // qunatityDataGridViewTextBoxColumn
            // 
            this.qunatityDataGridViewTextBoxColumn.DataPropertyName = "Qunatity";
            this.qunatityDataGridViewTextBoxColumn.HeaderText = "Qunatity";
            this.qunatityDataGridViewTextBoxColumn.Name = "qunatityDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit Price";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // productTotalDataGridViewTextBoxColumn
            // 
            this.productTotalDataGridViewTextBoxColumn.DataPropertyName = "Product Total";
            this.productTotalDataGridViewTextBoxColumn.HeaderText = "Product Total";
            this.productTotalDataGridViewTextBoxColumn.Name = "productTotalDataGridViewTextBoxColumn";
            // 
            // pOSCheckoutTBBindingSource1
            // 
            this.pOSCheckoutTBBindingSource1.DataMember = "POS_CheckoutTB";
            this.pOSCheckoutTBBindingSource1.DataSource = this.pOSCheckoutDataSet;
            // 
            // pOSCheckoutDataSet
            // 
            this.pOSCheckoutDataSet.DataSetName = "POSCheckoutDataSet";
            this.pOSCheckoutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(103, 139);
            this.Three.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(45, 47);
            this.Three.TabIndex = 32;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // labelUnitprice
            // 
            this.labelUnitprice.AutoSize = true;
            this.labelUnitprice.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitprice.Location = new System.Drawing.Point(464, 3);
            this.labelUnitprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUnitprice.Name = "labelUnitprice";
            this.labelUnitprice.Size = new System.Drawing.Size(67, 16);
            this.labelUnitprice.TabIndex = 50;
            this.labelUnitprice.Text = "Unit Price";
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQty.Location = new System.Drawing.Point(408, 3);
            this.labelQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(27, 16);
            this.labelQty.TabIndex = 47;
            this.labelQty.Text = "Qty";
            // 
            // txtNetPrice
            // 
            this.txtNetPrice.Location = new System.Drawing.Point(617, 17);
            this.txtNetPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNetPrice.Multiline = true;
            this.txtNetPrice.Name = "txtNetPrice";
            this.txtNetPrice.Size = new System.Drawing.Size(70, 32);
            this.txtNetPrice.TabIndex = 67;
            // 
            // labelNetPrice
            // 
            this.labelNetPrice.AutoSize = true;
            this.labelNetPrice.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetPrice.Location = new System.Drawing.Point(614, 2);
            this.labelNetPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNetPrice.Name = "labelNetPrice";
            this.labelNetPrice.Size = new System.Drawing.Size(61, 16);
            this.labelNetPrice.TabIndex = 66;
            this.labelNetPrice.Text = "Net Price";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // BoxforTotal
            // 
            this.BoxforTotal.Controls.Add(this.texTotalCount);
            this.BoxforTotal.Controls.Add(this.labelTotalCount);
            this.BoxforTotal.Controls.Add(this.labelPayment);
            this.BoxforTotal.Controls.Add(this.textBoxTotalPayment);
            this.BoxforTotal.Controls.Add(this.textTotalTax);
            this.BoxforTotal.Controls.Add(this.labelSubTotal);
            this.BoxforTotal.Controls.Add(this.textBoxSubTotal);
            this.BoxforTotal.Controls.Add(this.labelTax);
            this.BoxforTotal.Controls.Add(this.labelChangeDue);
            this.BoxforTotal.Controls.Add(this.textBoxTotalChange);
            this.BoxforTotal.Controls.Add(this.labelDiscount);
            this.BoxforTotal.Controls.Add(this.textBoxTotalDiscount);
            this.BoxforTotal.Controls.Add(this.PaymentBtn);
            this.BoxforTotal.Controls.Add(this.labelAmountDue);
            this.BoxforTotal.Controls.Add(this.textBoxTotalDue);
            this.BoxforTotal.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxforTotal.Location = new System.Drawing.Point(666, 71);
            this.BoxforTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxforTotal.Name = "BoxforTotal";
            this.BoxforTotal.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxforTotal.Size = new System.Drawing.Size(264, 360);
            this.BoxforTotal.TabIndex = 68;
            this.BoxforTotal.TabStop = false;
            this.BoxforTotal.Text = "Total";
            // 
            // texTotalCount
            // 
            this.texTotalCount.Location = new System.Drawing.Point(11, 304);
            this.texTotalCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.texTotalCount.Multiline = true;
            this.texTotalCount.Name = "texTotalCount";
            this.texTotalCount.Size = new System.Drawing.Size(65, 49);
            this.texTotalCount.TabIndex = 77;
            this.texTotalCount.TextChanged += new System.EventHandler(this.texTotalCount_TextChanged);
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.AutoSize = true;
            this.labelTotalCount.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCount.Location = new System.Drawing.Point(0, 286);
            this.labelTotalCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(108, 16);
            this.labelTotalCount.TabIndex = 76;
            this.labelTotalCount.Text = "Total Items Count";
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayment.Location = new System.Drawing.Point(28, 212);
            this.labelPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(69, 17);
            this.labelPayment.TabIndex = 74;
            this.labelPayment.Text = "Payment";
            // 
            // textBoxTotalPayment
            // 
            this.textBoxTotalPayment.Location = new System.Drawing.Point(100, 198);
            this.textBoxTotalPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTotalPayment.Multiline = true;
            this.textBoxTotalPayment.Name = "textBoxTotalPayment";
            this.textBoxTotalPayment.Size = new System.Drawing.Size(104, 37);
            this.textBoxTotalPayment.TabIndex = 75;
            // 
            // textTotalTax
            // 
            this.textTotalTax.Location = new System.Drawing.Point(100, 114);
            this.textTotalTax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTotalTax.Multiline = true;
            this.textTotalTax.Name = "textTotalTax";
            this.textTotalTax.Size = new System.Drawing.Size(104, 38);
            this.textTotalTax.TabIndex = 73;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.Location = new System.Drawing.Point(8, 38);
            this.labelSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(89, 17);
            this.labelSubTotal.TabIndex = 71;
            this.labelSubTotal.Text = "Gross Total";
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(100, 23);
            this.textBoxSubTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSubTotal.Multiline = true;
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(104, 42);
            this.textBoxSubTotal.TabIndex = 72;
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.Location = new System.Drawing.Point(40, 124);
            this.labelTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(55, 17);
            this.labelTax.TabIndex = 69;
            this.labelTax.Text = "Tax 5%";
            // 
            // labelChangeDue
            // 
            this.labelChangeDue.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeDue.Location = new System.Drawing.Point(28, 258);
            this.labelChangeDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChangeDue.Name = "labelChangeDue";
            this.labelChangeDue.Size = new System.Drawing.Size(67, 21);
            this.labelChangeDue.TabIndex = 69;
            this.labelChangeDue.Text = "Change Due";
            // 
            // textBoxTotalChange
            // 
            this.textBoxTotalChange.Location = new System.Drawing.Point(100, 239);
            this.textBoxTotalChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTotalChange.Multiline = true;
            this.textBoxTotalChange.Name = "textBoxTotalChange";
            this.textBoxTotalChange.Size = new System.Drawing.Size(104, 40);
            this.textBoxTotalChange.TabIndex = 68;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.Location = new System.Drawing.Point(33, 87);
            this.labelDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(64, 17);
            this.labelDiscount.TabIndex = 65;
            this.labelDiscount.Text = "Disc. 1%";
            // 
            // textBoxTotalDiscount
            // 
            this.textBoxTotalDiscount.Location = new System.Drawing.Point(100, 72);
            this.textBoxTotalDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTotalDiscount.Multiline = true;
            this.textBoxTotalDiscount.Name = "textBoxTotalDiscount";
            this.textBoxTotalDiscount.Size = new System.Drawing.Size(104, 38);
            this.textBoxTotalDiscount.TabIndex = 66;
            // 
            // F5Btn
            // 
            this.F5Btn.Location = new System.Drawing.Point(70, 334);
            this.F5Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.F5Btn.Name = "F5Btn";
            this.F5Btn.Size = new System.Drawing.Size(60, 47);
            this.F5Btn.TabIndex = 69;
            this.F5Btn.Text = "F5";
            this.F5Btn.UseVisualStyleBackColor = true;
            this.F5Btn.Click += new System.EventHandler(this.F5Btn_Click);
            // 
            // F6Btn
            // 
            this.F6Btn.Location = new System.Drawing.Point(133, 334);
            this.F6Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.F6Btn.Name = "F6Btn";
            this.F6Btn.Size = new System.Drawing.Size(62, 47);
            this.F6Btn.TabIndex = 70;
            this.F6Btn.Text = "F6";
            this.F6Btn.UseVisualStyleBackColor = true;
            this.F6Btn.Click += new System.EventHandler(this.F6Btn_Click);
            // 
            // QuickCutsomerMenuBtn
            // 
            this.QuickCutsomerMenuBtn.Location = new System.Drawing.Point(70, 71);
            this.QuickCutsomerMenuBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuickCutsomerMenuBtn.Name = "QuickCutsomerMenuBtn";
            this.QuickCutsomerMenuBtn.Size = new System.Drawing.Size(62, 65);
            this.QuickCutsomerMenuBtn.TabIndex = 71;
            this.QuickCutsomerMenuBtn.Text = "Quick Customer Menu";
            this.QuickCutsomerMenuBtn.UseVisualStyleBackColor = true;
            this.QuickCutsomerMenuBtn.Click += new System.EventHandler(this.QuickCutsomerMenuBtn_Click);
            // 
            // pOSCheckoutTBBindingSource
            // 
            this.pOSCheckoutTBBindingSource.DataMember = "POS_CheckoutTB";
            this.pOSCheckoutTBBindingSource.DataSource = this.pOSCheckoutDataSet;
            // 
            // pOS_CheckoutTBTableAdapter
            // 
            this.pOS_CheckoutTBTableAdapter.ClearBeforeFill = true;
            // 
            // F4Btn
            // 
            this.F4Btn.Location = new System.Drawing.Point(9, 334);
            this.F4Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.F4Btn.Name = "F4Btn";
            this.F4Btn.Size = new System.Drawing.Size(60, 47);
            this.F4Btn.TabIndex = 72;
            this.F4Btn.Text = "F4";
            this.F4Btn.UseVisualStyleBackColor = true;
            this.F4Btn.Click += new System.EventHandler(this.F4Btn_Click);
            // 
            // F7Btn
            // 
            this.F7Btn.Location = new System.Drawing.Point(9, 384);
            this.F7Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.F7Btn.Name = "F7Btn";
            this.F7Btn.Size = new System.Drawing.Size(60, 47);
            this.F7Btn.TabIndex = 75;
            this.F7Btn.Text = "F7";
            this.F7Btn.UseVisualStyleBackColor = true;
            this.F7Btn.Click += new System.EventHandler(this.F7Btn_Click);
            // 
            // F9Btn
            // 
            this.F9Btn.Location = new System.Drawing.Point(133, 384);
            this.F9Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.F9Btn.Name = "F9Btn";
            this.F9Btn.Size = new System.Drawing.Size(62, 47);
            this.F9Btn.TabIndex = 74;
            this.F9Btn.Text = "F9";
            this.F9Btn.UseVisualStyleBackColor = true;
            this.F9Btn.Click += new System.EventHandler(this.F9Btn_Click);
            // 
            // F8Btn
            // 
            this.F8Btn.Location = new System.Drawing.Point(70, 384);
            this.F8Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.F8Btn.Name = "F8Btn";
            this.F8Btn.Size = new System.Drawing.Size(60, 47);
            this.F8Btn.TabIndex = 73;
            this.F8Btn.Text = "F8";
            this.F8Btn.UseVisualStyleBackColor = true;
            this.F8Btn.Click += new System.EventHandler(this.F8Btn_Click);
            // 
            // RemoveItemBtn
            // 
            this.RemoveItemBtn.Location = new System.Drawing.Point(133, 70);
            this.RemoveItemBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveItemBtn.Name = "RemoveItemBtn";
            this.RemoveItemBtn.Size = new System.Drawing.Size(62, 65);
            this.RemoveItemBtn.TabIndex = 76;
            this.RemoveItemBtn.Text = "Remove from Cart";
            this.RemoveItemBtn.UseVisualStyleBackColor = true;
            this.RemoveItemBtn.Click += new System.EventHandler(this.RemoveItemBtn_Click);
            // 
            // txtCusSpendings
            // 
            this.txtCusSpendings.Location = new System.Drawing.Point(889, 17);
            this.txtCusSpendings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusSpendings.Multiline = true;
            this.txtCusSpendings.Name = "txtCusSpendings";
            this.txtCusSpendings.Size = new System.Drawing.Size(70, 33);
            this.txtCusSpendings.TabIndex = 78;
            // 
            // labelCusSpendings
            // 
            this.labelCusSpendings.AutoSize = true;
            this.labelCusSpendings.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCusSpendings.Location = new System.Drawing.Point(886, -1);
            this.labelCusSpendings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCusSpendings.Name = "labelCusSpendings";
            this.labelCusSpendings.Size = new System.Drawing.Size(66, 16);
            this.labelCusSpendings.TabIndex = 77;
            this.labelCusSpendings.Text = "Spendings";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(728, 17);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(76, 33);
            this.txtCustomerName.TabIndex = 80;
            // 
            // labelCusName
            // 
            this.labelCusName.AutoSize = true;
            this.labelCusName.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCusName.Location = new System.Drawing.Point(754, -1);
            this.labelCusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCusName.Name = "labelCusName";
            this.labelCusName.Size = new System.Drawing.Size(104, 16);
            this.labelCusName.TabIndex = 79;
            this.labelCusName.Text = "Customer\'s Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(72, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 29);
            this.btnSearch.TabIndex = 81;
            this.btnSearch.Text = "find,Add Item";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchCustomerBtn
            // 
            this.SearchCustomerBtn.Location = new System.Drawing.Point(808, 21);
            this.SearchCustomerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchCustomerBtn.Name = "SearchCustomerBtn";
            this.SearchCustomerBtn.Size = new System.Drawing.Size(62, 29);
            this.SearchCustomerBtn.TabIndex = 82;
            this.SearchCustomerBtn.Text = "Search Customer";
            this.SearchCustomerBtn.UseVisualStyleBackColor = true;
            this.SearchCustomerBtn.Click += new System.EventHandler(this.SearchCustomerBtn_Click);
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(12, 464);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(62, 13);
            this.lblCustId.TabIndex = 83;
            this.lblCustId.Text = "don\'t delete";
            this.lblCustId.Visible = false;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1008, 486);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.SearchCustomerBtn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.labelCusName);
            this.Controls.Add(this.txtCusSpendings);
            this.Controls.Add(this.labelCusSpendings);
            this.Controls.Add(this.RemoveItemBtn);
            this.Controls.Add(this.F7Btn);
            this.Controls.Add(this.F9Btn);
            this.Controls.Add(this.F8Btn);
            this.Controls.Add(this.F4Btn);
            this.Controls.Add(this.QuickCutsomerMenuBtn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.F6Btn);
            this.Controls.Add(this.F5Btn);
            this.Controls.Add(this.BoxforTotal);
            this.Controls.Add(this.txtNetPrice);
            this.Controls.Add(this.labelNetPrice);
            this.Controls.Add(this.BackSpace);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.PlusMinus);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.QuickItemMenuBtn);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.textItemSearch);
            this.Controls.Add(this.labelDisc);
            this.Controls.Add(this.One);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelF3);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.labelUnitprice);
            this.Controls.Add(this.labelQty);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSCheckoutTBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSCheckoutDataSet)).EndInit();
            this.BoxforTotal.ResumeLayout(false);
            this.BoxforTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSCheckoutTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button BackSpace;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Button PlusMinus;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button QuickItemMenuBtn;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.TextBox textBoxTotalDue;
        private System.Windows.Forms.Label labelAmountDue;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox textItemSearch;
        private System.Windows.Forms.Label labelDisc;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelF3;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Label labelUnitprice;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.TextBox txtNetPrice;
        private System.Windows.Forms.Label labelNetPrice;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox BoxforTotal;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxTotalDiscount;
        private System.Windows.Forms.TextBox textTotalTax;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelChangeDue;
        private System.Windows.Forms.TextBox textBoxTotalChange;
        private System.Windows.Forms.Button F5Btn;
        private System.Windows.Forms.Button F6Btn;
        private System.Windows.Forms.Button QuickCutsomerMenuBtn;
        private POSCheckoutDataSet pOSCheckoutDataSet;
        private System.Windows.Forms.BindingSource pOSCheckoutTBBindingSource;
        private POSCheckoutDataSetTableAdapters.POS_CheckoutTBTableAdapter pOS_CheckoutTBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn qunatityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pOSCheckoutTBBindingSource1;
        private System.Windows.Forms.Button F4Btn;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.TextBox textBoxTotalPayment;
        private System.Windows.Forms.Button F7Btn;
        private System.Windows.Forms.Button F9Btn;
        private System.Windows.Forms.Button F8Btn;
        private System.Windows.Forms.TextBox texTotalCount;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.Button RemoveItemBtn;
        private System.Windows.Forms.TextBox txtCusSpendings;
        private System.Windows.Forms.Label labelCusSpendings;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label labelCusName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button SearchCustomerBtn;
        private System.Windows.Forms.Label lblCustId;
    }
}