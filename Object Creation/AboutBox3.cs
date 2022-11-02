using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Object_Creation
{
    partial class regEditor : Form
    {
        string regPath, prodName;

        public regEditor()
        {
            InitializeComponent();
        }

        public void DeleteRegistry(string path, string prod)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true);
                Registry.LocalMachine.DeleteSubKeyTree(path);
                MessageBox.Show(prod + "         Deleted Successfully");
            }
            catch (Exception ex)
            {
                // an error!  
                MessageBox.Show(ex.ToString(), "Deleting SubKey " + path);
            }
        }

        private void deleteReg_Click(object sender, EventArgs e)
        {
            if(admpProduct.Checked == true)
            {
                prodName = "ADMP";
                regPath = "SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\{CC00BC3F-40AE-49A7-BA63-FE2F93D20585}";
                DeleteRegistry(regPath,prodName);
            }

            if (rmpProduct.Checked == true)
            {
                prodName = "RMP";
                regPath = "SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\{B9409617-CC54-4EC6-AE32-42C48443C4C5}";
                DeleteRegistry(regPath, prodName);
            }

            if (erpProduct.Checked == true)
            {
                prodName = "ERP";
                regPath = "SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\{CCB34152-8A6B-4442-8713-48E2F437E548}";
                DeleteRegistry(regPath, prodName);
            }

            if(admpProduct.Checked == false && rmpProduct.Checked == false && erpProduct.Checked == false)
            {
                MessageBox.Show("Select atleast one product!!");
            }
        }
    }
}
