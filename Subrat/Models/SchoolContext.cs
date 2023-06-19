using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Subrat.Models;

public partial class SchoolContext : DbContext
{
    public SchoolContext()
    {
    }

    public SchoolContext(DbContextOptions<SchoolContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Marksheet> Marksheets { get; set; }

    public virtual DbSet<StudentDetail> StudentDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=School;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Marksheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Markshee__3213E83F2F0D79A2");

            entity.ToTable("Marksheet");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.SidNavigation).WithMany(p => p.Marksheets)
                .HasForeignKey(d => d.Sid)
                .HasConstraintName("FK__Marksheet__Sid__3B75D760");
        });

        modelBuilder.Entity<StudentDetail>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__StudentD__CA1E5D783D185DF0");

            entity.Property(e => e.Address)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Dob).HasColumnType("date");
            entity.Property(e => e.Fname)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Lname)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Parentsname)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
