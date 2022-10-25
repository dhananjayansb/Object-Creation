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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.serverIp = new System.Windows.Forms.TextBox();
            this.objType = new System.Windows.Forms.ComboBox();
            this.textbox14 = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.domName = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.sample = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objCount)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.userName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.serverIp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.objType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textbox14, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.31507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.68493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 148);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox3.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(4, 117);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(132, 24);
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
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(132, 24);
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
            this.userName.Click += new System.EventHandler(this.userName_MouseClicked);
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
            this.serverIp.Click += new System.EventHandler(this.serverIp_MouseClicked);
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
            this.objType.Size = new System.Drawing.Size(155, 21);
            this.objType.TabIndex = 9;
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
            this.textbox14.Size = new System.Drawing.Size(132, 24);
            this.textbox14.TabIndex = 9;
            this.textbox14.Text = "LDAP Server IP";
            this.textbox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox6.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(89, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(240, 17);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "Server Details";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(240, 17);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 239);
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
            // 
            // textBox10
            // 
            this.textBox10.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox10.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox10.Location = new System.Drawing.Point(3, 75);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
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
            this.textBox11.ReadOnly = true;
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
            this.textBox12.ReadOnly = true;
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
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.33333F));
            this.tableLayoutPanel3.Controls.Add(this.textBox7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.grpCategory, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.grpScope, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(37, 460);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(300, 68);
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
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(128, 24);
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
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(128, 24);
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
            this.grpCategory.Location = new System.Drawing.Point(137, 42);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(155, 21);
            this.grpCategory.TabIndex = 11;
            // 
            // grpScope
            // 
            this.grpScope.FormattingEnabled = true;
            this.grpScope.Items.AddRange(new object[] {
            "Local",
            "Global",
            "Universal"});
            this.grpScope.Location = new System.Drawing.Point(137, 8);
            this.grpScope.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.grpScope.Name = "grpScope";
            this.grpScope.Size = new System.Drawing.Size(155, 21);
            this.grpScope.TabIndex = 10;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox9.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(89, 430);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(240, 17);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Group Attribute";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.79319F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.20681F));
            this.tableLayoutPanel4.Controls.Add(this.domName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox13, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 344);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(411, 68);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // domName
            // 
            this.domName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.domName.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domName.Location = new System.Drawing.Point(146, 6);
            this.domName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.domName.Name = "domName";
            this.domName.Size = new System.Drawing.Size(262, 24);
            this.domName.TabIndex = 11;
            // 
            // textBox13
            // 
            this.textBox13.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox13.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox13.Location = new System.Drawing.Point(3, 6);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(132, 24);
            this.textBox13.TabIndex = 8;
            this.textBox13.Text = "Domain Name";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sample
            // 
            this.sample.Location = new System.Drawing.Point(342, 13);
            this.sample.Name = "sample";
            this.sample.Size = new System.Drawing.Size(75, 23);
            this.sample.TabIndex = 10;
            this.sample.Text = "sample";
            this.sample.UseVisualStyleBackColor = true;
            this.sample.Click += new System.EventHandler(this.sample_Click);
            // 
            // objCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 624);
            this.Controls.Add(this.sample);
            this.Controls.Add(this.tableLayoutPanel4);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objCount)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox textBox3;
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
        private System.Windows.Forms.TextBox textbox14;
        private System.Windows.Forms.TextBox serverIp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox domName;
        private System.Windows.Forms.Button sample;
    }
}