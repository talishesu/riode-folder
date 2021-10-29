using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Models.Entities
{
    public class Categories
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Bos Buraxila Bilmez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Category Hansi Tip Oldugu Secilmeildir")]
        public bool BigCategory { get; set; }

        public int? BigCategoryId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? DeletedDate { get; set; }
    }
}
