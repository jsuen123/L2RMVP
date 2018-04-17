using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVPClanManagementSystem.Models
{
    public class Member
    {        
        public Guid Guid { get; set; }
        public string PlayerName { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public string Team { get; set; }
        public int CombatPower { get; set; }
        public int Contribution { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool Active { get; set; }
        public int Rank { get; set; }
        public string Email { get; set; }
        public string DiscordId { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}