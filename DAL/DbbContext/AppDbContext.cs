using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace DAL.DbbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
