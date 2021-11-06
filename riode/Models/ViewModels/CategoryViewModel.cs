using riode.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Models.ViewModels
{
    public class CategoryViewModel
    {
        public List<Categories> Categories { get; set; }
        public Categories Category { get; set; }
    }
}
