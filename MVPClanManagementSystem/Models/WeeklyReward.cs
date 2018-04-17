using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPClanManagementSystem.Models
{
    public class WeeklyReward
    {
        public Guid Guid { get; set; }
        public int WeekNo { get; set; }
        public string PlayerName { get; set; }
        public int Contribution { get; set; }
        public List<RedeemItem> RequestedItems { get; set; }
        public int Remaining { get; set; }
        public bool RewardGiven { get; set; }
    }
}
