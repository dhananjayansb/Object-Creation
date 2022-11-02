namespace Object_Creation
{
    partial class customAttribute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customAttribute));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nameText = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataType = new System.Windows.Forms.ComboBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.attributeName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.createAttribute = new System.Windows.Forms.Button();
            this.downloadScript = new System.Windows.Forms.Button();
            this.sample = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.domUserName = new System.Windows.Forms.TextBox();
            this.domPassword = new System.Windows.Forms.TextBox();
            this.domServerIp = new System.Windows.Forms.TextBox();
            this.textbox14 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.54988F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.45012F));
            this.tableLayoutPanel2.Controls.Add(this.nameText, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dataType, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox12, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(54, 258);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.125F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.875F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(408, 65);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(143, 6);
            this.nameText.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(254, 24);
            this.nameText.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox3.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(3, 40);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(130, 24);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Data Type";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataType
            // 
            this.dataType.FormattingEnabled = true;
            this.dataType.Items.AddRange(new object[] {
            "String",
            "Int",
            "Boolean"});
            this.dataType.Location = new System.Drawing.Point(143, 40);
            this.dataType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.dataType.Name = "dataType";
            this.dataType.Size = new System.Drawing.Size(254, 21);
            this.dataType.TabIndex = 16;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Window;
            this.textBox12.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox12.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox12.Location = new System.Drawing.Point(3, 6);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(130, 24);
            this.textBox12.TabIndex = 0;
            this.textBox12.Text = "Attribute Name";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // attributeName
            // 
            this.attributeName.Location = new System.Drawing.Point(0, 0);
            this.attributeName.Name = "attributeName";
            this.attributeName.Size = new System.Drawing.Size(100, 20);
            this.attributeName.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(163, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(217, 17);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Custom Attribute";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createAttribute
            // 
            this.createAttribute.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAttribute.Location = new System.Drawing.Point(166, 355);
            this.createAttribute.Name = "createAttribute";
            this.createAttribute.Size = new System.Drawing.Size(172, 29);
            this.createAttribute.TabIndex = 15;
            this.createAttribute.Text = "Create Attribute";
            this.createAttribute.UseVisualStyleBackColor = true;
            this.createAttribute.Click += new System.EventHandler(this.createAttribute_Click);
            // 
            // downloadScript
            // 
            this.downloadScript.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadScript.Location = new System.Drawing.Point(190, 52);
            this.downloadScript.Name = "downloadScript";
            this.downloadScript.Size = new System.Drawing.Size(160, 29);
            this.downloadScript.TabIndex = 17;
            this.downloadScript.Text = "Download Script";
            this.downloadScript.UseVisualStyleBackColor = true;
            this.downloadScript.Click += new System.EventHandler(this.downloadScript_Click);
            // 
            // sample
            // 
            this.sample.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sample.Location = new System.Drawing.Point(460, 15);
            this.sample.Name = "sample";
            this.sample.Size = new System.Drawing.Size(75, 23);
            this.sample.TabIndex = 20;
            this.sample.Text = "sample";
            this.sample.UseVisualStyleBackColor = false;
            this.sample.Click += new System.EventHandler(this.sample_Click);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox6.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(133, 101);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(240, 17);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "Server Details";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.54988F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.45012F));
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.domUserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.domPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.domServerIp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textbox14, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.31507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.68493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 104);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox5.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox5.Location = new System.Drawing.Point(3, 40);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(134, 24);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Password";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox4.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(3, 6);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(134, 24);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Administrator";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // domUserName
            // 
            this.domUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domUserName.Location = new System.Drawing.Point(143, 8);
            this.domUserName.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.domUserName.Name = "domUserName";
            this.domUserName.Size = new System.Drawing.Size(262, 22);
            this.domUserName.TabIndex = 7;
            // 
            // domPassword
            // 
            this.domPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domPassword.Location = new System.Drawing.Point(143, 42);
            this.domPassword.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.domPassword.Name = "domPassword";
            this.domPassword.PasswordChar = '*';
            this.domPassword.Size = new System.Drawing.Size(262, 22);
            this.domPassword.TabIndex = 8;
            // 
            // domServerIp
            // 
            this.domServerIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domServerIp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.domServerIp.Location = new System.Drawing.Point(143, 77);
            this.domServerIp.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.domServerIp.Name = "domServerIp";
            this.domServerIp.Size = new System.Drawing.Size(262, 22);
            this.domServerIp.TabIndex = 9;
            // 
            // textbox14
            // 
            this.textbox14.Cursor = System.Windows.Forms.Cursors.No;
            this.textbox14.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textbox14.Location = new System.Drawing.Point(3, 75);
            this.textbox14.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textbox14.Name = "textbox14";
            this.textbox14.ReadOnly = true;
            this.textbox14.Size = new System.Drawing.Size(134, 24);
            this.textbox14.TabIndex = 9;
            this.textbox14.Text = "LDAP Server IP";
            this.textbox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 404);
            this.Controls.Add(this.sample);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.downloadScript);
            this.Controls.Add(this.createAttribute);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customAttribute";
            this.Text = "Custom Attribute";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button createAttribute;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox dataType;
        private System.Windows.Forms.TextBox attributeName;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button downloadScript;
        private System.Windows.Forms.Button sample;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox domUserName;
        private System.Windows.Forms.TextBox domPassword;
        private System.Windows.Forms.TextBox domServerIp;
        private System.Windows.Forms.TextBox textbox14;
    }
}