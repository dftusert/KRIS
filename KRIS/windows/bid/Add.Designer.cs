namespace KRIS.windows.bid
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
            this.tbBidNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCreateDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStatusDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbINN = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCounterparty = new System.Windows.Forms.DataGridView();
            this.counterpartyDataSet = new KRIS.datasets.counterparty.CounterpartyDataSet();
            this.counterpartyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusForCombobox = new KRIS.datasets.bid.StatusForCombobox();
            this.statusForComboboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryTableAdapter = new KRIS.datasets.bid.StatusForComboboxTableAdapters.DictionaryTableAdapter();
            this.typeForCombobox = new KRIS.datasets.bid.TypeForCombobox();
            this.typeForComboboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryTableAdapter1 = new KRIS.datasets.bid.TypeForComboboxTableAdapters.DictionaryTableAdapter();
            this.counterpartyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.counterpartyTableAdapter = new KRIS.datasets.counterparty.CounterpartyDataSetTableAdapters.CounterpartyTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterparty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusForCombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusForComboboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeForCombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeForComboboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заявки";
            // 
            // tbBidNumber
            // 
            this.tbBidNumber.Location = new System.Drawing.Point(13, 30);
            this.tbBidNumber.Name = "tbBidNumber";
            this.tbBidNumber.ReadOnly = true;
            this.tbBidNumber.Size = new System.Drawing.Size(240, 20);
            this.tbBidNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата создания";
            // 
            // tbCreateDate
            // 
            this.tbCreateDate.Location = new System.Drawing.Point(13, 85);
            this.tbCreateDate.Name = "tbCreateDate";
            this.tbCreateDate.ReadOnly = true;
            this.tbCreateDate.Size = new System.Drawing.Size(240, 20);
            this.tbCreateDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Статус";
            // 
            // cbStatus
            // 
            this.cbStatus.DataSource = this.statusForComboboxBindingSource;
            this.cbStatus.DisplayMember = "term_name";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Enabled = false;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(13, 142);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(240, 21);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.ValueMember = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата статуса";
            // 
            // tbStatusDate
            // 
            this.tbStatusDate.Location = new System.Drawing.Point(13, 200);
            this.tbStatusDate.Name = "tbStatusDate";
            this.tbStatusDate.ReadOnly = true;
            this.tbStatusDate.Size = new System.Drawing.Size(240, 20);
            this.tbStatusDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тип заявки";
            // 
            // cbType
            // 
            this.cbType.DataSource = this.typeForComboboxBindingSource;
            this.cbType.DisplayMember = "term_name";
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(13, 253);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(240, 21);
            this.cbType.TabIndex = 9;
            this.cbType.ValueMember = "id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "ИНН покупателя или поставщика";
            // 
            // tbINN
            // 
            this.tbINN.Location = new System.Drawing.Point(13, 308);
            this.tbINN.Name = "tbINN";
            this.tbINN.Size = new System.Drawing.Size(240, 20);
            this.tbINN.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 41);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCounterparty
            // 
            this.dgvCounterparty.AllowUserToAddRows = false;
            this.dgvCounterparty.AllowUserToDeleteRows = false;
            this.dgvCounterparty.AutoGenerateColumns = false;
            this.dgvCounterparty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCounterparty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.innDataGridViewTextBoxColumn,
            this.kppDataGridViewTextBoxColumn});
            this.dgvCounterparty.DataSource = this.counterpartyBindingSource;
            this.dgvCounterparty.Location = new System.Drawing.Point(259, 13);
            this.dgvCounterparty.Name = "dgvCounterparty";
            this.dgvCounterparty.ReadOnly = true;
            this.dgvCounterparty.Size = new System.Drawing.Size(343, 373);
            this.dgvCounterparty.TabIndex = 13;
            // 
            // counterpartyDataSet
            // 
            this.counterpartyDataSet.DataSetName = "CounterpartyDataSet";
            this.counterpartyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // counterpartyDataSetBindingSource
            // 
            this.counterpartyDataSetBindingSource.DataSource = this.counterpartyDataSet;
            this.counterpartyDataSetBindingSource.Position = 0;
            // 
            // statusForCombobox
            // 
            this.statusForCombobox.DataSetName = "StatusForCombobox";
            this.statusForCombobox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusForComboboxBindingSource
            // 
            this.statusForComboboxBindingSource.DataMember = "Dictionary";
            this.statusForComboboxBindingSource.DataSource = this.statusForCombobox;
            // 
            // dictionaryTableAdapter
            // 
            this.dictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // typeForCombobox
            // 
            this.typeForCombobox.DataSetName = "TypeForCombobox";
            this.typeForCombobox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeForComboboxBindingSource
            // 
            this.typeForComboboxBindingSource.DataMember = "Dictionary";
            this.typeForComboboxBindingSource.DataSource = this.typeForCombobox;
            // 
            // dictionaryTableAdapter1
            // 
            this.dictionaryTableAdapter1.ClearBeforeFill = true;
            // 
            // counterpartyBindingSource
            // 
            this.counterpartyBindingSource.DataMember = "Counterparty";
            this.counterpartyBindingSource.DataSource = this.counterpartyDataSetBindingSource;
            // 
            // counterpartyTableAdapter
            // 
            this.counterpartyTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // innDataGridViewTextBoxColumn
            // 
            this.innDataGridViewTextBoxColumn.DataPropertyName = "inn";
            this.innDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.innDataGridViewTextBoxColumn.Name = "innDataGridViewTextBoxColumn";
            this.innDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kppDataGridViewTextBoxColumn
            // 
            this.kppDataGridViewTextBoxColumn.DataPropertyName = "kpp";
            this.kppDataGridViewTextBoxColumn.HeaderText = "КПП";
            this.kppDataGridViewTextBoxColumn.Name = "kppDataGridViewTextBoxColumn";
            this.kppDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 398);
            this.Controls.Add(this.dgvCounterparty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbINN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStatusDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCreateDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBidNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление заявки";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterparty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusForCombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusForComboboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeForCombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeForComboboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBidNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCreateDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStatusDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCounterparty;
        private System.Windows.Forms.BindingSource counterpartyDataSetBindingSource;
        private datasets.counterparty.CounterpartyDataSet counterpartyDataSet;
        private System.Windows.Forms.TextBox tbINN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource statusForComboboxBindingSource;
        private datasets.bid.StatusForCombobox statusForCombobox;
        private datasets.bid.StatusForComboboxTableAdapters.DictionaryTableAdapter dictionaryTableAdapter;
        private System.Windows.Forms.BindingSource typeForComboboxBindingSource;
        private datasets.bid.TypeForCombobox typeForCombobox;
        private datasets.bid.TypeForComboboxTableAdapters.DictionaryTableAdapter dictionaryTableAdapter1;
        private System.Windows.Forms.BindingSource counterpartyBindingSource;
        private datasets.counterparty.CounterpartyDataSetTableAdapters.CounterpartyTableAdapter counterpartyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kppDataGridViewTextBoxColumn;
    }
}