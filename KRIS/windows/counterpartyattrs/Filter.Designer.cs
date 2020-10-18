namespace KRIS.windows.counterpartyattrs
{
    partial class Filter
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
            this.tbValue = new System.Windows.Forms.Label();
            this.tbINN = new System.Windows.Forms.TextBox();
            this.tbAttr = new System.Windows.Forms.TextBox();
            this.tbVal = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Атрибут";
            // 
            // tbValue
            // 
            this.tbValue.AutoSize = true;
            this.tbValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbValue.Location = new System.Drawing.Point(12, 116);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(64, 15);
            this.tbValue.TabIndex = 2;
            this.tbValue.Text = "Значение";
            // 
            // tbINN
            // 
            this.tbINN.Location = new System.Drawing.Point(12, 25);
            this.tbINN.Name = "tbINN";
            this.tbINN.Size = new System.Drawing.Size(240, 20);
            this.tbINN.TabIndex = 3;
            // 
            // tbAttr
            // 
            this.tbAttr.Location = new System.Drawing.Point(12, 77);
            this.tbAttr.Name = "tbAttr";
            this.tbAttr.Size = new System.Drawing.Size(240, 20);
            this.tbAttr.TabIndex = 4;
            // 
            // tbVal
            // 
            this.tbVal.Location = new System.Drawing.Point(12, 132);
            this.tbVal.Name = "tbVal";
            this.tbVal.Size = new System.Drawing.Size(240, 20);
            this.tbVal.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(11, 173);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Сбросить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(177, 173);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 39);
            this.btnSetup.TabIndex = 7;
            this.btnSetup.Text = "Установить";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 225);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbVal);
            this.Controls.Add(this.tbAttr);
            this.Controls.Add(this.tbINN);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Фильтр атр. пок. и пост.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tbValue;
        private System.Windows.Forms.TextBox tbINN;
        private System.Windows.Forms.TextBox tbAttr;
        private System.Windows.Forms.TextBox tbVal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSetup;
    }
}