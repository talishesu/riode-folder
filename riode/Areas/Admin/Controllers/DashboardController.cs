using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Answer([FromRoute]int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var contact = await db.Contacts.FirstOrDefaultAsync(b => b.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }


        [HttpPost]
        public async Task<IActionResult> Answer([FromRoute] int id, string answer)
        {
            if (ModelState.IsValid)
            {
                var contact = await db.Contacts.FirstOrDefaultAsync(b => b.Id == id);
                if (contact == null)
                {
                    return NotFound();
                }
                contact.Answer = answer;
                contact.AnswerDate = DateTime.Now;
                contact.AnsweredByUserId = 1;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(answer);
        }


        public async Task<IActionResult> Detail([FromRoute] int id)
        {

            if (id < 1)
            {
                return NotFound();
            }
            var contact = await db.Contacts.FirstOrDefaultAsync(b => b.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

    }
}
