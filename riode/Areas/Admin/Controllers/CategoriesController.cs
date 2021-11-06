using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using riode.Models.DataContexts;
using riode.Models.Entities;
using riode.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        readonly RiodeDbContext db;
        public CategoriesController(RiodeDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
           var categories = await db.Category.ToListAsync();
            return View(categories);
        }

        public async  Task<IActionResult> Create()
        {
            var categoryList = await db.Category.ToListAsync();
            var vm = new CategoryViewModel();
            vm.Categories = categoryList;
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Categories category)
        {
            
            var categoryList = await db.Category.ToListAsync();
            var vm = new CategoryViewModel();
            vm.Category = category;
            vm.Categories = categoryList;
            if (ModelState.IsValid)
            {
                await db.Category.AddAsync(category);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vm);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var category = await db.Category.FirstOrDefaultAsync(b => b.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            if (category.DeletedDate != null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost([FromRoute] int id)
        {

            if (id < 1)
            {
                return NotFound();
            }
            var category = await db.Category.FirstOrDefaultAsync(b => b.Id == id);
            var data  = await db.Category.FirstOrDefaultAsync(b=>b.BigCategoryId == id);
            
            if (data != null)
            {
                if (data.DeletedDate == null)
                {
                    return RedirectToAction("Index");
                }
            }
            category.DeletedDate = DateTime.Now;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
