using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Buoi6.DAL.Models;

public partial class QlthongTinSvContext : DbContext
{
    public QlthongTinSvContext()
    {
    }

    public QlthongTinSvContext(DbContextOptions<QlthongTinSvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Major> Majors { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=QUOCDAT\\SQLEXPRESS;Initial Catalog=QLThongTinSV;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.ToTable("FACULTY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Major>(entity =>
        {
            entity.ToTable("MAJOR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");

            entity.HasOne(d => d.Faculty).WithMany(p => p.Majors)
                .HasForeignKey(d => d.Facultyid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAJOR_FACULTY");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Avatar)
                .HasMaxLength(155)
                .HasColumnName("AVATAR");
            entity.Property(e => e.Averagescore).HasColumnName("AVERAGESCORE");
            entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");
            entity.Property(e => e.Majorid).HasColumnName("MAJORID");
            entity.Property(e => e.Mssv)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("MSSV");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");

            entity.HasOne(d => d.Faculty).WithMany(p => p.Students)
                .HasForeignKey(d => d.Facultyid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_FACULTY1");

            entity.HasOne(d => d.Major).WithMany(p => p.Students)
                .HasForeignKey(d => d.Majorid)
                .HasConstraintName("FK_Student_MAJOR");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
