using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chore_Tracking_Application.Models
{
    public class ChoreContext : DbContext
    {
        public ChoreContext(DbContextOptions<ChoreContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Chore> Chores { get; set; }
    }
}
