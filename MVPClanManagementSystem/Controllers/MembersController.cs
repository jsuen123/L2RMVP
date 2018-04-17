using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVPClanManagementSystem.Models;

namespace MVPClanManagementSystem.Controllers
{    
    public class MembersController : Controller
    {
        private List<Member> _members;

        public MembersController()
        {
            _members= new List<Member>()
            {
                new Member()
                {
                    Guid = Guid.NewGuid(),
                    PlayerName = "donthaveone",
                    Class = "Silver Ranger",
                    Level = 180,
                    Team = "",
                    CombatPower = 700000,
                    Contribution = 20000,
                    JoiningDate = new DateTime(2018, 02, 01),
                    Active = true,
                    Rank = 1024,
                    Email = "",
                    DiscordId = "donehaveone",
                    LastUpdate = new DateTime(2018, 04, 14)
                },
                new Member()
                {
                    Guid = Guid.NewGuid(),
                    PlayerName = "LunaIsabella",
                    Class = "Spellsinger",
                    Level = 180,
                    Team = "",
                    CombatPower = 815000,
                    Contribution = 20000,
                    JoiningDate = new DateTime(2017, 01, 01),
                    Active = true,
                    Rank = 1,
                    Email = "",
                    DiscordId = "LunaIsabella",
                    LastUpdate = new DateTime(2018, 04, 14)
                },
                new Member()
                {
                    Guid = Guid.NewGuid(),
                    PlayerName = "Weapons",
                    Class = "Bladedancer",
                    Level = 180,
                    Team = "",
                    CombatPower = 818000,
                    Contribution = 20000,
                    JoiningDate = new DateTime(2016, 12, 15),
                    Active = true,
                    Rank = 2,
                    Email = "",
                    DiscordId = "Weapons",
                    LastUpdate = new DateTime(2018, 04, 14)
                },
                new Member()
                {
                    Guid = Guid.NewGuid(),
                    PlayerName = "Jwalsh",
                    Class = "Spellhowler",
                    Level = 180,
                    Team = "",
                    CombatPower = 807799,
                    Contribution = 20000,
                    JoiningDate = new DateTime(2015, 06, 20),
                    Active = true,
                    Rank = 3,
                    Email = "",
                    DiscordId = "Jwalsh",
                    LastUpdate = new DateTime(2018, 04, 14)
                },
                new Member()
                {
                    Guid = Guid.NewGuid(),
                    PlayerName = "Sogglet",
                    Class = "Shillien Knight",
                    Level = 180,
                    Team = "",
                    CombatPower = 804180,
                    Contribution = 20000,
                    JoiningDate = new DateTime(2016, 07, 12),
                    Active = true,
                    Rank = 4,
                    Email = "",
                    DiscordId = "Sogglet",
                    LastUpdate = new DateTime(2018, 04, 14)
                }
            };
        }
        // GET: Members
        public ActionResult Index()
        {

            return View(_members);
        }
        
        public ActionResult Detail(string playerName)
        {
            var member = _members.FirstOrDefault(m => m.PlayerName == playerName);
            return View(member);;
        }
    }
}