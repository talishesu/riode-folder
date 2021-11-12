using Microsoft.AspNetCore.Http;
using riode.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Models.Entities
{
    public class Products : BaseEntity
    {
        public string StockKeepingUnit { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public int BrandId { get; set; }
        public virtual Brands Brand { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ProductImage> Images { get; set; }
        public virtual ICollection<SpecificationProductItem> SpecificationItems { get; set; }
        public virtual ICollection<ProductCategoryItem> CategoryItems { get; set; }

        [NotMapped]
        public ImageItem[] Files  { get; set; }
    }
    public class ProductImage:BaseEntity
    {
        public int ProductId { get; set; }
        public virtual Products Product { get; set; }
        public string ImagePath { get; set; }
        public bool IsMain { get; set; }
    }
    public class SpecificationProductItem : HistoryWatch
    {
        public int ProductId { get; set; }
        public virtual Products Product { get; set; }
        public int SpecificationId { get; set; }
        public virtual Specification Specification { get; set; }
        public  string Value { get; set; }
    }
    public class ProductCategoryItem : HistoryWatch
    {
        public int ProductId { get; set; }
        public virtual Products Product { get; set; }
        public int CategoryId { get; set; }
        public virtual Categories Category { get; set; }
    }
    public class ImageItem
    {
        public int? Id { get; set; }
        public bool IsMain { get; set; }
        public string TempPath { get; set; }
        public IFormFile File { get; set; }
    }
}
