using riode.Models.Entities;
using System;
using System.Collections.Generic;

namespace riode.Models.ViewModels
{
    public class SpecificationViewModel
    {
        public Specification Specification { get; set; }
        public IEnumerable<Tuple<Categories, bool>> Categories { get; set; }
    }
}
