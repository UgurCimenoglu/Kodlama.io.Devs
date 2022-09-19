﻿// <auto-generated />
using System;
using DevsProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevsProject.Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20220919010131_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DevsProject.Domain.Entities.ProgrammingLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CreatedBy");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("ProgrammingLanguage", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2022, 9, 19, 4, 1, 31, 302, DateTimeKind.Local).AddTicks(909),
                            CreatedBy = "Seed Data",
                            IsActive = true,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2022, 9, 19, 4, 1, 31, 302, DateTimeKind.Local).AddTicks(919),
                            CreatedBy = "Seed Data",
                            IsActive = true,
                            Name = "Java"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
