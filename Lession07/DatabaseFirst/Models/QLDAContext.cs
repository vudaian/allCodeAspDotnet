using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatabaseFirst.Models
{
    public partial class QLDAContext : DbContext
    {
        public QLDAContext()
        {
        }

        public QLDAContext(DbContextOptions<QLDAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhongBan> PhongBans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-517BT7F\\SQLEXPRESS;Database=QLDA;Integrated security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__NhanVien__2725D70ADCC96858");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MaPhong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaPhong)
                    .HasConstraintName("FK__NhanVien__MaPhon__38996AB5");
            });

            modelBuilder.Entity<PhongBan>(entity =>
            {
                entity.HasKey(e => e.MaPhong)
                    .HasName("PK__PhongBan__20BD5E5BBEFBC763");

                entity.ToTable("PhongBan");

                entity.Property(e => e.MaPhong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenPhong)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
