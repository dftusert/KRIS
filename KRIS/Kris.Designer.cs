using KRIS.database.entity;
using KRIS.datasets;
using KRIS.datasets.counterparty;
using KRIS.datasets.counterpartyattrs.CounterpartyAttrsTableAdapters;

namespace KRIS
{
    partial class Kris
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCounterparty = new System.Windows.Forms.TabPage();
            this.btnFilterC = new System.Windows.Forms.Button();
            this.btnRefreshC = new System.Windows.Forms.Button();
            this.dgvCounterparty = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterpartyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.counterpartyDataSet = new KRIS.datasets.counterparty.CounterpartyDataSet();
            this.btnDeleteC = new System.Windows.Forms.Button();
            this.btnEditC = new System.Windows.Forms.Button();
            this.btnAddC = new System.Windows.Forms.Button();
            this.tabCounterpartyAttrs = new System.Windows.Forms.TabPage();
            this.dgvCounterpartyAttrs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termnameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterpatryAttrsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.counterpartyAttrsDataSet = new KRIS.datasets.counterpartyattrs.CounterpartyAttrs();
            this.btnFilterCA = new System.Windows.Forms.Button();
            this.btnRefreshCA = new System.Windows.Forms.Button();
            this.btnDeleteCA = new System.Windows.Forms.Button();
            this.btnEditCA = new System.Windows.Forms.Button();
            this.btnAddCA = new System.Windows.Forms.Button();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet = new KRIS.datasets.product.Product();
            this.btnFilterP = new System.Windows.Forms.Button();
            this.btnRefreshP = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.btnEditP = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            this.tabProductAttrs = new System.Windows.Forms.TabPage();
            this.dgvProductAttrs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAttrsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productAttrsDataSet = new KRIS.datasets.productattrs.ProductAttrs();
            this.btnFilterPA = new System.Windows.Forms.Button();
            this.btnRefreshPA = new System.Windows.Forms.Button();
            this.btnDeletePA = new System.Windows.Forms.Button();
            this.btnEditPA = new System.Windows.Forms.Button();
            this.btnAddPA = new System.Windows.Forms.Button();
            this.tabBid = new System.Windows.Forms.TabPage();
            this.dgvBid = new System.Windows.Forms.DataGridView();
            this.bidnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bidDataSet = new KRIS.datasets.bid.Bid();
            this.btnFilterB = new System.Windows.Forms.Button();
            this.btnRefreshB = new System.Windows.Forms.Button();
            this.btnEditB = new System.Windows.Forms.Button();
            this.btnAddB = new System.Windows.Forms.Button();
            this.tabBidProduct = new System.Windows.Forms.TabPage();
            this.dgvBidProduct = new System.Windows.Forms.DataGridView();
            this.bidnumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bidProductDataSet = new KRIS.datasets.bidproduct.BidProduct();
            this.btnFilterBP = new System.Windows.Forms.Button();
            this.btnRefreshBP = new System.Windows.Forms.Button();
            this.btnDeleteBP = new System.Windows.Forms.Button();
            this.btnEditBP = new System.Windows.Forms.Button();
            this.btnAddBP = new System.Windows.Forms.Button();
            this.productTableAdapter = new KRIS.datasets.product.ProductTableAdapters.ProductTableAdapter();
            this.productAttrsTableAdapter = new KRIS.datasets.productattrs.ProductAttrsTableAdapters.ProductAttrsTableAdapter();
            this.bidProductTableAdapter = new KRIS.datasets.bidproduct.BidProductTableAdapters.BidProductTableAdapter();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attr_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterpatryAttrsTableAdapter = new KRIS.datasets.counterpartyattrs.CounterpartyAttrsTableAdapters.CounterpatryAttrsTableAdapter();
            this.counterpartyTableAdapter = new KRIS.datasets.counterparty.CounterpartyDataSetTableAdapters.CounterpartyTableAdapter();
            this.bidTableAdapter = new KRIS.datasets.bid.BidTableAdapters.BidTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabCounterparty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterparty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyDataSet)).BeginInit();
            this.tabCounterpartyAttrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartyAttrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpatryAttrsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyAttrsDataSet)).BeginInit();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            this.tabProductAttrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAttrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAttrsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAttrsDataSet)).BeginInit();
            this.tabBid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidDataSet)).BeginInit();
            this.tabBidProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BidProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidProductDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCounterparty);
            this.tabControl.Controls.Add(this.tabCounterpartyAttrs);
            this.tabControl.Controls.Add(this.tabProduct);
            this.tabControl.Controls.Add(this.tabProductAttrs);
            this.tabControl.Controls.Add(this.tabBid);
            this.tabControl.Controls.Add(this.tabBidProduct);
            this.tabControl.Location = new System.Drawing.Point(1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(797, 447);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.Click += new System.EventHandler(this.refreshProduct);
            // 
            // tabCounterparty
            // 
            this.tabCounterparty.Controls.Add(this.btnFilterC);
            this.tabCounterparty.Controls.Add(this.btnRefreshC);
            this.tabCounterparty.Controls.Add(this.dgvCounterparty);
            this.tabCounterparty.Controls.Add(this.btnDeleteC);
            this.tabCounterparty.Controls.Add(this.btnEditC);
            this.tabCounterparty.Controls.Add(this.btnAddC);
            this.tabCounterparty.Location = new System.Drawing.Point(4, 22);
            this.tabCounterparty.Name = "tabCounterparty";
            this.tabCounterparty.Padding = new System.Windows.Forms.Padding(3);
            this.tabCounterparty.Size = new System.Drawing.Size(789, 421);
            this.tabCounterparty.TabIndex = 0;
            this.tabCounterparty.Text = "Покупатели и поставщики";
            this.tabCounterparty.UseVisualStyleBackColor = true;
            // 
            // btnFilterC
            // 
            this.btnFilterC.Location = new System.Drawing.Point(6, 381);
            this.btnFilterC.Name = "btnFilterC";
            this.btnFilterC.Size = new System.Drawing.Size(131, 33);
            this.btnFilterC.TabIndex = 6;
            this.btnFilterC.Text = "Фильтр";
            this.btnFilterC.UseVisualStyleBackColor = true;
            this.btnFilterC.Click += new System.EventHandler(this.filterCounterparty);
            // 
            // btnRefreshC
            // 
            this.btnRefreshC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefreshC.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshC.Location = new System.Drawing.Point(744, 377);
            this.btnRefreshC.Name = "btnRefreshC";
            this.btnRefreshC.Size = new System.Drawing.Size(48, 44);
            this.btnRefreshC.TabIndex = 5;
            this.btnRefreshC.Text = "🔄";
            this.btnRefreshC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshC.UseVisualStyleBackColor = true;
            this.btnRefreshC.Click += new System.EventHandler(this.refreshCounterparty);
            // 
            // dgvCounterparty
            // 
            this.dgvCounterparty.AllowUserToAddRows = false;
            this.dgvCounterparty.AllowUserToDeleteRows = false;
            this.dgvCounterparty.AutoGenerateColumns = false;
            this.dgvCounterparty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCounterparty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.dgvCounterparty.DataSource = this.counterpartyBindingSource;
            this.dgvCounterparty.Location = new System.Drawing.Point(0, 0);
            this.dgvCounterparty.Name = "dgvCounterparty";
            this.dgvCounterparty.ReadOnly = true;
            this.dgvCounterparty.Size = new System.Drawing.Size(794, 375);
            this.dgvCounterparty.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn21.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "inn";
            this.dataGridViewTextBoxColumn22.HeaderText = "ИНН";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "kpp";
            this.dataGridViewTextBoxColumn23.HeaderText = "КПП";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // counterpartyBindingSource
            // 
            this.counterpartyBindingSource.DataMember = "Counterparty";
            this.counterpartyBindingSource.DataSource = this.counterpartyDataSet;
            // 
            // counterpartyDataSet
            // 
            this.counterpartyDataSet.DataSetName = "CounterpartyDataSet";
            this.counterpartyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.Location = new System.Drawing.Point(471, 381);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Size = new System.Drawing.Size(131, 33);
            this.btnDeleteC.TabIndex = 3;
            this.btnDeleteC.Text = "Удалить";
            this.btnDeleteC.UseVisualStyleBackColor = true;
            this.btnDeleteC.Click += new System.EventHandler(this.deleteCounterparty);
            // 
            // btnEditC
            // 
            this.btnEditC.Location = new System.Drawing.Point(312, 381);
            this.btnEditC.Name = "btnEditC";
            this.btnEditC.Size = new System.Drawing.Size(131, 33);
            this.btnEditC.TabIndex = 2;
            this.btnEditC.Text = "Изменить";
            this.btnEditC.UseVisualStyleBackColor = true;
            this.btnEditC.Click += new System.EventHandler(this.modifyCounterparty);
            // 
            // btnAddC
            // 
            this.btnAddC.Location = new System.Drawing.Point(156, 381);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(131, 33);
            this.btnAddC.TabIndex = 1;
            this.btnAddC.Text = "Добавить";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.addCounterparty);
            // 
            // tabCounterpartyAttrs
            // 
            this.tabCounterpartyAttrs.Controls.Add(this.dgvCounterpartyAttrs);
            this.tabCounterpartyAttrs.Controls.Add(this.btnFilterCA);
            this.tabCounterpartyAttrs.Controls.Add(this.btnRefreshCA);
            this.tabCounterpartyAttrs.Controls.Add(this.btnDeleteCA);
            this.tabCounterpartyAttrs.Controls.Add(this.btnEditCA);
            this.tabCounterpartyAttrs.Controls.Add(this.btnAddCA);
            this.tabCounterpartyAttrs.Location = new System.Drawing.Point(4, 22);
            this.tabCounterpartyAttrs.Name = "tabCounterpartyAttrs";
            this.tabCounterpartyAttrs.Padding = new System.Windows.Forms.Padding(3);
            this.tabCounterpartyAttrs.Size = new System.Drawing.Size(789, 421);
            this.tabCounterpartyAttrs.TabIndex = 1;
            this.tabCounterpartyAttrs.Text = "Характеристики пок. и пост.";
            this.tabCounterpartyAttrs.UseVisualStyleBackColor = true;
            // 
            // dgvCounterpartyAttrs
            // 
            this.dgvCounterpartyAttrs.AllowUserToAddRows = false;
            this.dgvCounterpartyAttrs.AllowUserToDeleteRows = false;
            this.dgvCounterpartyAttrs.AutoGenerateColumns = false;
            this.dgvCounterpartyAttrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCounterpartyAttrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn27,
            this.termnameDataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn10});
            this.dgvCounterpartyAttrs.DataSource = this.counterpatryAttrsBindingSource;
            this.dgvCounterpartyAttrs.Location = new System.Drawing.Point(0, 0);
            this.dgvCounterpartyAttrs.Name = "dgvCounterpartyAttrs";
            this.dgvCounterpartyAttrs.ReadOnly = true;
            this.dgvCounterpartyAttrs.Size = new System.Drawing.Size(794, 375);
            this.dgvCounterpartyAttrs.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "inn";
            this.dataGridViewTextBoxColumn27.HeaderText = "ИНН";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // termnameDataGridViewTextBoxColumn3
            // 
            this.termnameDataGridViewTextBoxColumn3.DataPropertyName = "term_name";
            this.termnameDataGridViewTextBoxColumn3.HeaderText = "Атрибут";
            this.termnameDataGridViewTextBoxColumn3.Name = "termnameDataGridViewTextBoxColumn3";
            this.termnameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "attr_value";
            this.dataGridViewTextBoxColumn10.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // counterpatryAttrsBindingSource
            // 
            this.counterpatryAttrsBindingSource.DataMember = "CounterpatryAttrs";
            this.counterpatryAttrsBindingSource.DataSource = this.counterpartyAttrsDataSet;
            // 
            // counterpartyAttrsDataSet
            // 
            this.counterpartyAttrsDataSet.DataSetName = "CounterpartyAttrsDataSet";
            this.counterpartyAttrsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFilterCA
            // 
            this.btnFilterCA.Location = new System.Drawing.Point(6, 381);
            this.btnFilterCA.Name = "btnFilterCA";
            this.btnFilterCA.Size = new System.Drawing.Size(131, 33);
            this.btnFilterCA.TabIndex = 11;
            this.btnFilterCA.Text = "Фильтр";
            this.btnFilterCA.UseVisualStyleBackColor = true;
            this.btnFilterCA.Click += new System.EventHandler(this.filterCounterpartyAttrs);
            // 
            // btnRefreshCA
            // 
            this.btnRefreshCA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefreshCA.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshCA.Location = new System.Drawing.Point(744, 377);
            this.btnRefreshCA.Name = "btnRefreshCA";
            this.btnRefreshCA.Size = new System.Drawing.Size(48, 44);
            this.btnRefreshCA.TabIndex = 10;
            this.btnRefreshCA.Text = "🔄";
            this.btnRefreshCA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshCA.UseVisualStyleBackColor = true;
            this.btnRefreshCA.Click += new System.EventHandler(this.refreshCounterpartyAttrs);
            // 
            // btnDeleteCA
            // 
            this.btnDeleteCA.Location = new System.Drawing.Point(471, 381);
            this.btnDeleteCA.Name = "btnDeleteCA";
            this.btnDeleteCA.Size = new System.Drawing.Size(131, 33);
            this.btnDeleteCA.TabIndex = 9;
            this.btnDeleteCA.Text = "Удалить";
            this.btnDeleteCA.UseVisualStyleBackColor = true;
            this.btnDeleteCA.Click += new System.EventHandler(this.deleteCounterpartyAttrs);
            // 
            // btnEditCA
            // 
            this.btnEditCA.Location = new System.Drawing.Point(312, 381);
            this.btnEditCA.Name = "btnEditCA";
            this.btnEditCA.Size = new System.Drawing.Size(131, 33);
            this.btnEditCA.TabIndex = 8;
            this.btnEditCA.Text = "Изменить";
            this.btnEditCA.UseVisualStyleBackColor = true;
            this.btnEditCA.Click += new System.EventHandler(this.modifyCounterpartyAttrs);
            // 
            // btnAddCA
            // 
            this.btnAddCA.Location = new System.Drawing.Point(156, 381);
            this.btnAddCA.Name = "btnAddCA";
            this.btnAddCA.Size = new System.Drawing.Size(131, 33);
            this.btnAddCA.TabIndex = 7;
            this.btnAddCA.Text = "Добавить";
            this.btnAddCA.UseVisualStyleBackColor = true;
            this.btnAddCA.Click += new System.EventHandler(this.addCounterpartyAttrs);
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.dgvProduct);
            this.tabProduct.Controls.Add(this.btnFilterP);
            this.tabProduct.Controls.Add(this.btnRefreshP);
            this.tabProduct.Controls.Add(this.btnDeleteP);
            this.tabProduct.Controls.Add(this.btnEditP);
            this.tabProduct.Controls.Add(this.btnAddP);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(789, 421);
            this.tabProduct.TabIndex = 2;
            this.tabProduct.Text = "Товары";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.expr1DataGridViewTextBoxColumn,
            this.termnameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn20});
            this.dgvProduct.DataSource = this.productBindingSource;
            this.dgvProduct.Location = new System.Drawing.Point(-9, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(803, 375);
            this.dgvProduct.TabIndex = 17;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDataSet;
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "ProductDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFilterP
            // 
            this.btnFilterP.Location = new System.Drawing.Point(6, 381);
            this.btnFilterP.Name = "btnFilterP";
            this.btnFilterP.Size = new System.Drawing.Size(131, 33);
            this.btnFilterP.TabIndex = 16;
            this.btnFilterP.Text = "Фильтр";
            this.btnFilterP.UseVisualStyleBackColor = true;
            this.btnFilterP.Click += new System.EventHandler(this.filterProduct);
            // 
            // btnRefreshP
            // 
            this.btnRefreshP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefreshP.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshP.Location = new System.Drawing.Point(744, 377);
            this.btnRefreshP.Name = "btnRefreshP";
            this.btnRefreshP.Size = new System.Drawing.Size(48, 44);
            this.btnRefreshP.TabIndex = 15;
            this.btnRefreshP.Text = "🔄";
            this.btnRefreshP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshP.UseVisualStyleBackColor = true;
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.Location = new System.Drawing.Point(471, 381);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(131, 33);
            this.btnDeleteP.TabIndex = 14;
            this.btnDeleteP.Text = "Удалить";
            this.btnDeleteP.UseVisualStyleBackColor = true;
            this.btnDeleteP.Click += new System.EventHandler(this.deleteProduct);
            // 
            // btnEditP
            // 
            this.btnEditP.Location = new System.Drawing.Point(312, 381);
            this.btnEditP.Name = "btnEditP";
            this.btnEditP.Size = new System.Drawing.Size(131, 33);
            this.btnEditP.TabIndex = 13;
            this.btnEditP.Text = "Изменить";
            this.btnEditP.UseVisualStyleBackColor = true;
            this.btnEditP.Click += new System.EventHandler(this.modifyProduct);
            // 
            // btnAddP
            // 
            this.btnAddP.Location = new System.Drawing.Point(156, 381);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(131, 33);
            this.btnAddP.TabIndex = 12;
            this.btnAddP.Text = "Добавить";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.addProduct);
            // 
            // tabProductAttrs
            // 
            this.tabProductAttrs.Controls.Add(this.dgvProductAttrs);
            this.tabProductAttrs.Controls.Add(this.btnFilterPA);
            this.tabProductAttrs.Controls.Add(this.btnRefreshPA);
            this.tabProductAttrs.Controls.Add(this.btnDeletePA);
            this.tabProductAttrs.Controls.Add(this.btnEditPA);
            this.tabProductAttrs.Controls.Add(this.btnAddPA);
            this.tabProductAttrs.Location = new System.Drawing.Point(4, 22);
            this.tabProductAttrs.Name = "tabProductAttrs";
            this.tabProductAttrs.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductAttrs.Size = new System.Drawing.Size(789, 421);
            this.tabProductAttrs.TabIndex = 3;
            this.tabProductAttrs.Text = "Характеристики товара";
            this.tabProductAttrs.UseVisualStyleBackColor = true;
            // 
            // dgvProductAttrs
            // 
            this.dgvProductAttrs.AllowUserToAddRows = false;
            this.dgvProductAttrs.AllowUserToDeleteRows = false;
            this.dgvProductAttrs.AutoGenerateColumns = false;
            this.dgvProductAttrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductAttrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn24,
            this.termnameDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn25});
            this.dgvProductAttrs.DataSource = this.productAttrsBindingSource;
            this.dgvProductAttrs.Location = new System.Drawing.Point(0, 0);
            this.dgvProductAttrs.Name = "dgvProductAttrs";
            this.dgvProductAttrs.ReadOnly = true;
            this.dgvProductAttrs.Size = new System.Drawing.Size(794, 375);
            this.dgvProductAttrs.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "vendor_code";
            this.dataGridViewTextBoxColumn24.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // termnameDataGridViewTextBoxColumn1
            // 
            this.termnameDataGridViewTextBoxColumn1.DataPropertyName = "term_name";
            this.termnameDataGridViewTextBoxColumn1.HeaderText = "Атрибут";
            this.termnameDataGridViewTextBoxColumn1.Name = "termnameDataGridViewTextBoxColumn1";
            this.termnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "attr_value";
            this.dataGridViewTextBoxColumn25.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // productAttrsBindingSource
            // 
            this.productAttrsBindingSource.DataMember = "ProductAttrs";
            this.productAttrsBindingSource.DataSource = this.productAttrsDataSet;
            // 
            // productAttrsDataSet
            // 
            this.productAttrsDataSet.DataSetName = "ProductAttrsDataSet";
            this.productAttrsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFilterPA
            // 
            this.btnFilterPA.Location = new System.Drawing.Point(6, 381);
            this.btnFilterPA.Name = "btnFilterPA";
            this.btnFilterPA.Size = new System.Drawing.Size(131, 33);
            this.btnFilterPA.TabIndex = 21;
            this.btnFilterPA.Text = "Фильтр";
            this.btnFilterPA.UseVisualStyleBackColor = true;
            this.btnFilterPA.Click += new System.EventHandler(this.filterProductAttrs);
            // 
            // btnRefreshPA
            // 
            this.btnRefreshPA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefreshPA.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshPA.Location = new System.Drawing.Point(744, 377);
            this.btnRefreshPA.Name = "btnRefreshPA";
            this.btnRefreshPA.Size = new System.Drawing.Size(48, 44);
            this.btnRefreshPA.TabIndex = 20;
            this.btnRefreshPA.Text = "🔄";
            this.btnRefreshPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshPA.UseVisualStyleBackColor = true;
            this.btnRefreshPA.Click += new System.EventHandler(this.refreshProductAttrs);
            // 
            // btnDeletePA
            // 
            this.btnDeletePA.Location = new System.Drawing.Point(471, 381);
            this.btnDeletePA.Name = "btnDeletePA";
            this.btnDeletePA.Size = new System.Drawing.Size(131, 33);
            this.btnDeletePA.TabIndex = 19;
            this.btnDeletePA.Text = "Удалить";
            this.btnDeletePA.UseVisualStyleBackColor = true;
            this.btnDeletePA.Click += new System.EventHandler(this.deleteProductAttrs);
            // 
            // btnEditPA
            // 
            this.btnEditPA.Location = new System.Drawing.Point(312, 381);
            this.btnEditPA.Name = "btnEditPA";
            this.btnEditPA.Size = new System.Drawing.Size(131, 33);
            this.btnEditPA.TabIndex = 18;
            this.btnEditPA.Text = "Изменить";
            this.btnEditPA.UseVisualStyleBackColor = true;
            this.btnEditPA.Click += new System.EventHandler(this.modifyProductAttrs);
            // 
            // btnAddPA
            // 
            this.btnAddPA.Location = new System.Drawing.Point(156, 381);
            this.btnAddPA.Name = "btnAddPA";
            this.btnAddPA.Size = new System.Drawing.Size(131, 33);
            this.btnAddPA.TabIndex = 17;
            this.btnAddPA.Text = "Добавить";
            this.btnAddPA.UseVisualStyleBackColor = true;
            this.btnAddPA.Click += new System.EventHandler(this.addProductAttrs);
            // 
            // tabBid
            // 
            this.tabBid.Controls.Add(this.dgvBid);
            this.tabBid.Controls.Add(this.btnFilterB);
            this.tabBid.Controls.Add(this.btnRefreshB);
            this.tabBid.Controls.Add(this.btnEditB);
            this.tabBid.Controls.Add(this.btnAddB);
            this.tabBid.Location = new System.Drawing.Point(4, 22);
            this.tabBid.Name = "tabBid";
            this.tabBid.Padding = new System.Windows.Forms.Padding(3);
            this.tabBid.Size = new System.Drawing.Size(789, 421);
            this.tabBid.TabIndex = 4;
            this.tabBid.Text = "Заявки";
            this.tabBid.UseVisualStyleBackColor = true;
            // 
            // dgvBid
            // 
            this.dgvBid.AllowUserToAddRows = false;
            this.dgvBid.AllowUserToDeleteRows = false;
            this.dgvBid.AutoGenerateColumns = false;
            this.dgvBid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bidnumberDataGridViewTextBoxColumn,
            this.createdateDataGridViewTextBoxColumn,
            this.termnameDataGridViewTextBoxColumn2,
            this.statusdateDataGridViewTextBoxColumn,
            this.Expr1,
            this.expr1DataGridViewTextBoxColumn1});
            this.dgvBid.DataSource = this.BidBindingSource;
            this.dgvBid.Location = new System.Drawing.Point(0, 0);
            this.dgvBid.Name = "dgvBid";
            this.dgvBid.ReadOnly = true;
            this.dgvBid.Size = new System.Drawing.Size(794, 375);
            this.dgvBid.TabIndex = 27;
            // 
            // bidnumberDataGridViewTextBoxColumn
            // 
            this.bidnumberDataGridViewTextBoxColumn.DataPropertyName = "bid_number";
            this.bidnumberDataGridViewTextBoxColumn.HeaderText = "Номер заявки";
            this.bidnumberDataGridViewTextBoxColumn.Name = "bidnumberDataGridViewTextBoxColumn";
            this.bidnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdateDataGridViewTextBoxColumn
            // 
            this.createdateDataGridViewTextBoxColumn.DataPropertyName = "create_date";
            this.createdateDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.createdateDataGridViewTextBoxColumn.Name = "createdateDataGridViewTextBoxColumn";
            this.createdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termnameDataGridViewTextBoxColumn2
            // 
            this.termnameDataGridViewTextBoxColumn2.DataPropertyName = "term_name";
            this.termnameDataGridViewTextBoxColumn2.HeaderText = "Статус";
            this.termnameDataGridViewTextBoxColumn2.Name = "termnameDataGridViewTextBoxColumn2";
            this.termnameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // statusdateDataGridViewTextBoxColumn
            // 
            this.statusdateDataGridViewTextBoxColumn.DataPropertyName = "status_date";
            this.statusdateDataGridViewTextBoxColumn.HeaderText = "Дата статуса";
            this.statusdateDataGridViewTextBoxColumn.Name = "statusdateDataGridViewTextBoxColumn";
            this.statusdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Expr1
            // 
            this.Expr1.DataPropertyName = "Expr1";
            this.Expr1.HeaderText = "Тип заявки";
            this.Expr1.Name = "Expr1";
            this.Expr1.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn1
            // 
            this.expr1DataGridViewTextBoxColumn1.DataPropertyName = "inn";
            this.expr1DataGridViewTextBoxColumn1.HeaderText = "ИНН пок. или пост.";
            this.expr1DataGridViewTextBoxColumn1.Name = "expr1DataGridViewTextBoxColumn1";
            this.expr1DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // BidBindingSource
            // 
            this.BidBindingSource.DataMember = "Bid";
            this.BidBindingSource.DataSource = this.bidDataSet;
            // 
            // bidDataSet
            // 
            this.bidDataSet.DataSetName = "Bid";
            this.bidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFilterB
            // 
            this.btnFilterB.Location = new System.Drawing.Point(6, 381);
            this.btnFilterB.Name = "btnFilterB";
            this.btnFilterB.Size = new System.Drawing.Size(131, 33);
            this.btnFilterB.TabIndex = 26;
            this.btnFilterB.Text = "Фильтр";
            this.btnFilterB.UseVisualStyleBackColor = true;
            this.btnFilterB.Click += new System.EventHandler(this.filterBid);
            // 
            // btnRefreshB
            // 
            this.btnRefreshB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefreshB.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshB.Location = new System.Drawing.Point(744, 377);
            this.btnRefreshB.Name = "btnRefreshB";
            this.btnRefreshB.Size = new System.Drawing.Size(48, 44);
            this.btnRefreshB.TabIndex = 25;
            this.btnRefreshB.Text = "🔄";
            this.btnRefreshB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshB.UseVisualStyleBackColor = true;
            this.btnRefreshB.Click += new System.EventHandler(this.refreshBid);
            // 
            // btnEditB
            // 
            this.btnEditB.Location = new System.Drawing.Point(312, 381);
            this.btnEditB.Name = "btnEditB";
            this.btnEditB.Size = new System.Drawing.Size(131, 33);
            this.btnEditB.TabIndex = 23;
            this.btnEditB.Text = "Изменить";
            this.btnEditB.UseVisualStyleBackColor = true;
            this.btnEditB.Click += new System.EventHandler(this.modifyBid);
            // 
            // btnAddB
            // 
            this.btnAddB.Location = new System.Drawing.Point(156, 381);
            this.btnAddB.Name = "btnAddB";
            this.btnAddB.Size = new System.Drawing.Size(131, 33);
            this.btnAddB.TabIndex = 22;
            this.btnAddB.Text = "Добавить";
            this.btnAddB.UseVisualStyleBackColor = true;
            this.btnAddB.Click += new System.EventHandler(this.addBid);
            // 
            // tabBidProduct
            // 
            this.tabBidProduct.Controls.Add(this.dgvBidProduct);
            this.tabBidProduct.Controls.Add(this.btnFilterBP);
            this.tabBidProduct.Controls.Add(this.btnRefreshBP);
            this.tabBidProduct.Controls.Add(this.btnDeleteBP);
            this.tabBidProduct.Controls.Add(this.btnEditBP);
            this.tabBidProduct.Controls.Add(this.btnAddBP);
            this.tabBidProduct.Location = new System.Drawing.Point(4, 22);
            this.tabBidProduct.Name = "tabBidProduct";
            this.tabBidProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabBidProduct.Size = new System.Drawing.Size(789, 421);
            this.tabBidProduct.TabIndex = 5;
            this.tabBidProduct.Text = "Товары в заявке";
            this.tabBidProduct.UseVisualStyleBackColor = true;
            // 
            // dgvBidProduct
            // 
            this.dgvBidProduct.AllowUserToAddRows = false;
            this.dgvBidProduct.AllowUserToDeleteRows = false;
            this.dgvBidProduct.AutoGenerateColumns = false;
            this.dgvBidProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBidProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bidnumberDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn26,
            this.productcountDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn});
            this.dgvBidProduct.DataSource = this.BidProductBindingSource;
            this.dgvBidProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvBidProduct.Name = "dgvBidProduct";
            this.dgvBidProduct.ReadOnly = true;
            this.dgvBidProduct.Size = new System.Drawing.Size(794, 375);
            this.dgvBidProduct.TabIndex = 32;
            // 
            // bidnumberDataGridViewTextBoxColumn1
            // 
            this.bidnumberDataGridViewTextBoxColumn1.DataPropertyName = "bid_number";
            this.bidnumberDataGridViewTextBoxColumn1.HeaderText = "Номер заявки";
            this.bidnumberDataGridViewTextBoxColumn1.Name = "bidnumberDataGridViewTextBoxColumn1";
            this.bidnumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "vendor_code";
            this.dataGridViewTextBoxColumn26.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // productcountDataGridViewTextBoxColumn
            // 
            this.productcountDataGridViewTextBoxColumn.DataPropertyName = "product_count";
            this.productcountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.productcountDataGridViewTextBoxColumn.Name = "productcountDataGridViewTextBoxColumn";
            this.productcountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "product_price";
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "Цена за ед.";
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
            this.productpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BidProductBindingSource
            // 
            this.BidProductBindingSource.DataMember = "BidProduct";
            this.BidProductBindingSource.DataSource = this.bidProductDataSet;
            // 
            // bidProductDataSet
            // 
            this.bidProductDataSet.DataSetName = "BidProduct";
            this.bidProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFilterBP
            // 
            this.btnFilterBP.Location = new System.Drawing.Point(6, 381);
            this.btnFilterBP.Name = "btnFilterBP";
            this.btnFilterBP.Size = new System.Drawing.Size(131, 33);
            this.btnFilterBP.TabIndex = 31;
            this.btnFilterBP.Text = "Фильтр";
            this.btnFilterBP.UseVisualStyleBackColor = true;
            this.btnFilterBP.Click += new System.EventHandler(this.filterBidProduct);
            // 
            // btnRefreshBP
            // 
            this.btnRefreshBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefreshBP.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshBP.Location = new System.Drawing.Point(744, 377);
            this.btnRefreshBP.Name = "btnRefreshBP";
            this.btnRefreshBP.Size = new System.Drawing.Size(48, 44);
            this.btnRefreshBP.TabIndex = 30;
            this.btnRefreshBP.Text = "🔄";
            this.btnRefreshBP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshBP.UseVisualStyleBackColor = true;
            this.btnRefreshBP.Click += new System.EventHandler(this.refreshBidProduct);
            // 
            // btnDeleteBP
            // 
            this.btnDeleteBP.Location = new System.Drawing.Point(471, 381);
            this.btnDeleteBP.Name = "btnDeleteBP";
            this.btnDeleteBP.Size = new System.Drawing.Size(131, 33);
            this.btnDeleteBP.TabIndex = 29;
            this.btnDeleteBP.Text = "Удалить";
            this.btnDeleteBP.UseVisualStyleBackColor = true;
            this.btnDeleteBP.Click += new System.EventHandler(this.deleteBidProduct);
            // 
            // btnEditBP
            // 
            this.btnEditBP.Location = new System.Drawing.Point(312, 381);
            this.btnEditBP.Name = "btnEditBP";
            this.btnEditBP.Size = new System.Drawing.Size(131, 33);
            this.btnEditBP.TabIndex = 28;
            this.btnEditBP.Text = "Изменить";
            this.btnEditBP.UseVisualStyleBackColor = true;
            this.btnEditBP.Click += new System.EventHandler(this.modifyBidProduct);
            // 
            // btnAddBP
            // 
            this.btnAddBP.Location = new System.Drawing.Point(156, 381);
            this.btnAddBP.Name = "btnAddBP";
            this.btnAddBP.Size = new System.Drawing.Size(131, 33);
            this.btnAddBP.TabIndex = 27;
            this.btnAddBP.Text = "Добавить";
            this.btnAddBP.UseVisualStyleBackColor = true;
            this.btnAddBP.Click += new System.EventHandler(this.addBidProduct);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productAttrsTableAdapter
            // 
            this.productAttrsTableAdapter.ClearBeforeFill = true;
            // 
            // bidProductTableAdapter
            // 
            this.bidProductTableAdapter.ClearBeforeFill = true;
            // 
            // inn
            // 
            this.inn.DataPropertyName = "inn";
            this.inn.HeaderText = "ИНН";
            this.inn.Name = "inn";
            this.inn.ReadOnly = true;
            // 
            // term_name
            // 
            this.term_name.DataPropertyName = "term_name";
            this.term_name.HeaderText = "Атрибут";
            this.term_name.Name = "term_name";
            this.term_name.ReadOnly = true;
            // 
            // attr_value
            // 
            this.attr_value.DataPropertyName = "attr_value";
            this.attr_value.HeaderText = "Значение";
            this.attr_value.Name = "attr_value";
            this.attr_value.ReadOnly = true;
            // 
            // counterpatryAttrsTableAdapter
            // 
            this.counterpatryAttrsTableAdapter.ClearBeforeFill = true;
            // 
            // counterpartyTableAdapter
            // 
            this.counterpartyTableAdapter.ClearBeforeFill = true;
            // 
            // bidTableAdapter
            // 
            this.bidTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "vendor_code";
            this.dataGridViewTextBoxColumn4.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "ОКЕИ";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termnameDataGridViewTextBoxColumn
            // 
            this.termnameDataGridViewTextBoxColumn.DataPropertyName = "term_name";
            this.termnameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.termnameDataGridViewTextBoxColumn.Name = "termnameDataGridViewTextBoxColumn";
            this.termnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "recommended_price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Рекомендованная цена";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "remainder";
            this.dataGridViewTextBoxColumn20.HeaderText = "Остаток на складе";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // Kris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Kris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KRIS";
            this.Load += new System.EventHandler(this.Kris_Load);
            this.tabControl.ResumeLayout(false);
            this.tabCounterparty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterparty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyDataSet)).EndInit();
            this.tabCounterpartyAttrs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartyAttrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpatryAttrsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyAttrsDataSet)).EndInit();
            this.tabProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            this.tabProductAttrs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAttrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAttrsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAttrsDataSet)).EndInit();
            this.tabBid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidDataSet)).EndInit();
            this.tabBidProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BidProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidProductDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCounterparty;
        private System.Windows.Forms.TabPage tabCounterpartyAttrs;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabProductAttrs;
        private System.Windows.Forms.TabPage tabBid;
        private System.Windows.Forms.TabPage tabBidProduct;
        private System.Windows.Forms.Button btnDeleteC;
        private System.Windows.Forms.Button btnEditC;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.DataGridView dgvCounterparty;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kppDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRefreshC;
        private System.Windows.Forms.Button btnFilterC;
        private datasets.counterparty.CounterpartyDataSet counterpartyDataSet;
        private System.Windows.Forms.BindingSource counterpartyBindingSource;
        private datasets.counterparty.CounterpartyDataSetTableAdapters.CounterpartyTableAdapter counterpartyTableAdapter;
        private System.Windows.Forms.Button btnFilterCA;
        private System.Windows.Forms.Button btnRefreshCA;
        private System.Windows.Forms.Button btnDeleteCA;
        private System.Windows.Forms.Button btnEditCA;
        private System.Windows.Forms.Button btnAddCA;
        private System.Windows.Forms.DataGridView dgvCounterpartyAttrs;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnFilterP;
        private System.Windows.Forms.Button btnRefreshP;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.Button btnEditP;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okeiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendedpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterpartyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attrvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource counterpatryAttrsBindingSource;
        private datasets.counterpartyattrs.CounterpartyAttrsTableAdapters.CounterpatryAttrsTableAdapter counterpatryAttrsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private datasets.product.Product productDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private datasets.product.ProductTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.Button btnFilterPA;
        private System.Windows.Forms.Button btnRefreshPA;
        private System.Windows.Forms.Button btnDeletePA;
        private System.Windows.Forms.Button btnEditPA;
        private System.Windows.Forms.Button btnAddPA;
        private System.Windows.Forms.DataGridView dgvProductAttrs;
        private datasets.productattrs.ProductAttrs productAttrsDataSet;
        private System.Windows.Forms.BindingSource productAttrsBindingSource;
        private datasets.productattrs.ProductAttrsTableAdapters.ProductAttrsTableAdapter productAttrsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn termnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.Button btnFilterB;
        private System.Windows.Forms.Button btnRefreshB;
        private System.Windows.Forms.Button btnEditB;
        private System.Windows.Forms.Button btnAddB;
        private System.Windows.Forms.Button btnFilterBP;
        private System.Windows.Forms.Button btnRefreshBP;
        private System.Windows.Forms.Button btnDeleteBP;
        private System.Windows.Forms.Button btnEditBP;
        private System.Windows.Forms.Button btnAddBP;
        private System.Windows.Forms.DataGridView dgvBid;
        private System.Windows.Forms.DataGridView dgvBidProduct;
        private System.Windows.Forms.BindingSource BidBindingSource;
        private datasets.bid.Bid bidDataSet;
        private datasets.bid.BidTableAdapters.BidTableAdapter bidTableAdapter;
        private System.Windows.Forms.BindingSource BidProductBindingSource;
        private datasets.bidproduct.BidProduct bidProductDataSet;
        private datasets.bidproduct.BidProductTableAdapters.BidProductTableAdapter bidProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inn;
        private System.Windows.Forms.DataGridViewTextBoxColumn term_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn attr_value;
        private datasets.counterpartyattrs.CounterpartyAttrs counterpartyAttrsDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn termnameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    }
}