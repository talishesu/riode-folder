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
    }
}
