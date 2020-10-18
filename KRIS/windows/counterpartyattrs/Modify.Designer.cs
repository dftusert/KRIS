namespace KRIS.windows.counterpartyattrs
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
            this.tbINN = new System.Windows.Forms.TextBox();
            this.tbVal = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbAttr = new System.Windows.Forms.ComboBox();
            this.dictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attrsForComboBox = new KRIS.datasets.counterpartyattrs.AttrsForComboBox();
            this.dictionaryTableAdapter = new KRIS.datasets.counterpartyattrs.AttrsForComboBoxTableAdapters.DictionaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attrsForComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ИНН";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Атрибут";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Значение";
            // 
            // tbINN
            // 
            this.tbINN.Location = new System.Drawing.Point(13, 26);
            this.tbINN.Name = "tbINN";
            this.tbINN.ReadOnly = true;
            this.tbINN.Size = new System.Drawing.Size(240, 20);
            this.tbINN.TabIndex = 3;
            // 
            // tbVal
            // 
            this.tbVal.Location = new System.Drawing.Point(13, 131);
            this.tbVal.Name = "tbVal";
            this.tbVal.Size = new System.Drawing.Size(240, 20);
            this.tbVal.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 169);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(240, 37);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbAttr
            // 
            this.cbAttr.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dictionaryBindingSource, "term_name", true));
            this.cbAttr.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dictionaryBindingSource, "id", true));
            this.cbAttr.DataSource = this.dictionaryBindingSource;
            this.cbAttr.DisplayMember = "term_name";
            this.cbAttr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttr.FormattingEnabled = true;
            this.cbAttr.Location = new System.Drawing.Point(13, 79);
            this.cbAttr.Name = "cbAttr";
            this.cbAttr.Size = new System.Drawing.Size(240, 21);
            this.cbAttr.TabIndex = 7;
            this.cbAttr.ValueMember = "id";
            // 
            // dictionaryBindingSource
            // 
            this.dictionaryBindingSource.DataMember = "Dictionary";
            this.dictionaryBindingSource.DataSource = this.attrsForComboBox;
            // 
            // attrsForComboBox
            // 
            this.attrsForComboBox.DataSetName = "AttrsForComboBox";
            this.attrsForComboBox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dictionaryTableAdapter
            // 
            this.dictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 221);
            this.Controls.Add(this.cbAttr);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbVal);
            this.Controls.Add(this.tbINN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение атр. пок. или пост.";
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attrsForComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbINN;
        private System.Windows.Forms.TextBox tbVal;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbAttr;
        private datasets.counterpartyattrs.AttrsForComboBox attrsForComboBox;
        private System.Windows.Forms.BindingSource dictionaryBindingSource;
        private datasets.counterpartyattrs.AttrsForComboBoxTableAdapters.DictionaryTableAdapter dictionaryTableAdapter;
    }
}