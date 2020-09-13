using KRIS.datasets;
using KRIS.datasets.counterparty;

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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCounterparty = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterpartyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.counterpartyDataSet = new KRIS.datasets.counterparty.CounterpartyDataSet();
            this.btnDeleteC = new System.Windows.Forms.Button();
            this.btnEditC = new System.Windows.Forms.Button();
            this.btnAddC = new System.Windows.Forms.Button();
            this.tabCounterpartyAttrs = new System.Windows.Forms.TabPage();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.tabProductAttrs = new System.Windows.Forms.TabPage();
            this.tabBid = new System.Windows.Forms.TabPage();
            this.tabBidProduct = new System.Windows.Forms.TabPage();
            this.counterpartyTableAdapter = new KRIS.datasets.counterparty.CounterpartyDataSetTableAdapters.CounterpartyTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabCounterparty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterparty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyDataSet)).BeginInit();
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
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 447);
            this.tabControl.TabIndex = 0;
            // 
            // tabCounterparty
            // 
            this.tabCounterparty.Controls.Add(this.btnFilterC);
            this.tabCounterparty.Controls.Add(this.button1);
            this.tabCounterparty.Controls.Add(this.dgvCounterparty);
            this.tabCounterparty.Controls.Add(this.btnDeleteC);
            this.tabCounterparty.Controls.Add(this.btnEditC);
            this.tabCounterparty.Controls.Add(this.btnAddC);
            this.tabCounterparty.Location = new System.Drawing.Point(4, 22);
            this.tabCounterparty.Name = "tabCounterparty";
            this.tabCounterparty.Padding = new System.Windows.Forms.Padding(3);
            this.tabCounterparty.Size = new System.Drawing.Size(792, 421);
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
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(744, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "🔄";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.refreshCounterparty);
            // 
            // dgvCounterparty
            // 
            this.dgvCounterparty.AllowUserToAddRows = false;
            this.dgvCounterparty.AllowUserToDeleteRows = false;
            this.dgvCounterparty.AutoGenerateColumns = false;
            this.dgvCounterparty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCounterparty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvCounterparty.DataSource = this.counterpartyBindingSource;
            this.dgvCounterparty.Location = new System.Drawing.Point(0, 0);
            this.dgvCounterparty.Name = "dgvCounterparty";
            this.dgvCounterparty.ReadOnly = true;
            this.dgvCounterparty.Size = new System.Drawing.Size(796, 375);
            this.dgvCounterparty.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "inn";
            this.dataGridViewTextBoxColumn2.HeaderText = "ИНН";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kpp";
            this.dataGridViewTextBoxColumn3.HeaderText = "КПП";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            // 
            // btnEditC
            // 
            this.btnEditC.Location = new System.Drawing.Point(312, 381);
            this.btnEditC.Name = "btnEditC";
            this.btnEditC.Size = new System.Drawing.Size(131, 33);
            this.btnEditC.TabIndex = 2;
            this.btnEditC.Text = "Изменить";
            this.btnEditC.UseVisualStyleBackColor = true;
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
            this.tabCounterpartyAttrs.Location = new System.Drawing.Point(4, 22);
            this.tabCounterpartyAttrs.Name = "tabCounterpartyAttrs";
            this.tabCounterpartyAttrs.Padding = new System.Windows.Forms.Padding(3);
            this.tabCounterpartyAttrs.Size = new System.Drawing.Size(792, 421);
            this.tabCounterpartyAttrs.TabIndex = 1;
            this.tabCounterpartyAttrs.Text = "Характеристики пок. и пост.";
            this.tabCounterpartyAttrs.UseVisualStyleBackColor = true;
            // 
            // tabProduct
            // 
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(792, 421);
            this.tabProduct.TabIndex = 2;
            this.tabProduct.Text = "Товары";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // tabProductAttrs
            // 
            this.tabProductAttrs.Location = new System.Drawing.Point(4, 22);
            this.tabProductAttrs.Name = "tabProductAttrs";
            this.tabProductAttrs.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductAttrs.Size = new System.Drawing.Size(792, 421);
            this.tabProductAttrs.TabIndex = 3;
            this.tabProductAttrs.Text = "Характеристики товара";
            this.tabProductAttrs.UseVisualStyleBackColor = true;
            // 
            // tabBid
            // 
            this.tabBid.Location = new System.Drawing.Point(4, 22);
            this.tabBid.Name = "tabBid";
            this.tabBid.Padding = new System.Windows.Forms.Padding(3);
            this.tabBid.Size = new System.Drawing.Size(792, 421);
            this.tabBid.TabIndex = 4;
            this.tabBid.Text = "Заявки";
            this.tabBid.UseVisualStyleBackColor = true;
            // 
            // tabBidProduct
            // 
            this.tabBidProduct.Location = new System.Drawing.Point(4, 22);
            this.tabBidProduct.Name = "tabBidProduct";
            this.tabBidProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabBidProduct.Size = new System.Drawing.Size(792, 421);
            this.tabBidProduct.TabIndex = 5;
            this.tabBidProduct.Text = "Товары в заявке";
            this.tabBidProduct.UseVisualStyleBackColor = true;
            // 
            // counterpartyTableAdapter
            // 
            this.counterpartyTableAdapter.ClearBeforeFill = true;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFilterC;
        private CounterpartyDataSet counterpartyDataSet;
        private System.Windows.Forms.BindingSource counterpartyBindingSource;
        private datasets.counterparty.CounterpartyDataSetTableAdapters.CounterpartyTableAdapter counterpartyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}