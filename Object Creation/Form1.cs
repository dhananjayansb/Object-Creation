﻿using System;
using System.Windows.Forms;

namespace Object_Creation
{
    public partial class mainPage : Form
    {

        public static string action, regPath;

        public mainPage()
        {
            InitializeComponent();
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            var createUser = new objCreation();
            createUser.Show();
        }

        private void copyRights_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:dhananjayan.sb@zohocorp.com");
        }

        public void startProduct_Click(object sender, EventArgs e)
        {
            action = "start";
            var startProduct = new productActions(action);
            startProduct.Show();
        }
        
        public void downProduct_Click(object sender, EventArgs e)
        {
            action = "stop";
            var stopProduct = new productActions(action);
            stopProduct.Show();
        }

        private void killAll_Click(object sender, EventArgs e)
        {
            action = "kill";
            var killProduct = new productActions(action);
            killProduct.Show();
        }

        private void zipProduct_Click(object sender, EventArgs e)
        {
            action = "zip";
            var zipProduct = new productActions(action);
            zipProduct.Show();
        }

        private void createFolder_Click(object sender, EventArgs e)
        {
            var createFolder = new createFolder();
            createFolder.Show();
        }

        private void customAttribute_Click(object sender, EventArgs e)
        {
            var createAttribute = new customAttribute();
            createAttribute.Show();
        }

        private void removeReg_Click(object sender, EventArgs e)
        {
            var regEdit = new regEditor();
            regEdit.Show();
        }
    }
}
