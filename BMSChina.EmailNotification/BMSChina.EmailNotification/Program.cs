using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSChina.EmailNotification
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.SendNotificaitonToAll();
        }
    }
}
