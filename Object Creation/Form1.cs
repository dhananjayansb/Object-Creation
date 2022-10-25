using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Object_Creation
{
    public partial class mainPage : Form
    {
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
            ///MessageBox.Show(productPath);
            var path = @prodPath.Text;
            var processStartInfo = new ProcessStartInfo();
            processStartInfo.WorkingDirectory = path;
            processStartInfo.FileName = "cmd.exe";
            processStartInfo.Arguments = "/C runAsAdmin.bat";
            Process proc = Process.Start(processStartInfo);
        }


        public void downProduct_Click(object sender, EventArgs e)
        {
            var path = @prodPath.Text;
            var processStartInfo = new ProcessStartInfo();
            processStartInfo.WorkingDirectory = path;
            processStartInfo.FileName = "cmd.exe";
            processStartInfo.Arguments = "/C shutdown.bat";
            Process proc = Process.Start(processStartInfo);
        }

        private void killAll_Click(object sender, EventArgs e)
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
    }
}
