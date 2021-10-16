using Microsoft.AspNetCore.Mvc;
using riode.Models.DataContexts;
using riode.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        readonly RiodeDbContext db;
        public DashboardController(RiodeDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var contact = db.Contacts.ToList();   
            return View(contact);
        }
    }
}
