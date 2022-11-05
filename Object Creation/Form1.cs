using System;
using System.Windows.Forms;
using System.Net;
using Independentsoft.Exchange;
using Message = Independentsoft.Exchange.Message;
using System.IO;

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

        private void modifyObject_Click(object sender, EventArgs e)
        {
            var modObject = new modifyObject();
            modObject.Show();
        }

        private void sendMail_Click(object sender, EventArgs e)
        {
            SendMail();
        }

        private void removeReg_Click(object sender, EventArgs e)
        {
            var regEdit = new regEditor();
            regEdit.Show();
        }

        public void SendMail()
        {
            string body = File.ReadAllText("E:\\API\\testdemo.txt");

            /*var smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("admptester@gmail.com", "hvyhiouqmezducvz"),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true,
                Timeout = 50000
            };

            smtpClient.Send("admptester@gmail.com", "admptestware@zohomail.in", "subject", body);*/

            //Basic authentication
            NetworkCredential credential = new NetworkCredential("autoqa\\Administrator", "Vembu@123new");

            //Windows Integrated Authentication
            //ICredentials credential = CredentialCache.DefaultCredentials;

            Service service = new Service("https://autoqa-ex13/ews/Exchange.asmx", credential);
           try
            {
                Message message = new Message();
                message.Subject = "WPFTest1";
                message.Body = new Body(body);
                message.ToRecipients.Add(new Mailbox("Administrator@autoqa.com"));

                ItemInfoResponse response = service.Send(message);
                MessageBox.Show("Done");
            }
            catch (ServiceRequestException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.XmlMessage);
                Console.Read();
            }
            catch (WebException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.Read();
            }
        }
    }
}
