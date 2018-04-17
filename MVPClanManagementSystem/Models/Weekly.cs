using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVPClanManagementSystem.Models
{
    public class Weekly
    {
        public int WeekNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}