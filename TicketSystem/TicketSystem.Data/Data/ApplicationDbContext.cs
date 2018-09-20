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

        public DbSet<Admin> Admin { get; set; }

        public DbSet<Departments> Deparments { get; set; }

        public DbSet<Mail> Mail { get; set; }

        public DbSet<Notifications> Notifications { get; set; }

        public DbSet<Users> Users { get; set; }
    }
}
