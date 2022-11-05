namespace Object_Creation
{
    partial class modifyObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifyObject));
            this.sample = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textbox14 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.serverIp = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.objName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.objType = new System.Windows.Forms.ComboBox();
            this.modify = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.userControl = new System.Windows.Forms.TabPage();
            this.addAttribute = new System.Windows.Forms.Button();
            this.attributeValue = new System.Windows.Forms.TextBox();
            this.attributeName = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupControl = new System.Windows.Forms.TabPage();
            this.attrNameList = new System.Windows.Forms.ListBox();
            this.attrValueList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.userControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // sample
            // 
            this.sample.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sample.Location = new System.Drawing.Point(819, 12);
            this.sample.Name = "sample";
            this.sample.Size = new System.Drawing.Size(81, 28);
            this.sample.TabIndex = 19;
            this.sample.Text = "sample";
            this.sample.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox6.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(571, 76);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(240, 17);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "Server Details";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox14
            // 
            this.textbox14.Cursor = System.Windows.Forms.Cursors.No;
            this.textbox14.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textbox14.Location = new System.Drawing.Point(3, 80);
            this.textbox14.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textbox14.Name = "textbox14";
            this.textbox14.ReadOnly = true;
            this.textbox14.Size = new System.Drawing.Size(134, 24);
            this.textbox14.TabIndex = 9;
            this.textbox14.Text = "LDAP Server IP";
            this.textbox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox3.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(3, 114);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(134, 24);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Object Type";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox5.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox5.Location = new System.Drawing.Point(3, 42);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(134, 24);
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
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(134, 24);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Administrator";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(143, 8);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(262, 22);
            this.userName.TabIndex = 7;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(143, 44);
            this.password.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(262, 22);
            this.password.TabIndex = 8;
            // 
            // serverIp
            // 
            this.serverIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverIp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.serverIp.Location = new System.Drawing.Point(143, 82);
            this.serverIp.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.serverIp.Name = "serverIp";
            this.serverIp.Size = new System.Drawing.Size(262, 22);
            this.serverIp.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.54988F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.45012F));
            this.tableLayoutPanel1.Controls.Add(this.objName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.userName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.serverIp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.objType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textbox14, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(492, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.31507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.68493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 193);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // objName
            // 
            this.objName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.objName.Location = new System.Drawing.Point(143, 154);
            this.objName.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.objName.Name = "objName";
            this.objName.Size = new System.Drawing.Size(262, 22);
            this.objName.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox4.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(3, 152);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(134, 24);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = "Object Name";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.objType.Location = new System.Drawing.Point(143, 118);
            this.objType.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.objType.Name = "objType";
            this.objType.Size = new System.Drawing.Size(262, 21);
            this.objType.TabIndex = 9;
            // 
            // modify
            // 
            this.modify.BackColor = System.Drawing.SystemColors.Desktop;
            this.modify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modify.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.Location = new System.Drawing.Point(646, 325);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(102, 38);
            this.modify.TabIndex = 11;
            this.modify.Text = "Modify";
            this.modify.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.userControl);
            this.tabControl1.Controls.Add(this.groupControl);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 461);
            this.tabControl1.TabIndex = 20;
            // 
            // userControl
            // 
            this.userControl.Controls.Add(this.attrValueList);
            this.userControl.Controls.Add(this.attrNameList);
            this.userControl.Controls.Add(this.addAttribute);
            this.userControl.Controls.Add(this.attributeValue);
            this.userControl.Controls.Add(this.attributeName);
            this.userControl.Controls.Add(this.textBox8);
            this.userControl.Controls.Add(this.textBox9);
            this.userControl.Location = new System.Drawing.Point(4, 22);
            this.userControl.Name = "userControl";
            this.userControl.Size = new System.Drawing.Size(466, 435);
            this.userControl.TabIndex = 0;
            this.userControl.Text = "User";
            this.userControl.UseVisualStyleBackColor = true;
            // 
            // addAttribute
            // 
            this.addAttribute.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addAttribute.Location = new System.Drawing.Point(375, 36);
            this.addAttribute.Name = "addAttribute";
            this.addAttribute.Size = new System.Drawing.Size(88, 26);
            this.addAttribute.TabIndex = 25;
            this.addAttribute.Text = "Add Attribute";
            this.addAttribute.UseVisualStyleBackColor = false;
            // 
            // attributeValue
            // 
            this.attributeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributeValue.Location = new System.Drawing.Point(194, 39);
            this.attributeValue.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.attributeValue.Name = "attributeValue";
            this.attributeValue.Size = new System.Drawing.Size(177, 22);
            this.attributeValue.TabIndex = 24;
            // 
            // attributeName
            // 
            this.attributeName.FormattingEnabled = true;
            this.attributeName.Items.AddRange(new object[] {
            "givenName",
            "sn",
            "displayName",
            "description",
            "physicalDeliveryOfficeName",
            "telephoneNumber",
            "mail",
            "wWWHomePage",
            "sAMAccountName",
            "streetAddress",
            "postOfficeBox",
            "postalCode",
            "co",
            "msNPAllowDialin"});
            this.attributeName.Location = new System.Drawing.Point(7, 38);
            this.attributeName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.attributeName.Name = "attributeName";
            this.attributeName.Size = new System.Drawing.Size(167, 21);
            this.attributeName.TabIndex = 23;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox8.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(21, 11);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(130, 17);
            this.textBox8.TabIndex = 21;
            this.textBox8.Text = "Attribute Name";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox9.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(211, 11);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(126, 17);
            this.textBox9.TabIndex = 22;
            this.textBox9.Text = "Value";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl
            // 
            this.groupControl.Location = new System.Drawing.Point(4, 22);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(466, 435);
            this.groupControl.TabIndex = 1;
            this.groupControl.Text = "Group";
            this.groupControl.UseVisualStyleBackColor = true;
            // 
            // attrNameList
            // 
            this.attrNameList.FormattingEnabled = true;
            this.attrNameList.Location = new System.Drawing.Point(7, 85);
            this.attrNameList.Name = "attrNameList";
            this.attrNameList.Size = new System.Drawing.Size(167, 342);
            this.attrNameList.TabIndex = 26;
            // 
            // attrValueList
            // 
            this.attrValueList.FormattingEnabled = true;
            this.attrValueList.Location = new System.Drawing.Point(194, 85);
            this.attrValueList.Name = "attrValueList";
            this.attrValueList.Size = new System.Drawing.Size(177, 342);
            this.attrValueList.TabIndex = 27;
            // 
            // modifyObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 505);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.sample);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.modify);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modifyObject";
            this.Text = "Modify Object";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.userControl.ResumeLayout(false);
            this.userControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sample;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textbox14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox serverIp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage groupControl;
        private System.Windows.Forms.TextBox objName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox objType;
        private System.Windows.Forms.TabPage userControl;
        private System.Windows.Forms.TextBox attributeValue;
        private System.Windows.Forms.ComboBox attributeName;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button addAttribute;
        private System.Windows.Forms.ListBox attrValueList;
        private System.Windows.Forms.ListBox attrNameList;
    }
}