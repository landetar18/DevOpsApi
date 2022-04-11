using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOps_ServiceAPI.Models
{
    public class MessageRequest
    {
        public string MessageText { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public int TimeToLifeSec { get; set; }
    }
}