using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSChina.EmailNotification
{
    public class SharePointUtil
    {
        ClientContext context;
       public List<ListItem> allListItems = new List<ListItem>();
        public SharePointUtil(string siteUrl, string userName, string password, string domain)
        {
            context = new ClientContext(siteUrl);
            context.Credentials = new System.Net.NetworkCredential(userName, password, domain);
          

        }
        public void GetAllItems(string listName, string[] columns)
        {
            allListItems = new List<ListItem>();
            var camlQuery = CamlQuery.CreateAllItemsQuery(5000, columns);
           
            do
            {
                var listItems = context.Web.Lists.GetByTitle(listName).GetItems(camlQuery);
                context.Load(listItems);
                context.ExecuteQuery();
                allListItems.AddRange(listItems.ToList());
                if (listItems.ListItemCollectionPosition != null)
                {
                    camlQuery.ListItemCollectionPosition = listItems.ListItemCollectionPosition;
                }
            } while (camlQuery.ListItemCollectionPosition!=null);

        }
    }
}
