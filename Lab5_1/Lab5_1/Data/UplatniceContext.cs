using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Lab5_1.Models;

namespace Lab5_1.Data
{
    public partial class UplatniceContext : DbContext
    {
        public UplatniceContext()
        {
        }

        public UplatniceContext(DbContextOptions<UplatniceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Uplatnica> Uplatnicas { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Uplatnica>(entity =>
            {
                entity.ToTable("Uplatnica");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
