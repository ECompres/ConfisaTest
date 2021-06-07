using Microsoft.EntityFrameworkCore;
using ConfisaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfisaTest.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Dealers> Dealers { get; set; }
        public DbSet<Oficiales> Oficiales { get; set; }
    }
}
