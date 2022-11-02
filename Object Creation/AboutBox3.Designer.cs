namespace Object_Creation
{
    partial class regEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regEditor));
            this.admpProduct = new System.Windows.Forms.CheckBox();
            this.erpProduct = new System.Windows.Forms.CheckBox();
            this.rmpProduct = new System.Windows.Forms.CheckBox();
            this.deleteReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admpProduct
            // 
            this.admpProduct.AutoSize = true;
            this.admpProduct.BackColor = System.Drawing.Color.Transparent;
            this.admpProduct.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admpProduct.ForeColor = System.Drawing.SystemColors.WindowText;
            this.admpProduct.Location = new System.Drawing.Point(17, 12);
            this.admpProduct.Name = "admpProduct";
            this.admpProduct.Size = new System.Drawing.Size(68, 24);
            this.admpProduct.TabIndex = 0;
            this.admpProduct.Text = "ADMP";
            this.admpProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.admpProduct.UseVisualStyleBackColor = false;
            // 
            // erpProduct
            // 
            this.erpProduct.AutoSize = true;
            this.erpProduct.BackColor = System.Drawing.Color.Transparent;
            this.erpProduct.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erpProduct.ForeColor = System.Drawing.SystemColors.WindowText;
            this.erpProduct.Location = new System.Drawing.Point(155, 12);
            this.erpProduct.Name = "erpProduct";
            this.erpProduct.Size = new System.Drawing.Size(58, 24);
            this.erpProduct.TabIndex = 1;
            this.erpProduct.Text = "ERP";
            this.erpProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.erpProduct.UseVisualStyleBackColor = false;
            // 
            // rmpProduct
            // 
            this.rmpProduct.AutoSize = true;
            this.rmpProduct.BackColor = System.Drawing.Color.Transparent;
            this.rmpProduct.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmpProduct.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rmpProduct.Location = new System.Drawing.Point(91, 12);
            this.rmpProduct.Name = "rmpProduct";
            this.rmpProduct.Size = new System.Drawing.Size(58, 24);
            this.rmpProduct.TabIndex = 2;
            this.rmpProduct.Text = "RMP";
            this.rmpProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rmpProduct.UseVisualStyleBackColor = false;
            // 
            // deleteReg
            // 
            this.deleteReg.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteReg.Location = new System.Drawing.Point(60, 54);
            this.deleteReg.Name = "deleteReg";
            this.deleteReg.Size = new System.Drawing.Size(108, 29);
            this.deleteReg.TabIndex = 3;
            this.deleteReg.Text = "Delete Reg";
            this.deleteReg.UseVisualStyleBackColor = true;
            this.deleteReg.Click += new System.EventHandler(this.deleteReg_Click);
            // 
            // regEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 95);
            this.Controls.Add(this.deleteReg);
            this.Controls.Add(this.rmpProduct);
            this.Controls.Add(this.erpProduct);
            this.Controls.Add(this.admpProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "regEditor";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reg Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox admpProduct;
        private System.Windows.Forms.CheckBox erpProduct;
        private System.Windows.Forms.CheckBox rmpProduct;
        private System.Windows.Forms.Button deleteReg;
    }
}
