using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TicketSystem.API.Models.DB
{
    public partial class LittleTicketSystemContext : DbContext
    {
        public LittleTicketSystemContext()
        {
        }

        public LittleTicketSystemContext(DbContextOptions<LittleTicketSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Mail> Mail { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-29NR7T2;Initial Catalog=LittleTicketSystem;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Mail>(entity =>
            {
                entity.HasIndex(e => e.UserIdid);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserIdid).HasColumnName("UserIDID");

                entity.HasOne(d => d.UserId)
                    .WithMany(p => p.Mail)
                    .HasForeignKey(d => d.UserIdid);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasIndex(e => e.UserIdid);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.UserIdid).HasColumnName("UserIDID");

                entity.HasOne(d => d.UserId)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserIdid);
            });

            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.HasIndex(e => e.UserIdid);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserIdid).HasColumnName("UserIDID");

                entity.HasOne(d => d.UserId)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.UserIdid);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.DeparmentIdid);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeparmentIdid).HasColumnName("DeparmentIDID");

                entity.Property(e => e.UserLastIp).HasColumnName("UserLastIP");

                entity.HasOne(d => d.DeparmentId)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DeparmentIdid);
            });
        }
    }
}
