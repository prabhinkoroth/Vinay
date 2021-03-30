using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSChina.EmailNotification
{
   public class Process
    {
        public void SendNotificaitonToAll()
        {
            SharePointUtil util = new SharePointUtil(AppConfiguration.SPSite, AppConfiguration.SPUserName, AppConfiguration.SPPassword, AppConfiguration.SPDomain);
            util.GetAllItems(AppConfiguration.SPList,new string[] { "Title", "Id" });
            SMPTUtil smtpUtil = new SMPTUtil(AppConfiguration.SMTPHost,int.Parse( AppConfiguration.SMTPPort));
            foreach (ListItem    item in util.allListItems)
            {
                
                string toEmail = "";
                string subject = "";
                string body = "";
                smtpUtil.SendMessage(AppConfiguration.FromEmail, toEmail, subject, body);
            }
        }
    }
}
