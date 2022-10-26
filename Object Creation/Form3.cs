using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Compression;
using System.Windows.Forms;

namespace Object_Creation
{
    public partial class productActions : Form
    {
        public string actionID;

        BackgroundWorker worker = new BackgroundWorker();
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
        }
        private void execute_Click(object sender, EventArgs e)
        {
            ///MessageBox.Show(actionID);
            if (actionID == "start")
            {
                try
                {
                    var path = @prodPath.Text;
                    var processStartInfo = new ProcessStartInfo();
                    processStartInfo.WorkingDirectory = path;
                    processStartInfo.FileName = "cmd.exe";
                    processStartInfo.Arguments = "/C runAsAdmin.bat";
                    Process proc = Process.Start(processStartInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter Required Fields");
                }
            }

            else if (actionID == "stop")
            {
                try
                { 
                    var path = @prodPath.Text;
                    var processStartInfo = new ProcessStartInfo();
                    processStartInfo.WorkingDirectory = path;
                    processStartInfo.FileName = "cmd.exe";
                    processStartInfo.Arguments = "/C shutdown.bat";
                    Process proc = Process.Start(processStartInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter Required Fields");
                }
            }

            else if (actionID == "kill")
            {
                try
                {
                    var path = @prodPath.Text;
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
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter Required Fields");
                }
            }

            else if (actionID == "zip")
            {
                var productPath = prodPath.Text;
                var prodzipPath = zipPath.Text;
                CopyWithProgress(productPath,prodzipPath);

                if (progressBar.Value == 100)
                {
                    progressBar.Value = 1;
                    MessageBox.Show("Operation Complete!!");
                }
            }
        }
    }
}
