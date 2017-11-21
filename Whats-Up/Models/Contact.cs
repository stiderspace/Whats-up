using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatsDown.Models
{
    public class Contact
    {
        public virtual int contactId { get; set; }
        public virtual int ownerAccountId { get; set; }
        public virtual int contactAccountId { get; set; }
        public virtual string nickname { get; set; }
    }
}