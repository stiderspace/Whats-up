using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatsDown.Models
{
    public class Chat
    {
        public virtual int chatId { get; set; }
        public virtual List<Account> partisipants {get; set;}
        public virtual string message { get; set; }
    }
}