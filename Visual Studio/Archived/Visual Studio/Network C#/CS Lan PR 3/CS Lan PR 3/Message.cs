using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lan_PR_3
{
    class Message
    {
        public bool Discounts { get; set; }
        public bool Events { get; set; }
        public bool News { get; set; }

        public bool Emergency { get; }
        public Message(bool disc, bool ev, bool n)
        {
            Discounts = disc;
            Events = ev;
            News = n;
            Emergency = true;
        }
    }
}
