using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Data.Models.Entities;

namespace TicketSystem.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        
        public DbSet<Tickets> Tickets { get; set; }

        public DbSet<Tickets> Admin { get; set; }

        public DbSet<Tickets> Deparments { get; set; }

        public DbSet<Tickets> Mail { get; set; }

        public DbSet<Tickets> Notification{ get; set; }

        public DbSet<Tickets> Users { get; set; }
    }
}
