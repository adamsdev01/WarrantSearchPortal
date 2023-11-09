using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WarrantSearchPortal.Data.Models;

public partial class WarrantPortalDbContext : DbContext
{
    public WarrantPortalDbContext()
    {
    }

    public WarrantPortalDbContext(DbContextOptions<WarrantPortalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<OffenseDescription> OffenseDescriptions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OffenseDescription>(entity =>
        {
            entity.ToTable("OffenseDescription");

            entity.Property(e => e.OffenseDescriptionId).ValueGeneratedNever();
            entity.Property(e => e.CurrentFlag)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.OffenseDefinition)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OffenseName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
