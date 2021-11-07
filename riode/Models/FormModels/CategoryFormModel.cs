using riode.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Models.FormModels
{
    public class CategoryFormModel
    {
        public Categories Category { get; set; }
        public int[] SelectedSpecifications { get; set; }
    }
}
