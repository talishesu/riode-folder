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
    public class SizesController : Controller
    {
        readonly RiodeDbContext db;
        public SizesController(RiodeDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var sizeList = await db.Size.ToListAsync();
            return View(sizeList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Sizes size)
        {
            if (ModelState.IsValid)
            {
                await db.Size.AddAsync(size);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(size);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var size = await db.Size.FirstOrDefaultAsync(b => b.Id == id);
            if (size == null)
            {
                return NotFound();
            }
            if (size.DeletedDate != null)
            {
                return NotFound();
            }
            return View(size);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute] int id, Sizes model)
        {
            if (ModelState.IsValid)
            {
                var size = await db.Size.FirstOrDefaultAsync(b => b.Id == id);
                if (size == null)
                {
                    return NotFound();
                }
                if (size.DeletedDate != null)
                {
                    return NotFound();
                }
                size.Name = model.Name;
                size.ShortName = model.ShortName;
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
            var size = await db.Size.FirstOrDefaultAsync(b => b.Id == id);
            if (size == null)
            {
                return NotFound();
            }
            if (size.DeletedDate != null)
            {
                return NotFound();
            }
            return View(size);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost([FromRoute] int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var size = await db.Size.FirstOrDefaultAsync(b => b.Id == id);
            if (size == null)
            {
                return NotFound();
            }
            if (size.DeletedDate != null)
            {
                return NotFound();
            }
            size.DeletedDate = DateTime.Now;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail([FromRoute] int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var size = await db.Size.FirstOrDefaultAsync(b => b.Id == id);
            if (size == null)
            {
                return NotFound();
            }
            if (size.DeletedDate != null)
            {
                return NotFound();
            }
            return View(size);
        }
    }
}
