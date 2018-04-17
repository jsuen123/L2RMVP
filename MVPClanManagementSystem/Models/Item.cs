using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVPClanManagementSystem.Models
{
    public class Item
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public int AvailableQty { get; set; }
        public double Cost { get; set; }
        public string Note { get; set; }
        public int MaxClaimPerMonth { get; set; }
        public string Grade { get; set; }
    }
}