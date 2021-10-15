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
    }
}
