using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BMSChina.EmailNotification
{
  public  class SMPTUtil
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public SMPTUtil(string host, int port)
        {
            Host = host;
            Port = port;
        }
        public void SendMessage(string from,string to,string subject,string body)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient(Host,Port);
            message.From = new MailAddress(from);
            message.To.Add(new MailAddress(to));
            message.Subject = subject;
            message.Body = body;
            smtp.Send(message);
        }
    }
}
