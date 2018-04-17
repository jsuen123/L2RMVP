using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVPClanManagementSystem.Models;

namespace MVPClanManagementSystem.Controllers
{
    public class WeeklysController : Controller
    {
        private List<WeeklyReward> _weeklyRewards;
        private List<Weekly> _weeklys;
        public WeeklysController()
        {
            _weeklys = new List<Weekly>()
            {
                new Weekly()
                {
                    WeekNo = 14,
                    StartDate = new DateTime(2018, 04, 02),
                    EndDate = new DateTime(2018, 04, 08)
                },
                new Weekly()
                {
                    WeekNo = 15,
                    StartDate = new DateTime(2018, 04, 09),
                    EndDate = new DateTime(2018, 04, 15)
                },
                new Weekly()
                {
                WeekNo = 16,
                StartDate = new DateTime(2018, 04, 16),
                EndDate = new DateTime(2018, 04, 22)
            }
            };


            Guid weekGuid = Guid.NewGuid();

            _weeklyRewards = new List<WeeklyReward>()
            {
                new WeeklyReward()
                {
                    Guid = weekGuid,
                    WeekNo = 15,
                    PlayerName = "donehaveone",
                    Contribution = 5000,
                    RequestedItems = new List<RedeemItem>()
                    {
                        new RedeemItem(){ Name = "Meteor Shower Page", Cost = 3500, Qty = 1},
                        new RedeemItem(){ Name = "Healing Strike Page", Cost = 1000, Qty = 1 },
                    },
                    Remaining = 500,
                    RewardGiven = true
                },
                new WeeklyReward()
                {
                    Guid = weekGuid,
                    WeekNo = 15,
                    PlayerName = "LunaIsabella",
                    Contribution = 8000,
                    RequestedItems = new List<RedeemItem>()
                    {
                        new RedeemItem(){ Name = "Meteor Shower Page", Cost = 3500, Qty = 2},
                        new RedeemItem(){ Name = "Healing Strike Page", Cost = 1000, Qty = 1},
                    },
                    Remaining = 0,
                    RewardGiven = true
                },
                new WeeklyReward()
                {
                    Guid = weekGuid,
                    WeekNo = 15,
                    PlayerName = "Weapons",
                    Contribution = 2150,
                    RequestedItems = new List<RedeemItem>()
                    {
                        new RedeemItem(){ Name = "Healing Strike Page", Cost = 1000, Qty = 2},
                    },
                    Remaining = 150,
                    RewardGiven = true
                }
            };
        }

        // GET: Weeklys
        public ActionResult Index()
        {
            return View(_weeklys);
        }

        public ActionResult Detail(int weekNo)
        {
            var weeklyRewards = _weeklyRewards.Where(w => w.WeekNo == weekNo);
            return View(weeklyRewards);
        }
    }
}