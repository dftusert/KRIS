namespace KRIS.windows.bid
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBidNumber = new System.Windows.Forms.TextBox();
            this.tbCreateDate = new System.Windows.Forms.TextBox();
            this.tbStatusDate = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.statusForComboboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusForCombobox = new KRIS.datasets.bid.StatusForCombobox();
            this.tbINN = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.dictionaryTableAdapter = new KRIS.datasets.bid.StatusForComboboxTableAdapters.DictionaryTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.counterpartyDataSet = new KRIS.datasets.counterparty.CounterpartyDataSet();
            this.counterpartyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.counterpartyTableAdapter = new KRIS.datasets.counterparty.CounterpartyDataSetTableAdapters.CounterpartyTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.statusForComboboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusForCombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyDataSetBindingSource)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата создания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата статуса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип заявки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "ИНН покупателя или поставщика";
            // 
            // tbBidNumber
            // 
            this.tbBidNumber.Location = new System.Drawing.Point(15, 25);
            this.tbBidNumber.Name = "tbBidNumber";
            this.tbBidNumber.ReadOnly = true;
            this.tbBidNumber.Size = new System.Drawing.Size(240, 20);
            this.tbBidNumber.TabIndex = 6;
            // 
            // tbCreateDate
            // 
            this.tbCreateDate.Location = new System.Drawing.Point(12, 76);
            this.tbCreateDate.Name = "tbCreateDate";
            this.tbCreateDate.ReadOnly = true;
            this.tbCreateDate.Size = new System.Drawing.Size(243, 20);
            this.tbCreateDate.TabIndex = 7;
            // 
            // tbStatusDate
            // 
            this.tbStatusDate.Location = new System.Drawing.Point(12, 185);
            this.tbStatusDate.Name = "tbStatusDate";
            this.tbStatusDate.ReadOnly = true;
            this.tbStatusDate.Size = new System.Drawing.Size(243, 20);
            this.tbStatusDate.TabIndex = 8;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(12, 241);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(243, 20);
            this.tbType.TabIndex = 9;
            // 
            // cbStatus
            // 
            this.cbStatus.DataSource = this.statusForComboboxBindingSource;
            this.cbStatus.DisplayMember = "term_name";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(12, 130);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(243, 21);
            this.cbStatus.TabIndex = 10;
            this.cbStatus.ValueMember = "id";
            // 
            // statusForComboboxBindingSource
            // 
            this.statusForComboboxBindingSource.DataMember = "Dictionary";
            this.statusForComboboxBindingSource.DataSource = this.statusForCombobox;
            // 
            // statusForCombobox
            // 
            this.statusForCombobox.DataSetName = "StatusForCombobox";
            this.statusForCombobox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbINN
            // 
            this.tbINN.Location = new System.Drawing.Point(12, 291);
            this.tbINN.Name = "tbINN";
            this.tbINN.ReadOnly = true;
            this.tbINN.Size = new System.Drawing.Size(243, 20);
            this.tbINN.TabIndex = 11;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(12, 327);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(243, 39);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "изменить";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dictionaryTableAdapter
            // 
            this.dictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.innDataGridViewTextBoxColumn,
            this.kppDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.counterpartyDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(262, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 356);
            this.dataGridView1.TabIndex = 13;
            // 
            // counterpartyDataSet
            // 
            this.counterpartyDataSet.DataSetName = "CounterpartyDataSet";
            this.counterpartyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // counterpartyDataSetBindingSource
            // 
            this.counterpartyDataSetBindingSource.DataMember = "Counterparty";
            this.counterpartyDataSetBindingSource.DataSource = this.counterpartyDataSet;
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
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.tbINN);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbStatusDate);
            this.Controls.Add(this.tbCreateDate);
            this.Controls.Add(this.tbBidNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение заявки";
            this.Load += new System.EventHandler(this.Modify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusForComboboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusForCombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBidNumber;
        private System.Windows.Forms.TextBox tbCreateDate;
        private System.Windows.Forms.TextBox tbStatusDate;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbINN;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.BindingSource statusForComboboxBindingSource;
        private datasets.bid.StatusForCombobox statusForCombobox;
        private datasets.bid.StatusForComboboxTableAdapters.DictionaryTableAdapter dictionaryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource counterpartyDataSetBindingSource;
        private datasets.counterparty.CounterpartyDataSet counterpartyDataSet;
        private datasets.counterparty.CounterpartyDataSetTableAdapters.CounterpartyTableAdapter counterpartyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kppDataGridViewTextBoxColumn;
    }
}