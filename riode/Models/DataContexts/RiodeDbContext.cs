using Microsoft.EntityFrameworkCore;
using riode.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riode.Models.DataContexts
{
    public class RiodeDbContext : DbContext
    {
        public RiodeDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Brands> Brand { get; set; }
        public DbSet<Sizes> Size { get; set; }
        public DbSet<Colors> Color { get; set; }
        public DbSet<Categories> Category { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<SpecificationCategoryItem> SpecificationCategoryCollection { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductCategoryItem> ProductCategoryCollection { get; set; }
        public DbSet<SpecificationProductItem> SpecificationProductCollection { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SpecificationCategoryItem>(e => {

                e.HasKey(k => new { k.SpecificationId, k.CategoryId });
            });

            modelBuilder.Entity<ProductCategoryItem>(e => {

                e.HasKey(k => new { k.CategoryId, k.ProductId });
            });

            modelBuilder.Entity<SpecificationProductItem>(e => {

                e.HasKey(k => new { k.SpecificationId, k.ProductId });
            });
        }


    }
}
