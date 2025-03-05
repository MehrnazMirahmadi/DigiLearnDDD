﻿// <auto-generated />
using System;
using DigiLearn.Infrastructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DigiLearn.Infrastructure.EF.Migrations
{
    [DbContext(typeof(ReadDbContext))]
    [Migration("20250305120949_InitReadDb")]
    partial class InitReadDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DigiLearn.Application.Models.CourseManagement.CourseAttendeReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("CourseAttendees", (string)null);
                });

            modelBuilder.Entity("DigiLearn.Application.Models.CourseManagement.CourseCatalogReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseCatalogs", (string)null);
                });

            modelBuilder.Entity("DigiLearn.Application.Models.CourseManagement.CourseReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("InstructorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsFree")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("DigiLearn.Application.Models.CourseManagement.InstructorReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("DigiLearn.Application.Models.CourseManagement.LessonReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CatalogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.ToTable("Lessons", (string)null);
                });

            modelBuilder.Entity("DigiLearn.Application.Models.PaymentManagement.InvoiceReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("Invoices", (string)null);
                });

            modelBuilder.Entity("DigiLearn.Application.Models.UserManagement.RoleReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("DigiLearn.Application.Models.UserManagement.UserReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("DigiLearn.Application.Models.UserManagement.UserRoleReadModel", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("DigiLearn.Application.Models.CourseManagement.CourseAttendeReadModel", b =>
                {
                    b.HasOne("DigiLearn.Application.Models.CourseManagement.CourseReadModel", "Course")
                        .WithMany("CourseAttendees")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigiLearn.Application.Models.UserManagement.UserReadModel", "User")
                        .WithMany("CourseAttendes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DigiLearn.Application.Models.CourseManagement.CourseCatalogReadModel", b =>
                {
                    b.HasOne("DigiLearn.Application.Models.CourseManagement.CourseReadModel", "Course")
                        .WithMany("CourseCatalogs")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("DigiLearn.Application.Models.CourseManagement.CourseReadModel", b =>
                {
                    b.HasOne("DigiLearn.Application.Models.CourseManagement.InstructorReadModel", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("DigiLearn.Application.Models.CourseManagement.LessonReadModel", b =>
                {
                    b.HasOne("DigiLearn.Application.Models.CourseManagement.CourseCatalogReadModel", "CourseCatalog")
                        .WithMany("Lessons")
                        .HasForeignKey("CatalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseCatalog");
                });

            modelBuilder.Entity("DigiLearn.Application.Models.PaymentManagement.InvoiceReadModel", b =>
                {
                    b.HasOne("DigiLearn.Application.Models.CourseManagement.CourseReadModel", "Course")
                        .WithMany("Invoices")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigiLearn.Application.Models.UserManagement.UserReadModel", "User")
                        .WithMany("Invoices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DigiLearn.Application.Models.UserManagement.UserRoleReadModel", b =>
                {
                    b.HasOne("DigiLearn.Application.Models.UserManagement.RoleReadModel", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigiLearn.Application.Models.UserManagement.UserReadModel", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DigiLearn.Application.Models.CourseManagement.CourseCatalogReadModel", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("DigiLearn.Application.Models.CourseManagement.CourseReadModel", b =>
                {
                    b.Navigation("CourseAttendees");

                    b.Navigation("CourseCatalogs");

                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("DigiLearn.Application.Models.CourseManagement.InstructorReadModel", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("DigiLearn.Application.Models.UserManagement.RoleReadModel", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("DigiLearn.Application.Models.UserManagement.UserReadModel", b =>
                {
                    b.Navigation("CourseAttendes");

                    b.Navigation("Invoices");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
