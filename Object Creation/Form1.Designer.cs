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
            this.label1 = new System.Windows.Forms.Label();
            this.downProduct = new System.Windows.Forms.Button();
            this.killAll = new System.Windows.Forms.Button();
            this.startProduct = new System.Windows.Forms.Button();
            this.prodPath = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createUser
            // 
            this.createUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createUser.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(54, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(300, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ADManager Plus";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
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
            this.copyRights.AutoSize = true;
            this.copyRights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRights.Location = new System.Drawing.Point(287, 530);
            this.copyRights.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.copyRights.Name = "copyRights";
            this.copyRights.Size = new System.Drawing.Size(106, 16);
            this.copyRights.TabIndex = 4;
            this.copyRights.TabStop = true;
            this.copyRights.Text = "DhananjayanSB";
            this.copyRights.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.copyRights_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 526);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "©";
            // 
            // downProduct
            // 
            this.downProduct.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.downProduct.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downProduct.ForeColor = System.Drawing.Color.Black;
            this.downProduct.Location = new System.Drawing.Point(270, 94);
            this.downProduct.Name = "downProduct";
            this.downProduct.Size = new System.Drawing.Size(107, 31);
            this.downProduct.TabIndex = 6;
            this.downProduct.Text = "Shutdown";
            this.downProduct.UseVisualStyleBackColor = true;
            this.downProduct.Click += new System.EventHandler(this.downProduct_Click);
            // 
            // killAll
            // 
            this.killAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.killAll.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killAll.ForeColor = System.Drawing.Color.Black;
            this.killAll.Location = new System.Drawing.Point(270, 141);
            this.killAll.Name = "killAll";
            this.killAll.Size = new System.Drawing.Size(107, 31);
            this.killAll.TabIndex = 10;
            this.killAll.Text = "Kill All";
            this.killAll.UseVisualStyleBackColor = true;
            this.killAll.Click += new System.EventHandler(this.killAll_Click);
            // 
            // startProduct
            // 
            this.startProduct.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.startProduct.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startProduct.ForeColor = System.Drawing.Color.Black;
            this.startProduct.Location = new System.Drawing.Point(139, 94);
            this.startProduct.Name = "startProduct";
            this.startProduct.Size = new System.Drawing.Size(107, 31);
            this.startProduct.TabIndex = 11;
            this.startProduct.Text = "Start ";
            this.startProduct.UseVisualStyleBackColor = true;
            this.startProduct.Click += new System.EventHandler(this.startProduct_Click);
            // 
            // prodPath
            // 
            this.prodPath.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodPath.Location = new System.Drawing.Point(12, 482);
            this.prodPath.Name = "prodPath";
            this.prodPath.Size = new System.Drawing.Size(372, 21);
            this.prodPath.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.Location = new System.Drawing.Point(12, 462);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 14);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Product Path";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 551);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.prodPath);
            this.Controls.Add(this.startProduct);
            this.Controls.Add(this.killAll);
            this.Controls.Add(this.downProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyRights);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.createUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainPage";
            this.Text = "ManageEngine QA Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel copyRights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button downProduct;
        private System.Windows.Forms.Button killAll;
        private System.Windows.Forms.Button startProduct;
        private System.Windows.Forms.TextBox prodPath;
        private System.Windows.Forms.TextBox textBox3;
    }
}

