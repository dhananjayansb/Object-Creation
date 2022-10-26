using System;
using System.Drawing;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;

namespace Object_Creation
{
    public partial class objCreation : Form
    {
        string objectName, objectPath, loginName, loginPassword, objectType, groupCategory, groupScope, serverName, domainName;
        int objectCount, excount = 0;
        bool grpcat;

        PrincipalContext pricipalContext = null;
        DirectoryEntry directoryEntry = null;

        public objCreation()
        {
            InitializeComponent();
        }
        public void userName_MouseClicked(object sender, EventArgs e)
        {
            int VisibleTime = 1000;  //in milliseconds
            ToolTip tt = new ToolTip();
            tt.Show("Enter Administrator name with serverName", userName, 0, 0, VisibleTime);
        }

        private void sample_Click(object sender, EventArgs e)
        {
            var sample = new sample();
            sample.Show();
        }

        public void serverIp_MouseClicked(object sender, EventArgs e)
        {
            int VisibleTime = 1000;  //in milliseconds
            ToolTip tt = new ToolTip();
            tt.Show("Enter serverName without .com", serverIp, 0, 0, VisibleTime);
        }

        public void ldapPrincipalContext()
        {
            try
            {
                pricipalContext = new PrincipalContext(ContextType.Domain, serverName, objectPath, loginName, loginPassword);
                //pricipalContext = new PrincipalContext(ContextType.Domain, "yourdomain.com", "OU=TestOU,DC=yourdomain,DC=com","YourAdminUser","YourAdminPassword");
            }
            catch (Exception ex)
            {
                MessageBox.Show("LDAP Connection Failed");
            }
        }

        public void createUser()
        {
            ldapPrincipalContext();

            try
            {
                for (int i = 1; i <= objectCount; i++)
                {
                    UserPrincipal up = new UserPrincipal(pricipalContext);
                    up.SamAccountName = objectName + i;
                    up.DisplayName = objectName + i;
                    up.UserPrincipalName = objectName + i + "@" + domainName;
                    up.Name = objectName + i;
                    up.Description = "User Created for testing";
                    up.Enabled = true;
                    up.SetPassword(objectName + i);
                    up.Save();
                }
            }
            catch (Exception ex)
            {
                excount++;
                MessageBox.Show("Users not Created");
            }
        }

        public void createGroup()
        {
            ///MessageBox.Show(groupCategory + groupScope);
            if (groupCategory == "Security")
            {
                grpcat = true;
            }
            else
            {
                grpcat = false;
            }

            ldapPrincipalContext();

            try
            {
                for (int i = 1; i <= objectCount; i++)
                {
                    GroupPrincipal gp = new GroupPrincipal(pricipalContext);
                    gp.SamAccountName = objectName + i;
                    gp.DisplayName = objectName + i;
                    gp.Name = objectName + i;
                    gp.Description = "Group Created for testing";
                    gp.GroupScope = (GroupScope)Enum.Parse(typeof(GroupScope), groupScope, true);
                    gp.IsSecurityGroup = grpcat;
                    gp.Save();
                }
            }
            catch (Exception ex)
            {
                excount++;
                MessageBox.Show("Groups not Created");
            }
            if (excount == 0)
            {
                MessageBox.Show("Success: " + objectCount + " Groups Created");
            }
        }

        public void createComputer()
        {
            ldapPrincipalContext();
            try
            {
                for (int i = 1; i <= objectCount; i++)
                {
                    ComputerPrincipal cp = new ComputerPrincipal(pricipalContext);
                    cp.SamAccountName = objectName + i;
                    cp.DisplayName = objectName + i;
                    cp.Name = objectName + i;
                    cp.Description = "Computer Created for testing";
                    cp.UserPrincipalName = objectName + i + "@" + domainName;
                    cp.Enabled = true;
                    cp.Save();
                }
            }
            catch (Exception ex)
            {
                excount++;
                MessageBox.Show("Computers not Created");
            }
            if (excount == 0)
            {
                MessageBox.Show("Success: " + objectCount + " Computers Created");
            }
        }

