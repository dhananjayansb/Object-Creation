namespace Object_Creation
{
    partial class createFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createFolder));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.folderButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderName = new System.Windows.Forms.TextBox();
            this.pathCount = new System.Windows.Forms.TextBox();
            this.folderCount = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.folderSample = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.Location = new System.Drawing.Point(12, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 14);
            this.textBox3.TabIndex = 25;
            this.textBox3.Text = "Folder Path";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // folderPath
            // 
            this.folderPath.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderPath.Location = new System.Drawing.Point(12, 98);
            this.folderPath.MaxLength = 32767000;
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(372, 21);
            this.folderPath.TabIndex = 24;
            // 
            // folderButton
            // 
            this.folderButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.folderButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.folderButton.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderButton.ForeColor = System.Drawing.Color.Black;
            this.folderButton.Location = new System.Drawing.Point(182, 190);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(107, 31);
            this.folderButton.TabIndex = 29;
            this.folderButton.Text = "Create Folder";
            this.folderButton.UseVisualStyleBackColor = false;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(12, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 14);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "Folder Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // folderName
            // 
            this.folderName.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderName.Location = new System.Drawing.Point(12, 145);
            this.folderName.MaxLength = 32767000;
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(372, 21);
            this.folderName.TabIndex = 30;
            // 
            // pathCount
            // 
            this.pathCount.Location = new System.Drawing.Point(397, 99);
            this.pathCount.Name = "pathCount";
            this.pathCount.Size = new System.Drawing.Size(81, 20);
            this.pathCount.TabIndex = 32;
            // 
            // folderCount
            // 
            this.folderCount.Location = new System.Drawing.Point(397, 146);
            this.folderCount.Name = "folderCount";
            this.folderCount.Size = new System.Drawing.Size(81, 20);
            this.folderCount.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(397, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(81, 14);
            this.textBox2.TabIndex = 34;
            this.textBox2.Text = "Count";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // folderSample
            // 
            this.folderSample.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.folderSample.Location = new System.Drawing.Point(397, 12);
            this.folderSample.Name = "folderSample";
            this.folderSample.Size = new System.Drawing.Size(75, 23);
            this.folderSample.TabIndex = 35;
            this.folderSample.Text = "sample";
            this.folderSample.UseVisualStyleBackColor = false;
            this.folderSample.Click += new System.EventHandler(this.folderSample_Click);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox4.Location = new System.Drawing.Point(63, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(300, 21);
            this.textBox4.TabIndex = 36;
            this.textBox4.Text = "Folder Creation";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 238);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.folderSample);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.folderCount);
            this.Controls.Add(this.pathCount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.folderName);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.folderPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createFolder";
            this.Text = "Create Folders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox folderName;
        private System.Windows.Forms.TextBox pathCount;
        private System.Windows.Forms.TextBox folderCount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button folderSample;
        private System.Windows.Forms.TextBox textBox4;
    }
}