namespace KRIS.windows.bidproduct
{
    partial class Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBidNumber = new System.Windows.Forms.TextBox();
            this.tbVendorCode = new System.Windows.Forms.TextBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvBid = new System.Windows.Forms.DataGridView();
            this.bidnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bid = new KRIS.datasets.bid.Bid();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.vendorcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommendedpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product = new KRIS.datasets.product.Product();
            this.bidTableAdapter = new KRIS.datasets.bid.BidTableAdapters.BidTableAdapter();
            this.productTableAdapter = new KRIS.datasets.product.ProductTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Артикул";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена за ед.";
            // 
            // tbBidNumber
            // 
            this.tbBidNumber.Location = new System.Drawing.Point(12, 25);
            this.tbBidNumber.Name = "tbBidNumber";
            this.tbBidNumber.Size = new System.Drawing.Size(240, 20);
            this.tbBidNumber.TabIndex = 4;
            // 
            // tbVendorCode
            // 
            this.tbVendorCode.Location = new System.Drawing.Point(12, 75);
            this.tbVendorCode.Name = "tbVendorCode";
            this.tbVendorCode.Size = new System.Drawing.Size(240, 20);
            this.tbVendorCode.TabIndex = 5;
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(12, 125);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(240, 20);
            this.tbCount.TabIndex = 6;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(12, 176);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(240, 20);
            this.tbPrice.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 38);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvBid
            // 
            this.dgvBid.AllowUserToAddRows = false;
            this.dgvBid.AllowUserToDeleteRows = false;
            this.dgvBid.AutoGenerateColumns = false;
            this.dgvBid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bidnumberDataGridViewTextBoxColumn,
            this.innDataGridViewTextBoxColumn,
            this.createdateDataGridViewTextBoxColumn,
            this.termnameDataGridViewTextBoxColumn,
            this.statusdateDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn});
            this.dgvBid.DataSource = this.bidBindingSource;
            this.dgvBid.Location = new System.Drawing.Point(258, 9);
            this.dgvBid.Name = "dgvBid";
            this.dgvBid.ReadOnly = true;
            this.dgvBid.Size = new System.Drawing.Size(645, 166);
            this.dgvBid.TabIndex = 9;
            // 
            // bidnumberDataGridViewTextBoxColumn
            // 
            this.bidnumberDataGridViewTextBoxColumn.DataPropertyName = "bid_number";
            this.bidnumberDataGridViewTextBoxColumn.HeaderText = "Номер заявки";
            this.bidnumberDataGridViewTextBoxColumn.Name = "bidnumberDataGridViewTextBoxColumn";
            this.bidnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // innDataGridViewTextBoxColumn
            // 
            this.innDataGridViewTextBoxColumn.DataPropertyName = "inn";
            this.innDataGridViewTextBoxColumn.HeaderText = "ИНН пок. или пост.";
            this.innDataGridViewTextBoxColumn.Name = "innDataGridViewTextBoxColumn";
            this.innDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdateDataGridViewTextBoxColumn
            // 
            this.createdateDataGridViewTextBoxColumn.DataPropertyName = "create_date";
            this.createdateDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.createdateDataGridViewTextBoxColumn.Name = "createdateDataGridViewTextBoxColumn";
            this.createdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termnameDataGridViewTextBoxColumn
            // 
            this.termnameDataGridViewTextBoxColumn.DataPropertyName = "term_name";
            this.termnameDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.termnameDataGridViewTextBoxColumn.Name = "termnameDataGridViewTextBoxColumn";
            this.termnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusdateDataGridViewTextBoxColumn
            // 
            this.statusdateDataGridViewTextBoxColumn.DataPropertyName = "status_date";
            this.statusdateDataGridViewTextBoxColumn.HeaderText = "Дата статуса";
            this.statusdateDataGridViewTextBoxColumn.Name = "statusdateDataGridViewTextBoxColumn";
            this.statusdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Тип";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bidBindingSource
            // 
            this.bidBindingSource.DataMember = "Bid";
            this.bidBindingSource.DataSource = this.bid;
            // 
            // bid
            // 
            this.bid.DataSetName = "Bid";
            this.bid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorcodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn1,
            this.recommendedpriceDataGridViewTextBoxColumn,
            this.remainderDataGridViewTextBoxColumn,
            this.termnameDataGridViewTextBoxColumn1});
            this.dgvProduct.DataSource = this.productBindingSource;
            this.dgvProduct.Location = new System.Drawing.Point(259, 181);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(644, 166);
            this.dgvProduct.TabIndex = 10;
            // 
            // vendorcodeDataGridViewTextBoxColumn
            // 
            this.vendorcodeDataGridViewTextBoxColumn.DataPropertyName = "vendor_code";
            this.vendorcodeDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.vendorcodeDataGridViewTextBoxColumn.Name = "vendorcodeDataGridViewTextBoxColumn";
            this.vendorcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn1
            // 
            this.expr1DataGridViewTextBoxColumn1.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn1.HeaderText = "ОКЕИ";
            this.expr1DataGridViewTextBoxColumn1.Name = "expr1DataGridViewTextBoxColumn1";
            this.expr1DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // recommendedpriceDataGridViewTextBoxColumn
            // 
            this.recommendedpriceDataGridViewTextBoxColumn.DataPropertyName = "recommended_price";
            this.recommendedpriceDataGridViewTextBoxColumn.HeaderText = "Рекомендованная цена";
            this.recommendedpriceDataGridViewTextBoxColumn.Name = "recommendedpriceDataGridViewTextBoxColumn";
            this.recommendedpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remainderDataGridViewTextBoxColumn
            // 
            this.remainderDataGridViewTextBoxColumn.DataPropertyName = "remainder";
            this.remainderDataGridViewTextBoxColumn.HeaderText = "Остаток";
            this.remainderDataGridViewTextBoxColumn.Name = "remainderDataGridViewTextBoxColumn";
            this.remainderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termnameDataGridViewTextBoxColumn1
            // 
            this.termnameDataGridViewTextBoxColumn1.DataPropertyName = "term_name";
            this.termnameDataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.termnameDataGridViewTextBoxColumn1.Name = "termnameDataGridViewTextBoxColumn1";
            this.termnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.product;
            // 
            // product
            // 
            this.product.DataSetName = "Product";
            this.product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bidTableAdapter
            // 
            this.bidTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 355);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.dgvBid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.tbVendorCode);
            this.Controls.Add(this.tbBidNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление товара в заявку";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBidNumber;
        private System.Windows.Forms.TextBox tbVendorCode;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvBid;
        private System.Windows.Forms.BindingSource bidBindingSource;
        private datasets.bid.Bid bid;
        private System.Windows.Forms.DataGridView dgvProduct;
        private datasets.bid.BidTableAdapters.BidTableAdapter bidTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private datasets.product.Product product;
        private datasets.product.ProductTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendedpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termnameDataGridViewTextBoxColumn1;
    }
}