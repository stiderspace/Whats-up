using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatsDown.Models
{
    public class Account
    {
        public virtual int accountId { get; set; }
        public virtual string name { get; set; }
        public virtual string username { get; set; }
        public virtual string password { get; set; }
        public virtual string telNr { get; set; }
    }
}