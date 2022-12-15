using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestEF.Models;

namespace TestEF.Data
{
    public class TestEFContext : DbContext
    {
        public TestEFContext (DbContextOptions<TestEFContext> options)
            : base(options)
        {
        }

        public DbSet<TestEF.Models.Player> Player { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestEF.Models.Player>().ToTable("Player");
        }
    }
}
