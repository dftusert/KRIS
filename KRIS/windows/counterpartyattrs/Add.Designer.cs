namespace KRIS.windows.counterpartyattrs
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
            this.tbINN = new System.Windows.Forms.TextBox();
            this.tbVal = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnRecovery = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbAttr = new System.Windows.Forms.ComboBox();
            this.dictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attrsForComboBox = new KRIS.datasets.counterpartyattrs.AttrsForComboBox();
            this.dictionaryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attrsForComboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryTableAdapter = new KRIS.datasets.counterpartyattrs.AttrsForComboBoxTableAdapters.DictionaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attrsForComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attrsForComboBoxBindingSource)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Атрибут";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Значение";
            // 
            // tbINN
            // 
            this.tbINN.Location = new System.Drawing.Point(12, 25);
            this.tbINN.Name = "tbINN";
            this.tbINN.Size = new System.Drawing.Size(240, 20);
            this.tbINN.TabIndex = 3;
            // 
            // tbVal
            // 
            this.tbVal.Location = new System.Drawing.Point(12, 125);
            this.tbVal.Name = "tbVal";
            this.tbVal.Size = new System.Drawing.Size(240, 20);
            this.tbVal.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(15, 166);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 71);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Проверить в списке удаленных";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnRecovery
            // 
            this.btnRecovery.Location = new System.Drawing.Point(96, 166);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(75, 71);
            this.btnRecovery.TabIndex = 7;
            this.btnRecovery.Text = "Восстановить из списка удаленных";
            this.btnRecovery.UseVisualStyleBackColor = true;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(177, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 71);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить новый";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbAttr
            // 
            this.cbAttr.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dictionaryBindingSource, "id", true));
            this.cbAttr.DataSource = this.dictionaryBindingSource;
            this.cbAttr.DisplayMember = "term_name";
            this.cbAttr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttr.FormattingEnabled = true;
            this.cbAttr.Location = new System.Drawing.Point(12, 76);
            this.cbAttr.Name = "cbAttr";
            this.cbAttr.Size = new System.Drawing.Size(243, 21);
            this.cbAttr.TabIndex = 10;
            this.cbAttr.Tag = "";
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
            // dictionaryBindingSource1
            // 
            this.dictionaryBindingSource1.DataMember = "Dictionary";
            this.dictionaryBindingSource1.DataSource = this.attrsForComboBoxBindingSource;
            // 
            // attrsForComboBoxBindingSource
            // 
            this.attrsForComboBoxBindingSource.DataSource = this.attrsForComboBox;
            this.attrsForComboBoxBindingSource.Position = 0;
            // 
            // dictionaryTableAdapter
            // 
            this.dictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 249);
            this.Controls.Add(this.cbAttr);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbVal);
            this.Controls.Add(this.tbINN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление атр. пок. или пост.";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attrsForComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attrsForComboBoxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbINN;
        private System.Windows.Forms.TextBox tbVal;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbAttr;
        private System.Windows.Forms.BindingSource attrsForComboBoxBindingSource;
        private datasets.counterpartyattrs.AttrsForComboBox attrsForComboBox;
        private System.Windows.Forms.BindingSource dictionaryBindingSource;
        private datasets.counterpartyattrs.AttrsForComboBoxTableAdapters.DictionaryTableAdapter dictionaryTableAdapter;
        private System.Windows.Forms.BindingSource dictionaryBindingSource1;
    }
}