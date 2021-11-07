using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using riode.Models.DataContexts;
using riode.Models.Entities;
using riode.Models.FormModels;
using riode.Models.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpecificationsController : Controller
    {
        readonly RiodeDbContext db;
        public SpecificationsController(RiodeDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var data = await db.Specifications
                .Where(b => b.DeletedDate == null)
                .ToListAsync();
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id < 1)
            {
                return NotFound();//404
            }

            var entity = await db.Specifications.FirstOrDefaultAsync(b => b.Id == id && b.DeletedDate == null);

            if (entity == null)
            {
                return NotFound();//404
            }

            return View(entity);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Specification model)
        {
            if (ModelState.IsValid)
            {
                db.Specifications.Add(model);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
        public async Task<IActionResult> Edit(int id)
        {
            if (id < 1)
            {
                return NotFound();//404
            }

            var entity = await db.Specifications.FirstOrDefaultAsync(b => b.Id == id && b.DeletedDate == null);

            if (entity == null)
            {
                return NotFound();//404
            }

            var vm = new SpecificationViewModel();
            vm.Specification = entity;
            //vm.Categories = await db.Categories
            //    .Include(c => c.Children)
            //    .Where(c => c.DeletedDate == null)
            //    .ToListAsync();

            vm.Categories = await (from c in db.Category.Include(c => c.Children)
                                   join sc in db.SpecificationCategoryCollection
                                   on new { CategoryId = c.Id, SpecificationId = entity.Id, DeletedDate = (DateTime?)null } 
                                   equals new { sc.CategoryId, sc.SpecificationId, sc.DeletedDate } into joinedSc
                                   from jsc in joinedSc.DefaultIfEmpty()
                                   where c.DeletedDate == null
                                   select Tuple.Create(c, jsc != null))
                        .ToListAsync();

            return View(vm);
        }


        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute] int id, SpecificationFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new
                {
                    error = true,
                    message = "Saheler tam doldurulmayib"
                });
            }

            if (id != model.Specification.Id || id < 1)
            {
                return Json(new
                {
                    error = true,
                    message = "Xətalı data"
                });
            }

            var entity = await db.Specifications.FirstOrDefaultAsync(b => b.Id == id && b.DeletedDate == null);

            if (entity == null)
            {
                return NotFound();//404
            }

            entity.Name = model.Specification.Name;

            var inDb = await db.SpecificationCategoryCollection
                        .Where(sc => sc.SpecificationId == entity.Id).ToListAsync();

            if (model.SelectedCategories == null || !model.SelectedCategories.Any())
            {
                foreach (var item in inDb)
                {
                    item.DeletedDate = DateTime.Now;
                }
            }

            if (model.SelectedCategories != null)
            {


                // databasede olmayanlar
                var excepted = model.SelectedCategories.Except(inDb.Where(s => s.DeletedDate == null).Select(s => s.CategoryId))
                    .ToArray();

                // databasede olan ama secilmish gelmeyenler
                var excepted2 = inDb.Select(s => s.CategoryId).Except(model.SelectedCategories).ToArray();



                if (excepted.Length > 0)
                {
                    foreach (var item in excepted)
                    {
                        var inDbEntity = await db.SpecificationCategoryCollection
                            .FirstOrDefaultAsync(sc => sc.SpecificationId == entity.Id && sc.CategoryId == item && sc.DeletedDate != null);

                        if (inDbEntity != null)
                        {
                            inDbEntity.DeletedByUserId = null;
                            inDbEntity.DeletedDate = null;
                        }
                        else
                        {
                            db.SpecificationCategoryCollection.Add(new SpecificationCategoryItem
                            {
                                SpecificationId = entity.Id,
                                CategoryId = item
                            });
                        }

                    }
                }
                // databasede olan ama secilmish gelmeyenler
                if (excepted2.Length > 0)
                {
                    var forDelete = inDb.Where(sc => excepted2.Contains(sc.CategoryId));

                    foreach (var item in forDelete)
                    {
                        item.DeletedDate = DateTime.Now;
                    }
                }
            }

            //db.Specifications.Update(entity);
            await db.SaveChangesAsync();
            return Json(new
            {
                error = false,
                message = "Halaldi"
            });

        }

        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
            //throw new Exception("nese bir error");
            if (id < 1)
            {
                return Json(new
                {
                    error = true,
                    message = "Məlumat tapılmadı"
                });
            }

            var entity = await db.Specifications.FirstOrDefaultAsync(b => b.Id == id && b.DeletedDate == null);
            if (entity == null)
            {
                return Json(new
                {
                    error = true,
                    message = "Məlumat tapılmadı"
                });
            }

            //db.Specifications.Remove(entity);
            entity.DeletedDate = DateTime.UtcNow.AddHours(4);
            await db.SaveChangesAsync();

            return Json(new
            {
                error = false,
                message = "Məlumat silindi"
            });
        }

    }
}
