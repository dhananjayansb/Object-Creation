namespace Object_Creation
{
    partial class productActions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productActions));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.prodPath = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zipPath = new System.Windows.Forms.TextBox();
            this.execute = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.Location = new System.Drawing.Point(12, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 14);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "Product Path";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prodPath
            // 
            this.prodPath.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodPath.Location = new System.Drawing.Point(12, 42);
            this.prodPath.MaxLength = 32767000;
            this.prodPath.Name = "prodPath";
            this.prodPath.Size = new System.Drawing.Size(468, 21);
            this.prodPath.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(0, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 14);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Zip Path";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zipPath
            // 
            this.zipPath.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipPath.Location = new System.Drawing.Point(12, 100);
            this.zipPath.MaxLength = 32767000;
            this.zipPath.Name = "zipPath";
            this.zipPath.Size = new System.Drawing.Size(468, 21);
            this.zipPath.TabIndex = 19;
            // 
            // execute
            // 
            this.execute.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.execute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.execute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.execute.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execute.Location = new System.Drawing.Point(174, 142);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(102, 38);
            this.execute.TabIndex = 21;
            this.execute.Text = "Execute";
            this.execute.UseVisualStyleBackColor = false;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Azure;
            this.progressBar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 200);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(492, 26);
            this.progressBar.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "(Only Applicable for Zip)";
            // 
            // productActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zipPath);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.prodPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productActions";
            this.Text = "Product Actions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox prodPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox zipPath;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
    }
}