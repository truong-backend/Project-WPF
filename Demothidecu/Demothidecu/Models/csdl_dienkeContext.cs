using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Demothidecu.Models
{
    public partial class csdl_dienkeContext : DbContext
    {
        public csdl_dienkeContext()
        {
        }

        public csdl_dienkeContext(DbContextOptions<csdl_dienkeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dienke> Dienkes { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Kysudung> Kysudungs { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Sudungdien> Sudungdiens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NCV4I29\\SQLSERVER;Initial Catalog=demoThi;Integrated Security=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Dienke>(entity =>
            {
                entity.HasKey(e => e.Madk);

                entity.ToTable("dienke");

                entity.Property(e => e.Madk)
                    .HasMaxLength(50)
                    .HasColumnName("madk");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("makh");

                entity.Property(e => e.Ngaydk)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaydk");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.Dienkes)
                    .HasForeignKey(d => d.Makh)
                    .HasConstraintName("FK_dienke_khachhang");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Makh);

                entity.ToTable("khachhang");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("makh");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("dienthoai");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(50)
                    .HasColumnName("tenkh");
            });

            modelBuilder.Entity<Kysudung>(entity =>
            {
                entity.HasKey(e => e.Maky);

                entity.ToTable("kysudung");

                entity.Property(e => e.Maky)
                    .HasMaxLength(10)
                    .HasColumnName("maky");

                entity.Property(e => e.Denngay)
                    .HasColumnType("datetime")
                    .HasColumnName("denngay");

                entity.Property(e => e.Tungay)
                    .HasColumnType("datetime")
                    .HasColumnName("tungay");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manv);

                entity.ToTable("nhanvien");

                entity.Property(e => e.Manv)
                    .HasMaxLength(50)
                    .HasColumnName("manv");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("dienthoai");

                entity.Property(e => e.Tennv)
                    .HasMaxLength(50)
                    .HasColumnName("tennv");
            });

            modelBuilder.Entity<Sudungdien>(entity =>
            {
                entity.HasKey(e => new { e.Maky, e.Madk });

                entity.ToTable("sudungdien");

                entity.Property(e => e.Maky)
                    .HasMaxLength(10)
                    .HasColumnName("maky");

                entity.Property(e => e.Madk)
                    .HasMaxLength(50)
                    .HasColumnName("madk");

                entity.Property(e => e.Chisocu).HasColumnName("chisocu");

                entity.Property(e => e.Chisomoi).HasColumnName("chisomoi");

                entity.Property(e => e.Manv)
                    .HasMaxLength(50)
                    .HasColumnName("manv");

                entity.HasOne(d => d.MadkNavigation)
                    .WithMany(p => p.Sudungdiens)
                    .HasForeignKey(d => d.Madk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sudungdien_dienke");

                entity.HasOne(d => d.MakyNavigation)
                    .WithMany(p => p.Sudungdiens)
                    .HasForeignKey(d => d.Maky)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sudungdien_kysudung");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Sudungdiens)
                    .HasForeignKey(d => d.Manv)
                    .HasConstraintName("FK_sudungdien_nhanvien");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
