﻿namespace KRIS.windows.productattrs
{
    partial class Delete
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVendorCode = new System.Windows.Forms.TextBox();
            this.tbAttr = new System.Windows.Forms.TextBox();
            this.tbVal = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Атрибут";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 115);
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
            // tbAttr
            // 
            this.tbAttr.Location = new System.Drawing.Point(12, 80);
            this.tbAttr.Name = "tbAttr";
            this.tbAttr.ReadOnly = true;
            this.tbAttr.Size = new System.Drawing.Size(240, 20);
            this.tbAttr.TabIndex = 4;
            // 
            // tbVal
            // 
            this.tbVal.Location = new System.Drawing.Point(12, 133);
            this.tbVal.Name = "tbVal";
            this.tbVal.ReadOnly = true;
            this.tbVal.Size = new System.Drawing.Size(240, 20);
            this.tbVal.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(240, 37);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 222);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbVal);
            this.Controls.Add(this.tbAttr);
            this.Controls.Add(this.tbVendorCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление атрибута товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVendorCode;
        private System.Windows.Forms.TextBox tbAttr;
        private System.Windows.Forms.TextBox tbVal;
        private System.Windows.Forms.Button btnDelete;
    }
}