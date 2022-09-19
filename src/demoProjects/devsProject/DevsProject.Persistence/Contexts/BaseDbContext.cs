using DevsProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Persistence.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProgrammingLanguage>(a =>
            {
                a.ToTable("ProgrammingLanguage").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.CreateDate).HasColumnName("CreateDate");
                a.Property(p => p.CreatedBy).HasColumnName("CreatedBy");
                a.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
                a.Property(p => p.UpdatedBy).HasColumnName("UpdatedBy");
                a.Property(p => p.IsActive).HasColumnName("IsActive");
            });

            ProgrammingLanguage[] programmingLanguages = { new(id: 1, name: "C#", createdDate: DateTime.Now, isActive: true, createdBy: "Seed Data"), new(id: 2, name: "Java", createdDate: DateTime.Now, isActive: true, createdBy: "Seed Data") };
            modelBuilder.Entity<ProgrammingLanguage>().HasData(programmingLanguages);
        }


    }
}
