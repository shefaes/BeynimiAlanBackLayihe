using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Setting>Settings { get; set; }
        public IEnumerable<object> Categories { get; internal set; }
        public IEnumerable<object> Products { get; internal set; }
        public IEnumerable<object> Sliders { get; internal set; }
    }
}
