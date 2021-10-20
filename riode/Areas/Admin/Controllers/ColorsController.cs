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
    public class ColorsController : Controller
    {
        readonly RiodeDbContext db;
        public ColorsController(RiodeDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var colorList = await db.Color.ToListAsync();
            return View(colorList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Colors color)
        {
            if (ModelState.IsValid)
            {
                await db.Color.AddAsync(color);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(color);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var color = await db.Color.FirstOrDefaultAsync(b => b.Id == id);
            if (color == null)
            {
                return NotFound();
            }
            if (color.DeletedDate != null)
            {
                return NotFound();
            }
            return View(color);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute] int id, Colors model)
        {
            if (ModelState.IsValid)
            {
                var color = await db.Color.FirstOrDefaultAsync(b => b.Id == id);
                if (color == null)
                {
                    return NotFound();
                }
                if (color.DeletedDate != null)
                {
                    return NotFound();
                }
                color.Name = model.Name;
                color.ColorCode = model.ColorCode;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var color = await db.Color.FirstOrDefaultAsync(b => b.Id == id);
            if (color == null)
            {
                return NotFound();
            }
            if (color.DeletedDate != null)
            {
                return NotFound();
            }
            return View(color);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost([FromRoute] int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var color = await db.Color.FirstOrDefaultAsync(b => b.Id == id);
            if (color == null)
            {
                return NotFound();
            }
            if (color.DeletedDate != null)
            {
                return NotFound();
            }
            color.DeletedDate = DateTime.Now;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail([FromRoute] int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var color = await db.Color.FirstOrDefaultAsync(b => b.Id == id);
            if (color == null)
            {
                return NotFound();
            }
            if (color.DeletedDate != null)
            {
                return NotFound();
            }
            return View(color);
        }
    }
}
