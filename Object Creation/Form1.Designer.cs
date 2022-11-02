namespace Object_Creation
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.createUser = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyRights = new System.Windows.Forms.LinkLabel();
            this.downProduct = new System.Windows.Forms.Button();
            this.killAll = new System.Windows.Forms.Button();
            this.startProduct = new System.Windows.Forms.Button();
            this.zipProduct = new System.Windows.Forms.Button();
            this.createFolder = new System.Windows.Forms.Button();
            this.removeReg = new System.Windows.Forms.Button();
            this.customAttribute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createUser
            // 
            this.createUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createUser.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUser.ForeColor = System.Drawing.Color.Black;
            this.createUser.Location = new System.Drawing.Point(12, 94);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(107, 31);
            this.createUser.TabIndex = 0;
            this.createUser.Text = "Create Object";
            this.createUser.UseVisualStyleBackColor = true;
            this.createUser.Click += new System.EventHandler(this.createUser_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(68, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(300, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Performance Tool";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // copyRights
            // 
            this.copyRights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyRights.AutoSize = true;
            this.copyRights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRights.Location = new System.Drawing.Point(303, 530);
            this.copyRights.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.copyRights.Name = "copyRights";
            this.copyRights.Size = new System.Drawing.Size(106, 16);
            this.copyRights.TabIndex = 4;
            this.copyRights.TabStop = true;
            this.copyRights.Text = "DhananjayanSB";
            this.copyRights.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.copyRights_LinkClicked);
            // 
            // downProduct
            // 
            this.downProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downProduct.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.downProduct.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downProduct.ForeColor = System.Drawing.Color.Black;
            this.downProduct.Location = new System.Drawing.Point(270, 94);
            this.downProduct.Name = "downProduct";
            this.downProduct.Size = new System.Drawing.Size(123, 31);
            this.downProduct.TabIndex = 6;
            this.downProduct.Text = "Shutdown Product";
            this.downProduct.UseVisualStyleBackColor = true;
            this.downProduct.Click += new System.EventHandler(this.downProduct_Click);
            // 
            // killAll
            // 
            this.killAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.killAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.killAll.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killAll.ForeColor = System.Drawing.Color.Black;
            this.killAll.Location = new System.Drawing.Point(270, 141);
            this.killAll.Name = "killAll";
            this.killAll.Size = new System.Drawing.Size(123, 31);
            this.killAll.TabIndex = 10;
            this.killAll.Text = "Kill All";
            this.killAll.UseVisualStyleBackColor = true;
            this.killAll.Click += new System.EventHandler(this.killAll_Click);
            // 
            // startProduct
            // 
            this.startProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startProduct.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.startProduct.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startProduct.ForeColor = System.Drawing.Color.Black;
            this.startProduct.Location = new System.Drawing.Point(139, 94);
            this.startProduct.Name = "startProduct";
            this.startProduct.Size = new System.Drawing.Size(107, 31);
            this.startProduct.TabIndex = 11;
            this.startProduct.Text = "Start Product";
            this.startProduct.UseVisualStyleBackColor = true;
            this.startProduct.Click += new System.EventHandler(this.startProduct_Click);
            // 
            // zipProduct
            // 
            this.zipProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zipProduct.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.zipProduct.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipProduct.ForeColor = System.Drawing.Color.Black;
            this.zipProduct.Location = new System.Drawing.Point(139, 141);
            this.zipProduct.Name = "zipProduct";
            this.zipProduct.Size = new System.Drawing.Size(107, 31);
            this.zipProduct.TabIndex = 12;
            this.zipProduct.Text = "Zip Product";
            this.zipProduct.UseVisualStyleBackColor = true;
            this.zipProduct.Click += new System.EventHandler(this.zipProduct_Click);
            // 
            // createFolder
            // 
            this.createFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createFolder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createFolder.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFolder.ForeColor = System.Drawing.Color.Black;
            this.createFolder.Location = new System.Drawing.Point(12, 141);
            this.createFolder.Name = "createFolder";
            this.createFolder.Size = new System.Drawing.Size(107, 31);
            this.createFolder.TabIndex = 13;
            this.createFolder.Text = "Create Folder";
            this.createFolder.UseVisualStyleBackColor = true;
            this.createFolder.Click += new System.EventHandler(this.createFolder_Click);
            // 
            // removeReg
            // 
            this.removeReg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeReg.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.removeReg.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeReg.ForeColor = System.Drawing.Color.Black;
            this.removeReg.Location = new System.Drawing.Point(139, 195);
            this.removeReg.Name = "removeReg";
            this.removeReg.Size = new System.Drawing.Size(107, 31);
            this.removeReg.TabIndex = 14;
            this.removeReg.Text = "Remove Reg";
            this.removeReg.UseVisualStyleBackColor = true;
            this.removeReg.Click += new System.EventHandler(this.removeReg_Click);
            // 
            // customAttribute
            // 
            this.customAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customAttribute.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.customAttribute.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customAttribute.ForeColor = System.Drawing.Color.Black;
            this.customAttribute.Location = new System.Drawing.Point(12, 195);
            this.customAttribute.Name = "customAttribute";
            this.customAttribute.Size = new System.Drawing.Size(107, 31);
            this.customAttribute.TabIndex = 15;
            this.customAttribute.Text = "Custom Attribute";
            this.customAttribute.UseVisualStyleBackColor = true;
            this.customAttribute.Click += new System.EventHandler(this.customAttribute_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 551);
            this.Controls.Add(this.customAttribute);
            this.Controls.Add(this.removeReg);
            this.Controls.Add(this.createFolder);
            this.Controls.Add(this.zipProduct);
            this.Controls.Add(this.startProduct);
            this.Controls.Add(this.killAll);
            this.Controls.Add(this.downProduct);
            this.Controls.Add(this.copyRights);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.createUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainPage";
            this.Text = "Manage Engine QA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel copyRights;
        private System.Windows.Forms.Button downProduct;
        private System.Windows.Forms.Button killAll;
        private System.Windows.Forms.Button startProduct;
        private System.Windows.Forms.Button zipProduct;
        private System.Windows.Forms.Button createFolder;
        private System.Windows.Forms.Button removeReg;
        private System.Windows.Forms.Button customAttribute;
    }
}

