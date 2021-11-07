using riode.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Models.FormModels
{
    public class SpecificationFormModel
    {
        public Specification Specification { get; set; }
        public int[] SelectedCategories { get; set; }
    }
}
