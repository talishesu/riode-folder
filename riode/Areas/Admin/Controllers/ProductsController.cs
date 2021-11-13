using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using riode.Models.DataContexts;
using riode.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        readonly RiodeDbContext db;
        readonly IWebHostEnvironment env;

        public ProductsController(RiodeDbContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.BrandId =  new SelectList(await db.Brand.Where(b => b.DeletedDate == null).ToListAsync(), "Id", "Name");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Files,StockKeepingUnit,Name,ShortDescription,BrandId,Description,Id")]Products model)
        {
            ViewBag.BrandId = new SelectList(await db.Brand.Where(b => b.DeletedDate == null).ToListAsync(), "Id", "Name");
            if (model.Files == null && !model.Files.Any())
            {
                ModelState.AddModelError("Name", "Sekil Elave Olunmuyub");
            };

            if (!ModelState.IsValid)
            {
                return View(model);
            }



            model.Images = new List<ProductImage>();

            foreach (var image in model.Files)
            {
                var extension = Path.GetExtension(image.File.FileName);

                var fileName = $"product-{Guid.NewGuid()}{extension}".ToLower();


                var phsicalPath = Path.Combine(env.WebRootPath, "uploads", "products", "images", fileName);

                using (var fs = new FileStream(phsicalPath, FileMode.Create, FileAccess.Write))
                {
                    await image.File.CopyToAsync(fs);
                }

                model.Images.Add(new ProductImage
                {
                    ImagePath = fileName,
                    IsMain = image.IsMain
                });
            }
            db.Products.Add(model);
            await db.SaveChangesAsync();
            return RedirectToAction("Create");
        }
    }
}
