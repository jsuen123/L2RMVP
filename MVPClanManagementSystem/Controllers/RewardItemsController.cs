using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVPClanManagementSystem.Models;

namespace MVPClanManagementSystem.Controllers
{
    public class RewardItemsController : Controller
    {
        // GET: RewardItems
        public ActionResult Index()
        {
            var items = new List<Item>()
            {
                new Item()
                {
                Guid = Guid.NewGuid(),
                Name = "Meteor Shower Page",
                AvailableQty = 30,
                Cost = 3500,
                Note = "",
                MaxClaimPerMonth = 2,
                Grade = "High"
                },
                new Item()
                {
                Guid = Guid.NewGuid(),
                Name = "Healing Strike Page",
                AvailableQty = 45,
                Cost = 1000,
                Note = "",
                MaxClaimPerMonth = 10,
                Grade = "High"
            }
                ,
                new Item()
                {
                    Guid = Guid.NewGuid(),
                    Name = "Weapon Box",
                    AvailableQty = 120,
                    Cost = 100,
                    Note = "",
                    MaxClaimPerMonth = 10,
                    Grade = "Normal"
                }
                ,
                new Item()
                {
                    Guid = Guid.NewGuid(),
                    Name = "Accessories Box",
                    AvailableQty = 70,
                    Cost = 200,
                    Note = "",
                    MaxClaimPerMonth = 5,
                    Grade = "Normal"
                }
                ,
                new Item()
                {
                    Guid = Guid.NewGuid(),
                    Name = "Red Diamond Box",
                    AvailableQty = 340,
                    Cost = 200,
                    Note = "",
                    MaxClaimPerMonth = 10,
                    Grade = "Normal"
                }
            };

            return View(items);
        }
    }
}