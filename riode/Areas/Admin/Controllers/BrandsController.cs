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
    public class BrandsController : Controller
    {
        readonly RiodeDbContext db;
        public BrandsController(RiodeDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var brandList = await db.Brand.ToListAsync();
            return View(brandList);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Create(Brands brand)
        {
            if (ModelState.IsValid)
            {
                await db.Brand.AddAsync(brand);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(brand);
        }


        public async Task<IActionResult> Edit(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var brand = await db.Brand.FirstOrDefaultAsync(b => b.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            if (brand.DeletedDate != null)
            {
                return NotFound();
            }
            return View(brand);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute]int id,Brands model)
        {
            if (ModelState.IsValid)
            {
                var brand = await db.Brand.FirstOrDefaultAsync(b => b.Id == id);
                if (brand == null)
                {
                    return NotFound();
                }
                if (brand.DeletedDate != null)
                {
                    return NotFound();
                }
                brand.Name = model.Name;
                brand.Description = model.Description;
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
            var brand = await db.Brand.FirstOrDefaultAsync(b => b.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            if (brand.DeletedDate != null)
            {
                return NotFound();
            }
            return View(brand);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost([FromRoute] int id)
        {
                if (id < 1)
                {
                    return NotFound();
                }
                var brand = await db.Brand.FirstOrDefaultAsync(b => b.Id == id);
                if (brand == null)
                {
                    return NotFound();
                }
                if (brand.DeletedDate != null)
                {
                    return NotFound();
                }
                brand.DeletedDate = DateTime.Now;
                await db.SaveChangesAsync();

                return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail([FromRoute] int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var brand = await db.Brand.FirstOrDefaultAsync(b => b.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            if (brand.DeletedDate != null)
            {
                return NotFound();
            }
            return View(brand);
        }

    }
}
