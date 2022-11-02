using System;
using System.Windows.Forms;
using System.IO;
using System.Management.Automation.Runspaces;
using System.Management.Automation;
using System.Security;
using System.Text;
using System.Net;

namespace Object_Creation
{
    public partial class customAttribute : Form
    {
        public string mSyntax, attrName, attrType, syntax, userName, password, serverIp;

        private void sample_Click(object sender, EventArgs e)
        {
            var cusSample = new customSample();
            cusSample.Show();
        }

        bool downStatus;

        private void downloadScript_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\New-ADUserAttribute.ps1";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://drive.google.com/uc?export=download&id=1fu8QX7wZPwXOrqfRMeTumLF4jEyg94e-", @"D:\New-ADUserAttribute.ps1");
            
            if (File.Exists(fileName))
            { 
                downStatus = true;
                MessageBox.Show("Downloaded Script");
            }
            else
                MessageBox.Show("Please download script");
        }

        public customAttribute()
        {
            InitializeComponent();
        }

        private void createAttribute_Click(object sender, EventArgs e)
        {
            if (downStatus == true)
            {
                try
                {
                    attrName = nameText.Text;
                    attrType = dataType.Items[dataType.SelectedIndex].ToString(); ;

                    userName = domUserName.Text;
                    password = domPassword.Text;
                    serverIp = domServerIp.Text;

                    if(attrName != "" && attrType != "" && userName != "" && password != "" && serverIp != "")
                    {
                        var securestring = new SecureString();
                        foreach (Char c in password)
                        {
                            securestring.AppendChar(c);
                        }

                        if (attrType == "String")
                        {
                            syntax = "2.5.5.12";
                            mSyntax = "64";
                        }
                        else if (attrType == "Int")
                        {
                            syntax = "2.5.5.9";
                            mSyntax = "2";
                        }
                        else if (attrType == "Boolean")
                        {
                            syntax = "2.5.5.8";
                            mSyntax = "1";
                        }

                        ///MessageBox.Show(syntax + mSyntax);
                        PSCredential creds = new PSCredential(userName, securestring);
                        WSManConnectionInfo connectionInfo = new WSManConnectionInfo();

                        connectionInfo.ComputerName = serverIp;
                        connectionInfo.Credential = creds;
                        String psProg = File.ReadAllText(@"D:\New-ADUserAttribute.ps1");
                        Runspace runspace = RunspaceFactory.CreateRunspace(connectionInfo);
                        runspace.Open();
                        using (PowerShell ps = PowerShell.Create())
                        {
                            ps.Runspace = runspace;
                            ps.AddScript(psProg);
                            ps.AddParameter("attrName", attrName);
                            ps.AddParameter("mSyntax", mSyntax);
                            ps.AddParameter("syntax", syntax);

                            StringBuilder sb = new StringBuilder();
                            try
                            {
                                var results = ps.Invoke();
                                foreach (var x in results)
                                {
                                    sb.AppendLine(x.ToString());
                                }
                                MessageBox.Show("Completed creation");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Exception" + ex.ToString());
                            }
                        }
                        runspace.Close();
                        Console.ReadLine();
                    }
                    else
                    {
                        MessageBox.Show("Respective fields not filled.");
                    }
                }
                
                catch(Exception ex)
                {
                    MessageBox.Show("Cannot create custom attribute" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Script not downloaded, Please download.");
            }
        }
    }
}
