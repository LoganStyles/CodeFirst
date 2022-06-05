﻿// <auto-generated />
using CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirst.Migrations
{
    [DbContext(typeof(ArtistsContext))]
    [Migration("20220605214532_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("AlbumTag", b =>
                {
                    b.Property<long>("AlbumId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TagId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlbumId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("AlbumTags", (string)null);
                });

            modelBuilder.Entity("CodeFirst.Entities.Album", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("CodeFirst.Entities.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CodeFirst.Entities.Studio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("HouseNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("CodeFirst.Entities.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("AlbumTag", b =>
                {
                    b.HasOne("CodeFirst.Entities.Album", null)
                        .WithMany()
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirst.Entities.Album", b =>
                {
                    b.HasOne("CodeFirst.Entities.Employee", "Employee")
                        .WithMany("Albums")
                        .HasForeignKey("EmployeeId")
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("CodeFirst.Entities.Studio", b =>
                {
                    b.HasOne("CodeFirst.Entities.Employee", "Employee")
                        .WithOne("Studio")
                        .HasForeignKey("CodeFirst.Entities.Studio", "EmployeeId")
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("CodeFirst.Entities.Employee", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Studio")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
