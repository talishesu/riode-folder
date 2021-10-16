using Microsoft.AspNetCore.Mvc;
using riode.Models.DataContexts;
using riode.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Controllers
{
    public class PagesController : Controller
    {
        readonly RiodeDbContext db;
        public PagesController(RiodeDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                ModelState.Clear();

                return Json(new
                {
                    error = false,
                    message = "Sizin Sorgunuz Qebul Olundu!"
                });
            }

            //return View(contact);

            return Json(new
            {
                error = true,
                message = "Sizin Sorgunuz Qebul Olunmadi!!!"
            });
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Faqs()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult ComingSoon()
        {
            return View();
        }
    }
}
