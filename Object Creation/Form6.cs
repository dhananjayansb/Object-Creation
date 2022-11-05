using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Creation
{
    public partial class modifyObject : Form
    {
        string attribName, attribValue;

        public modifyObject()
        {
            InitializeComponent();
        }

        private void addAttribute_Click(object sender, EventArgs e)
        {
            attribName = attributeName.Items[attributeName.SelectedIndex].ToString();
            attribValue = attributeValue.Text;
        }
    }
        
}
