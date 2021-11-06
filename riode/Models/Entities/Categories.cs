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

        public virtual Categories BigCategory { get; set; }

        public int? BigCategoryId { get; set; }

        public virtual ICollection<Categories> Children { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? DeletedDate { get; set; }
    }
}
