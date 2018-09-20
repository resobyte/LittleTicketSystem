﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TicketSystem.Data.Data;

namespace TicketSystem.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180920163547_TicketSystemMigration")]
    partial class TicketSystemMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicketSystem.Data.Models.Entities.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdminPassword");

                    b.Property<int>("AdminUserName");

                    b.HasKey("ID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("TicketSystem.Data.Models.Entities.Departments", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DepartmentName");

                    b.HasKey("ID");

                    b.ToTable("Deparments");
                });

            modelBuilder.Entity("TicketSystem.Data.Models.Entities.Mail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MailDescription");

                    b.Property<int>("MailTitle");

                    b.Property<int?>("UserIDID");

                    b.HasKey("ID");

                    b.HasIndex("UserIDID");

                    b.ToTable("Mail");
                });

            modelBuilder.Entity("TicketSystem.Data.Models.Entities.Notifications", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NotificationDescription");

                    b.Property<int>("NotificationID");

                    b.Property<int>("NotificationTitle");

                    b.Property<int?>("UserIDID");

                    b.HasKey("ID");

                    b.HasIndex("UserIDID");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("TicketSystem.Data.Models.Entities.Tickets", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssignDate");

                    b.Property<int>("AssignUser");

                    b.Property<int>("CreateDate");

                    b.Property<int>("CreateUser");

                    b.Property<string>("Status");

                    b.Property<string>("TicketDescription");

                    b.Property<string>("TicketTitle");

                    b.Property<int>("UpdateDate");

                    b.Property<int>("UpdateUser");

                    b.Property<int?>("UserIDID");

                    b.HasKey("ID");

                    b.HasIndex("UserIDID");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TicketSystem.Data.Models.Entities.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DeparmentIDID");

                    b.Property<string>("UserAvatar");

                    b.Property<string>("UserEmail");

                    b.Property<string>("UserLastIP");

                    b.Property<string>("UserLastLogin");

                    b.Property<string>("UserName");

                    b.Property<string>("UserPassword");

                    b.Property<string>("UserPhoneNumber");

                    b.HasKey("ID");

                    b.HasIndex("DeparmentIDID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TicketSystem.Data.Models.Entities.Mail", b =>
                {
                    b.HasOne("TicketSystem.Data.Models.Entities.Users", "UserID")
                        .WithMany()
                        .HasForeignKey("UserIDID");
                });

            modelBuilder.Entity("TicketSystem.Data.Models.Entities.Notifications", b =>
                {
                    b.HasOne("TicketSystem.Data.Models.Entities.Users", "UserID")
                        .WithMany()
                        .HasForeignKey("UserIDID");
                });

            modelBuilder.Entity("TicketSystem.Data.Models.Entities.Tickets", b =>
                {
                    b.HasOne("TicketSystem.Data.Models.Entities.Users", "UserID")
                        .WithMany()
                        .HasForeignKey("UserIDID");
                });

            modelBuilder.Entity("TicketSystem.Data.Models.Entities.Users", b =>
                {
                    b.HasOne("TicketSystem.Data.Models.Entities.Departments", "DeparmentID")
                        .WithMany()
                        .HasForeignKey("DeparmentIDID");
                });
#pragma warning restore 612, 618
        }
    }
}