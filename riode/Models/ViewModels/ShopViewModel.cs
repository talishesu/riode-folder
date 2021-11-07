using riode.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Models.ViewModels
{
    public class ShopViewModel
    {
        public IEnumerable<Categories> Categories { get; set; }
        public IEnumerable<Colors> Colors { get; set; }
        public IEnumerable<Brands> Brands { get; set; }
    }
}
