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
    public class CategoriesController : Controller
    {
        readonly RiodeDbContext db;
        public CategoriesController(RiodeDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
