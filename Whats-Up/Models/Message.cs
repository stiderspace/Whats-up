using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatsDown.Models
{
    public class Message
    {
        public virtual int messageId { get; set; }
        public virtual Account sender { get; set; }
        public virtual Account receiver { get; set; }
        public virtual string message { get; set; }
        public virtual DateTime dateTime { get; set; }
    }
}