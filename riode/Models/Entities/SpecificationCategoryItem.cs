using riode.AppCode.Infrastructure;
using riode.Models.Entities;

namespace riode.Models.Entities
{
    public class SpecificationCategoryItem : HistoryWatch
    {
        public int SpecificationId { get; set; }
        public virtual Specification Spesification { get; set; }
        public int CategoryId { get; set; }
        public virtual Categories Category { get; set; }
    }
}
