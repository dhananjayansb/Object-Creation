using System;
using System.Diagnostics;
using System.IO.Compression;
using System.Windows.Forms;

namespace Object_Creation
{
    public partial class productActions : Form
    {
        public string actionID, productPath, prodzipPath;
       
        ProgressBar pBar = new ProgressBar();

        public void CopyWithProgress(string path, string zipPath)
        {
            try
            {
                ZipFile.CreateFromDirectory(path, zipPath);

                progressBar.Visible = true;
                progressBar.Minimum = 1;
                progressBar.Maximum = zipPath.Length;
                progressBar.Value = 1;
                progressBar.Step = 1;

                for (int x = 1; x <= zipPath.Length; x++)
                {
                    progressBar.PerformStep();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter Required Fields");
            }
        }

        public productActions(string action)
        {
            InitializeComponent();
            actionID = action;
            productPath = prodPath.Text;
            prodzipPath = zipPath.Text;
        }
        private void execute_Click(object sender, EventArgs e)
        {
            ///MessageBox.Show(actionID);
            if (actionID == "start")
            {
                var path = @prodPath.Text;
                if (productPath != "")
                {
                    var processStartInfo = new ProcessStartInfo();
                    processStartInfo.WorkingDirectory = path;
                    processStartInfo.FileName = "cmd.exe";
                    processStartInfo.Arguments = "/C runAsAdmin.bat";
                    Process proc = Process.Start(processStartInfo);
                }
                else
                {
                    MessageBox.Show("Please Enter Product Path");
                }
            }

            else if (actionID == "stop")
            {
                var path = @prodPath.Text;
                if (productPath != "")
                {
                    var processStartInfo = new ProcessStartInfo();
                    processStartInfo.WorkingDirectory = path;
                    processStartInfo.FileName = "cmd.exe";
                    processStartInfo.Arguments = "/C shutdown.bat";
                    Process proc = Process.Start(processStartInfo);
                }
                else
                {
                    MessageBox.Show("Please Enter Product Path");
                }
            }

            else if (actionID == "kill")
            {
                var path = @prodPath.Text;
                if (productPath != "")
                {
                    Process proc = new Process();
                    var processStartInfo = new ProcessStartInfo();
                    processStartInfo.WorkingDirectory = path;
                    processStartInfo.FileName = "cmd.exe";
                    processStartInfo.Arguments = "/C taskkill /f /im java.exe";
                    proc = Process.Start(processStartInfo);
                    processStartInfo.FileName = "cmd.exe";
                    processStartInfo.Arguments = "/C taskkill /f /im postgres.exe";
                    proc = Process.Start(processStartInfo);
                }
                else
                {
                    MessageBox.Show("Please Enter Product Path");
                }
            }

            else if (actionID == "zip")
            {
                var productPath = prodPath.Text;
                var prodzipPath = zipPath.Text;
                if ((productPath != "") && (prodzipPath != ""))
                { 
                    CopyWithProgress(productPath, prodzipPath);

                    if (progressBar.Value == 1)
                    {
                        progressBar.Value = 0;
                        MessageBox.Show("Operation Complete!!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Product Path & Zip Path");
                }
            }
        }
    }
}
