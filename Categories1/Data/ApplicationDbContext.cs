using Categories1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Categories1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }

    }
}
