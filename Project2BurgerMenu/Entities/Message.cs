using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2BurgerMenu.Entities
{
    public class Message
    {
        public int MessageID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverEmail { get; set; }

        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}