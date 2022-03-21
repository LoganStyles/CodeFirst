﻿// <auto-generated />
using CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirst.Migrations
{
    [DbContext(typeof(ArtistsContext))]
    partial class ArtistsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasPrecision(18, 2)
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("CodeFirst.Entities.Book", b =>
                {
                    b.Property<long>("ISBN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ISBN");

                    b.ToTable("Book");
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

                    b.Property<long>("SeniorityLevelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SeniorityLevelId")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CodeFirst.Entities.Publisher", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT")
                        .HasComment("The address of the publisher");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("tbl_Publishers");
                });

            modelBuilder.Entity("CodeFirst.Entities.SalesOutlet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasPrecision(10, 2)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Title")
                        .HasComment("The name of the outlet");

                    b.HasKey("Id");

                    b.ToTable("tbl_SalesOutlets", (string)null);
                });

            modelBuilder.Entity("CodeFirst.Entities.SeniorityLevel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SeniorityLevels");
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

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Title = "Rock"
                        },
                        new
                        {
                            Id = 2L,
                            Title = "RnB"
                        },
                        new
                        {
                            Id = 3L,
                            Title = "Jazz"
                        },
                        new
                        {
                            Id = 4L,
                            Title = "Country"
                        },
                        new
                        {
                            Id = 5L,
                            Title = "Classical"
                        },
                        new
                        {
                            Id = 6L,
                            Title = "Blues"
                        });
                });

            modelBuilder.Entity("CodeFirst.Order", b =>
                {
                    b.Property<long>("TrackingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("SalesOutletId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TrackingId");

                    b.HasIndex("SalesOutletId");

                    b.ToTable("Orders");
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

            modelBuilder.Entity("CodeFirst.Entities.Employee", b =>
                {
                    b.HasOne("CodeFirst.Entities.SeniorityLevel", "SeniorityLevel")
                        .WithOne("Employee")
                        .HasForeignKey("CodeFirst.Entities.Employee", "SeniorityLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SeniorityLevel");
                });

            modelBuilder.Entity("CodeFirst.Entities.Studio", b =>
                {
                    b.HasOne("CodeFirst.Entities.Employee", "Employee")
                        .WithOne("Studio")
                        .HasForeignKey("CodeFirst.Entities.Studio", "EmployeeId")
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("CodeFirst.Order", b =>
                {
                    b.HasOne("CodeFirst.Entities.SalesOutlet", "SalesOutlet")
                        .WithMany("Orders")
                        .HasForeignKey("SalesOutletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SalesOutlet");
                });

            modelBuilder.Entity("CodeFirst.Entities.Employee", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Studio")
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirst.Entities.SalesOutlet", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CodeFirst.Entities.SeniorityLevel", b =>
                {
                    b.Navigation("Employee")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