        public void createContact()
        {
            try
            {
                directoryEntry = new DirectoryEntry("LDAP://" + serverName + "/" + objectPath, loginName, loginPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:   Bind failed.");
                Console.WriteLine("         {0}", e.Message);
                return;
            }
            try
            {
                for (int i = 1; i <= objectCount; i++)
                {
                    DirectoryEntry contact;
                    contact = directoryEntry.Children.Add("CN=" + objectName + i, "Contact");
                    contact.Properties["name"].Add(objectName + i);
                    contact.Properties["displayName"].Add(objectName + i);
                    contact.Properties["description"].Add("Contact Created for testing");
                    contact.Properties["mail"].Add(objectName + i + "@" + domainName);
                    contact.CommitChanges();
                }
            }
            catch (Exception ex)
            {
                excount++;
                MessageBox.Show("Contacts not Created"+ ex.ToString());
            }
            if (excount == 0)
            {
                MessageBox.Show("Success: "+ objectCount + " Contacts Created");
            }
        }
        
        public void createOU()
        {
            try
            {
                directoryEntry = new DirectoryEntry("LDAP://" + serverName + "/" + objectPath, loginName, loginPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:   Bind failed.");
                Console.WriteLine("         {0}", e.Message);
                return;
            }
            try
            {
                for (int i = 1; i <= objectCount; i++)
                {
                    DirectoryEntry ou;
                    ou = directoryEntry.Children.Add("OU=" + objectName + i, "OrganizationalUnit");
                    ou.Properties["description"].Add("OU Created for testing");
                    ou.CommitChanges();
                }
            }
            catch (Exception ex)
            {
                excount++;
                MessageBox.Show("OU's not Created" + ex.ToString());
            }
            if (excount == 0)
            {
                MessageBox.Show("Success: " + objectCount + " OU's Created");
            }
        }

        public void Create_Click(object sender, EventArgs e)
        {
            loginName = userName.Text;
            loginPassword = password.Text;
            serverName = serverIp.Text;
            //loginName = "Automation\\Administrator";
            //loginPassword = "Auto@123";
            //serverName = "172.21.9.30";
            //objectPath = "OU=WPFAutomation,DC=AUTOMATION,DC=COM";
            objectType = objType.Items[objType.SelectedIndex].ToString();
            objectName = objName.Text;
            objectPath = ouPath.Text;
            decimal dec = objCount.Value;
            objectCount = Convert.ToInt32(dec);

            RunScript();
            ///MessageBox.Show(objectType);
        }
        
        public void RunScript()
        {
            if(loginName!=null && loginPassword!=null)
            {
                if (objectType == "User")
                {
                    try
                    {
                        //domainName = "Automation.com";
                        domainName = domName.Text;
                        createUser();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Params Missing Check out!"+ex.ToString());
                    }
                }
                else if (objectType == "Group")
                {
                    try
                    {
                        groupCategory = grpCategory.Items[grpCategory.SelectedIndex].ToString();
                        groupScope = grpScope.Items[grpScope.SelectedIndex].ToString();
                        createGroup();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Params Missing Check out!" + ex.ToString());
                    }
                }

                else if (objectType == "Computer")
                {
                    try
                    {
                        //domainName = "Automation.com";
                        domainName = domName.Text;
                        createContact();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Params Missing Check out!" + ex.ToString());
                    }
                    //domainName = "Automation.com";
                    domainName = domName.Text;
                    createComputer();
                }

                else if (objectType == "Contact")
                {
                    try
                    {
                        //domainName = "Automation.com";
                        domainName = domName.Text;
                        createContact();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Params Missing Check out!" + ex.ToString());
                    }
                }

                else if (objectType == "OU")
                {
                    try
                    {
                        //domainName = "Automation.com";
                        domainName = domName.Text;
                        createOU();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Params Missing Check out!" + ex.ToString());
                    }
                }

                else
                {
                    MessageBox.Show("Object Type missing!");
                }
            }
            else
            {
                MessageBox.Show("Credentials missing!");
            }
        }

        ///powershell-method
        /*public void RunScript()
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
        }*/
    }
}
