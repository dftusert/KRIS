namespace KRIS.windows.bidproduct
{
    partial class Modify
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
            this.tbBidNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVendorCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product = new KRIS.datasets.product.Product();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new KRIS.datasets.product.ProductTableAdapters.ProductTableAdapter();
            this.vendorcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommendedpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
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
            // tbBidNumber
            // 
            this.tbBidNumber.Location = new System.Drawing.Point(13, 26);
            this.tbBidNumber.Name = "tbBidNumber";
            this.tbBidNumber.ReadOnly = true;
            this.tbBidNumber.Size = new System.Drawing.Size(240, 20);
            this.tbBidNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Артикул";
            // 
            // tbVendorCode
            // 
            this.tbVendorCode.Location = new System.Drawing.Point(12, 80);
            this.tbVendorCode.Name = "tbVendorCode";
            this.tbVendorCode.ReadOnly = true;
            this.tbVendorCode.Size = new System.Drawing.Size(241, 20);
            this.tbVendorCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(13, 135);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(240, 20);
            this.tbCount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цен за ед.";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(12, 190);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(241, 20);
            this.tbPrice.TabIndex = 7;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(12, 228);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(241, 40);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "Изменить";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorcodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.recommendedpriceDataGridViewTextBoxColumn,
            this.remainderDataGridViewTextBoxColumn,
            this.termnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(259, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 256);
            this.dataGridView1.TabIndex = 9;
            // 
            // product
            // 
            this.product.DataSetName = "Product";
            this.product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.product;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
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
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "ОКЕИ";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
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
            this.remainderDataGridViewTextBoxColumn.HeaderText = "Остаток на складе";
            this.remainderDataGridViewTextBoxColumn.Name = "remainderDataGridViewTextBoxColumn";
            this.remainderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termnameDataGridViewTextBoxColumn
            // 
            this.termnameDataGridViewTextBoxColumn.DataPropertyName = "term_name";
            this.termnameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.termnameDataGridViewTextBoxColumn.Name = "termnameDataGridViewTextBoxColumn";
            this.termnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 277);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVendorCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBidNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение колва или цены товара в заявке";
            this.Load += new System.EventHandler(this.Modify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBidNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVendorCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private datasets.product.Product product;
        private datasets.product.ProductTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendedpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termnameDataGridViewTextBoxColumn;
    }
}