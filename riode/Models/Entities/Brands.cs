using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Models.Entities
{
    public class Brands
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Bos Buraxila Bilmez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description Yazilmayib")]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? DeletedDate { get; set; }
    }
}
