using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Object_Creation
{
    public partial class objCreation : Form
    {
        string objectName, objectCount, objectPath, loginName, loginPassword, logindcName, objectType, groupCategory, groupScope;
        
        public objCreation()
        {
            InitializeComponent();
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            loginName = userName.Text;
        }
        
        private void ouPath_TextChanged_1(object sender, EventArgs e)
        {
            objectPath = ouPath.Text;
        }

        private void objName_TextChanged(object sender, EventArgs e)
        {
            objectName = objName.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void objType_SelectedIndexChanged(object sender, EventArgs e)
        {
            objectType = objType.Items[objType.SelectedIndex].ToString();
        }

        private void objCount_ValueChanged_1(object sender, EventArgs e)
        {
            decimal dec = objCount.Value;
            objectCount = Convert.ToString(dec);
        }
        
        private void password_TextChanged(object sender, EventArgs e)
        {
            loginPassword = password.Text;
        }

        private void dcName_TextChanged(object sender, EventArgs e)
        {
            logindcName = dcName.Text;
        }

        private void grpScope_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupScope = grpScope.Items[grpScope.SelectedIndex].ToString();
        }

        private void grpCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupCategory = grpCategory.Items[grpCategory.SelectedIndex].ToString();
        }

        public void Create_Click(object sender, EventArgs e)
        {
           RunScript();
           ///MessageBox.Show(objectType + groupCategory + groupScope);
        }

        public void RunScript()
        {
            var ps1File = @"D:\Scripts\Login.ps1";
            var filePath = @"D:\Scripts\"+objectType+".ps1";
            var startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoExit -NoProfile -ExecutionPolicy unrestricted -file \"{ps1File}\" -loginName \"{loginName}\" -loginPassword \"{loginPassword}\"  -logindcName \"{logindcName}\"  -objectName \"{objectName}\"  -objectCount \"{objectCount}\"  -objectPath \"{objectPath}\" -groupScope \"{groupScope}\" -groupCategory \"{groupCategory}\" -Filepath \"{filePath}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }
    }
}
