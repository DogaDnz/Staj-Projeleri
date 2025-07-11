using Microsoft.EntityFrameworkCore;
using MersinLiman.Models;
using System.Collections.Generic;

namespace MersinLiman.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
