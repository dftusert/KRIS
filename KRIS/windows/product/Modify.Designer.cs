namespace KRIS.windows.product
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
            this.tbVendorCode = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRecPrice = new System.Windows.Forms.TextBox();
            this.tbRemainder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOKEI = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.oKEIForCombobox = new KRIS.datasets.product.OKEIForCombobox();
            this.oKEIForComboboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryTableAdapter = new KRIS.datasets.product.OKEIForComboboxTableAdapters.DictionaryTableAdapter();
            this.typeForCombobox = new KRIS.datasets.product.TypeForCombobox();
            this.typeForComboboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryTableAdapter1 = new KRIS.datasets.product.TypeForComboboxTableAdapters.DictionaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.oKEIForCombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKEIForComboboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeForCombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeForComboboxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVendorCode
            // 
            this.tbVendorCode.Location = new System.Drawing.Point(15, 27);
            this.tbVendorCode.Name = "tbVendorCode";
            this.tbVendorCode.Size = new System.Drawing.Size(240, 20);
            this.tbVendorCode.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(15, 81);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(240, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbRecPrice
            // 
            this.tbRecPrice.Location = new System.Drawing.Point(15, 252);
            this.tbRecPrice.Name = "tbRecPrice";
            this.tbRecPrice.Size = new System.Drawing.Size(240, 20);
            this.tbRecPrice.TabIndex = 4;
            // 
            // tbRemainder
            // 
            this.tbRemainder.Location = new System.Drawing.Point(15, 306);
            this.tbRemainder.Name = "tbRemainder";
            this.tbRemainder.Size = new System.Drawing.Size(240, 20);
            this.tbRemainder.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ОКЕИ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Рекомендованная цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Остаток на складе";
            // 
            // cbOKEI
            // 
            this.cbOKEI.DataSource = this.oKEIForComboboxBindingSource;
            this.cbOKEI.DisplayMember = "term_name";
            this.cbOKEI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOKEI.FormattingEnabled = true;
            this.cbOKEI.Location = new System.Drawing.Point(15, 138);
            this.cbOKEI.Name = "cbOKEI";
            this.cbOKEI.Size = new System.Drawing.Size(240, 21);
            this.cbOKEI.TabIndex = 12;
            this.cbOKEI.ValueMember = "id";
            // 
            // cbType
            // 
            this.cbType.DataSource = this.typeForComboboxBindingSource;
            this.cbType.DisplayMember = "term_name";
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(15, 195);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(240, 21);
            this.cbType.TabIndex = 13;
            this.cbType.ValueMember = "id";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(15, 347);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(240, 36);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Изменить";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // oKEIForCombobox
            // 
            this.oKEIForCombobox.DataSetName = "OKEIForCombobox";
            this.oKEIForCombobox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oKEIForComboboxBindingSource
            // 
            this.oKEIForComboboxBindingSource.DataMember = "Dictionary";
            this.oKEIForComboboxBindingSource.DataSource = this.oKEIForCombobox;
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
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 393);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbOKEI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRemainder);
            this.Controls.Add(this.tbRecPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbVendorCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение товара";
            this.Load += new System.EventHandler(this.Modify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oKEIForCombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKEIForComboboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeForCombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeForComboboxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVendorCode;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRecPrice;
        private System.Windows.Forms.TextBox tbRemainder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOKEI;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.BindingSource oKEIForComboboxBindingSource;
        private datasets.product.OKEIForCombobox oKEIForCombobox;
        private datasets.product.OKEIForComboboxTableAdapters.DictionaryTableAdapter dictionaryTableAdapter;
        private System.Windows.Forms.BindingSource typeForComboboxBindingSource;
        private datasets.product.TypeForCombobox typeForCombobox;
        private datasets.product.TypeForComboboxTableAdapters.DictionaryTableAdapter dictionaryTableAdapter1;
    }
}