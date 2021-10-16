using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Models.Entities
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad Bos Buraxila Bilmez")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Epoct Bos Buraxila Bilmez")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Serh Yazilmayib")]
        public string Comment { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string Answer { get; set; }

        public DateTime? AnswerDate { get; set; }

        public int? AnsweredByUserId { get; set; }
    }
}
