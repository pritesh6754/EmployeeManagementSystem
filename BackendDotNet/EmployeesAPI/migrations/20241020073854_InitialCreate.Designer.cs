﻿// <auto-generated />
using System;
using EmployeesAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeesAPI.Migrations
{
    [DbContext(typeof(EMPLOYEE_DATABASEContext))]
    [Migration("20241020073854_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeesAPI.Models.BusinessUser", b =>
                {
                    b.Property<string>("Username")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("username");

                    b.Property<string>("Passwrd")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("passwrd");

                    b.HasKey("Username")
                        .HasName("PK__BUSINESS__F3DBC573583A5718");

                    b.ToTable("BUSINESS_USER", (string)null);
                });

            modelBuilder.Entity("EmployeesAPI.Models.Department", b =>
                {
                    b.Property<string>("DName")
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnType("varchar(120)")
                        .HasColumnName("dName");

                    b.HasKey("DName")
                        .HasName("PK__DEPARTME__112B23CEBEC94EE3");

                    b.ToTable("DEPARTMENT", (string)null);
                });

            modelBuilder.Entity("EmployeesAPI.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("adress");

                    b.Property<DateTime>("BDate")
                        .HasColumnType("date")
                        .HasColumnName("bDate");

                    b.Property<string>("DName")
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnType("varchar(120)")
                        .HasColumnName("dName");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("fname");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(97)
                        .IsUnicode(false)
                        .HasColumnType("varchar(97)")
                        .HasColumnName("lname");

                    b.Property<string>("Mname")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("mname");

                    b.Property<long>("NationalNumber")
                        .HasColumnType("bigint")
                        .HasColumnName("nationalNumber");

                    b.Property<double>("Salary")
                        .HasColumnType("float")
                        .HasColumnName("salary");

                    b.Property<string>("Sex")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("sex")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("DName");

                    b.HasIndex(new[] { "NationalNumber" }, "UQ__EMPLOYEE__C9C4D897E532BEDB")
                        .IsUnique();

                    b.ToTable("EMPLOYEE", (string)null);
                });

            modelBuilder.Entity("EmployeesAPI.Models.Employee", b =>
                {
                    b.HasOne("EmployeesAPI.Models.Department", "DNameNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("DName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK__EMPLOYEE__dName__286302EC");

                    b.Navigation("DNameNavigation");
                });

            modelBuilder.Entity("EmployeesAPI.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
