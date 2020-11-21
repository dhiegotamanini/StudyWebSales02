﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWeb02.Data;

namespace SalesWeb02.Migrations
{
    [DbContext(typeof(SalesWeb02Context))]
    [Migration("20201121001225_DepartmentsForeignKey")]
    partial class DepartmentsForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWeb02.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SalesWeb02.Models.SalesRecord", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("SalesStatus");

                    b.Property<int?>("SellerID");

                    b.HasKey("ID");

                    b.HasIndex("SellerID");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("SalesWeb02.Models.Seller", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("DepartmentID");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("SalesWeb02.Models.SalesRecord", b =>
                {
                    b.HasOne("SalesWeb02.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerID");
                });

            modelBuilder.Entity("SalesWeb02.Models.Seller", b =>
                {
                    b.HasOne("SalesWeb02.Models.Department", "Department")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}