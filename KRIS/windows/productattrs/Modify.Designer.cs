namespace KRIS.windows.productattrs
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
            this.tbVendorCode = new System.Windows.Forms.TextBox();
            this.cbAttr = new System.Windows.Forms.ComboBox();
            this.tbVal = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.attrsForCombobox = new KRIS.datasets.productattrs.AttrsForCombobox();
            this.attrsForComboboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryTableAdapter = new KRIS.datasets.productattrs.AttrsForComboboxTableAdapters.DictionaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.attrsForCombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attrsForComboboxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Атрибут";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Значение";
            // 
            // tbVendorCode
            // 
            this.tbVendorCode.Location = new System.Drawing.Point(12, 27);
            this.tbVendorCode.Name = "tbVendorCode";
            this.tbVendorCode.ReadOnly = true;
            this.tbVendorCode.Size = new System.Drawing.Size(240, 20);
            this.tbVendorCode.TabIndex = 3;
            // 
            // cbAttr
            // 
            this.cbAttr.DataSource = this.attrsForComboboxBindingSource;
            this.cbAttr.DisplayMember = "term_name";
            this.cbAttr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttr.FormattingEnabled = true;
            this.cbAttr.Location = new System.Drawing.Point(12, 81);
            this.cbAttr.Name = "cbAttr";
            this.cbAttr.Size = new System.Drawing.Size(240, 21);
            this.cbAttr.TabIndex = 4;
            this.cbAttr.ValueMember = "id";
            // 
            // tbVal
            // 
            this.tbVal.Location = new System.Drawing.Point(12, 140);
            this.tbVal.Name = "tbVal";
            this.tbVal.Size = new System.Drawing.Size(240, 20);
            this.tbVal.TabIndex = 5;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(12, 178);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(240, 38);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Изменить";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // attrsForCombobox
            // 
            this.attrsForCombobox.DataSetName = "AttrsForCombobox";
            this.attrsForCombobox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attrsForComboboxBindingSource
            // 
            this.attrsForComboboxBindingSource.DataMember = "Dictionary";
            this.attrsForComboboxBindingSource.DataSource = this.attrsForCombobox;
            // 
            // dictionaryTableAdapter
            // 
            this.dictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 231);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.tbVal);
            this.Controls.Add(this.cbAttr);
            this.Controls.Add(this.tbVendorCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение атрибута товара";
            this.Load += new System.EventHandler(this.Modify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attrsForCombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attrsForComboboxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVendorCode;
        private System.Windows.Forms.ComboBox cbAttr;
        private System.Windows.Forms.TextBox tbVal;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.BindingSource attrsForComboboxBindingSource;
        private datasets.productattrs.AttrsForCombobox attrsForCombobox;
        private datasets.productattrs.AttrsForComboboxTableAdapters.DictionaryTableAdapter dictionaryTableAdapter;
    }
}