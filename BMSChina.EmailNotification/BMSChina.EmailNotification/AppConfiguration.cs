using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace BMSChina.EmailNotification
{
  public  class AppConfiguration
    {
        public static readonly string SMTPHost = ConfigurationManager.AppSettings["SMTPHost"];
        public static readonly string SMTPPort = ConfigurationManager.AppSettings["SMTPPort"];
        public static readonly string SPSite = ConfigurationManager.AppSettings["SPSite"];
        public static readonly string SPList = ConfigurationManager.AppSettings["SPList"];
        public static readonly string SPUserName = ConfigurationManager.AppSettings["SPUserName"];
        public static readonly string SPPassword = ConfigurationManager.AppSettings["SPPassword"];
        public static readonly string SPDomain = ConfigurationManager.AppSettings["SPDomain"];
        public static readonly string FromEmail = ConfigurationManager.AppSettings["FromEmail"];
    }
}
