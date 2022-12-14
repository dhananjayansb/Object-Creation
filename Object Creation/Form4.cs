using System;
using System.Windows.Forms;

namespace Object_Creation
{
    public partial class createFolder : Form
    {
        int PathCount, FolderCount;
        public createFolder()
        {
            InitializeComponent();
        }

        private void folderSample_Click(object sender, EventArgs e)
        {
            var sample = new folderSample();
            sample.Show();
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            try
            {
                FolderCount = Convert.ToInt32(folderCount.Text);
                PathCount = Convert.ToInt32(pathCount.Text);

                if (!System.IO.Directory.Exists(folderPath.Text))
                {
                    for (int i = 1; i <= PathCount; i++)
                    {
                        for (int j = 1; j <= FolderCount; j++)
                        {
                            System.IO.Directory.CreateDirectory(folderPath.Text + i + "\\" + folderName.Text + j);
                        }
                    }
                    folderPath.Text = "";
                    folderName.Text = "";
                    MessageBox.Show("Directory Created Successfully!");
                }
                else
                {
                    MessageBox.Show("Directory Already Exist!..");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter required fields");
            }
        }
    }
}
