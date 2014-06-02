using Microsoft.AspNet.SignalR;
using SelfHostDemo.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostDemo.Server.Hubs
{
    public class HelpTicketHub : Hub
    {
        public void AddHelpTicket(HelpTicket ticket)
        {
            Console.WriteLine("Incoming request for AddHelpTicket");
            Clients.Others.IssueNewTicket(ticket);
        }
    }
}
