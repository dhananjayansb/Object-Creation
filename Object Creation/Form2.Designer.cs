namespace Object_Creation
{
    partial class objCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(objCreation));
            this.create = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dcName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.objType = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ouPath = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.objName = new System.Windows.Forms.TextBox();
            this.objCount = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.grpCategory = new System.Windows.Forms.ComboBox();
            this.grpScope = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objCount)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(154, 574);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(102, 38);
            this.create.TabIndex = 2;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.Create_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.54988F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.45012F));
            this.tableLayoutPanel1.Controls.Add(this.dcName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.userName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.objType, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 138);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dcName
            // 
            this.dcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcName.Location = new System.Drawing.Point(145, 79);
            this.dcName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.dcName.Name = "dcName";
            this.dcName.Size = new System.Drawing.Size(263, 22);
            this.dcName.TabIndex = 8;
            this.dcName.TextChanged += new System.EventHandler(this.dcName_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(145, 41);
            this.password.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(263, 22);
            this.password.TabIndex = 8;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox3.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(3, 113);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 24);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Object Type";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox4.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(3, 79);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 24);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "DC Name";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox5.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox5.Location = new System.Drawing.Point(3, 41);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 24);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Password";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(3, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 24);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "User Name";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(145, 6);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(263, 22);
            this.userName.TabIndex = 7;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // objType
            // 
            this.objType.FormattingEnabled = true;
            this.objType.Items.AddRange(new object[] {
            "User",
            "Group",
            "Computer",
            "Contact",
            "OU"});
            this.objType.Location = new System.Drawing.Point(145, 113);
            this.objType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.objType.Name = "objType";
            this.objType.Size = new System.Drawing.Size(155, 21);
            this.objType.TabIndex = 9;
            this.objType.SelectedIndexChanged += new System.EventHandler(this.objType_SelectedIndexChanged);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox6.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(90, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(240, 24);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "Machine Details";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(90, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(240, 24);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Common Attribute";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.54988F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.45012F));
            this.tableLayoutPanel2.Controls.Add(this.ouPath, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox11, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.objName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.objCount, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 227);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(411, 104);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // ouPath
            // 
            this.ouPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ouPath.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouPath.Location = new System.Drawing.Point(145, 75);
            this.ouPath.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.ouPath.Name = "ouPath";
            this.ouPath.Size = new System.Drawing.Size(263, 24);
            this.ouPath.TabIndex = 8;
            this.ouPath.TextChanged += new System.EventHandler(this.ouPath_TextChanged_1);
            // 
            // textBox10
            // 
            this.textBox10.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox10.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox10.Location = new System.Drawing.Point(3, 75);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(132, 24);
            this.textBox10.TabIndex = 5;
            this.textBox10.Text = "OU Path";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox11.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox11.Location = new System.Drawing.Point(3, 39);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(132, 24);
            this.textBox11.TabIndex = 6;
            this.textBox11.Text = "Object Count";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.textBox12.Size = new System.Drawing.Size(132, 24);
            this.textBox12.TabIndex = 0;
            this.textBox12.Text = "Object Name";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // objName
            // 
            this.objName.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objName.Location = new System.Drawing.Point(145, 6);
            this.objName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.objName.Name = "objName";
            this.objName.Size = new System.Drawing.Size(263, 24);
            this.objName.TabIndex = 7;
            this.objName.TextChanged += new System.EventHandler(this.objName_TextChanged);
            // 
            // objCount
            // 
            this.objCount.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objCount.Location = new System.Drawing.Point(145, 41);
            this.objCount.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.objCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.objCount.Name = "objCount";
            this.objCount.Size = new System.Drawing.Size(120, 24);
            this.objCount.TabIndex = 9;
            this.objCount.ValueChanged += new System.EventHandler(this.objCount_ValueChanged_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.79319F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.20681F));
            this.tableLayoutPanel3.Controls.Add(this.textBox7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.grpCategory, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.grpScope, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 379);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(411, 68);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox7.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox7.Location = new System.Drawing.Point(3, 6);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(132, 24);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "Group Scope";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox8.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox8.Location = new System.Drawing.Point(3, 40);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(132, 24);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = "Group Category";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpCategory
            // 
            this.grpCategory.FormattingEnabled = true;
            this.grpCategory.Items.AddRange(new object[] {
            "Security",
            "Distribution"});
            this.grpCategory.Location = new System.Drawing.Point(146, 42);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(155, 21);
            this.grpCategory.TabIndex = 11;
            this.grpCategory.SelectedIndexChanged += new System.EventHandler(this.grpCategory_SelectedIndexChanged);
            // 
            // grpScope
            // 
            this.grpScope.FormattingEnabled = true;
            this.grpScope.Items.AddRange(new object[] {
            "DomainLocal",
            "Global",
            "Universal"});
            this.grpScope.Location = new System.Drawing.Point(146, 8);
            this.grpScope.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.grpScope.Name = "grpScope";
            this.grpScope.Size = new System.Drawing.Size(155, 21);
            this.grpScope.TabIndex = 10;
            this.grpScope.SelectedIndexChanged += new System.EventHandler(this.grpScope_SelectedIndexChanged);
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox9.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(90, 349);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(240, 24);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Group Attribute";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // objCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 624);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.create);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "objCreation";
            this.Text = "Object Creation";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objCount)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox dcName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.ComboBox objType;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox ouPath;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox objName;
        private System.Windows.Forms.NumericUpDown objCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox grpCategory;
        private System.Windows.Forms.ComboBox grpScope;
        private System.Windows.Forms.TextBox textBox9;
    }
}