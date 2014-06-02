using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostDemo.Server.Models
{
    public class HelpTicket
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateOpened {get; set;}

    }
}
