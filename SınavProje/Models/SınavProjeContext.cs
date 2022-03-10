using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SınavProje.Models
{
    public partial class SınavProjeContext : DbContext
    {
        public SınavProjeContext()
        {
        }

        public SınavProjeContext(DbContextOptions<SınavProjeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EgitmenGirisTbl> EgitmenGirisTbls { get; set; }
        public virtual DbSet<KategoriTbl> KategoriTbls { get; set; }
        public virtual DbSet<OgrenciGirisTbl> OgrenciGirisTbls { get; set; }
        public virtual DbSet<SoruTbl> SoruTbls { get; set; }
        public virtual DbSet<SınavTbl> SınavTbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SınavProje;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EgitmenGirisTbl>(entity =>
            {
                entity.ToTable("EgitmenGiris_TBL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EgitmenMail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<KategoriTbl>(entity =>
            {
                entity.ToTable("Kategori_TBL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KategoriAdi)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<OgrenciGirisTbl>(entity =>
            {
                entity.ToTable("OgrenciGiris_TBL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OgrenciMail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SoruTbl>(entity =>
            {
                entity.ToTable("Soru_TBL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KategoriId).HasColumnName("KategoriID");

                entity.Property(e => e.Soru)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Sık)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SınavId).HasColumnName("SınavID");

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.SoruTbls)
                    .HasForeignKey(d => d.KategoriId)
                    .HasConstraintName("FK_Soru_TBL_Kategori_TBL");

                entity.HasOne(d => d.Sınav)
                    .WithMany(p => p.SoruTbls)
                    .HasForeignKey(d => d.SınavId)
                    .HasConstraintName("FK_Soru_TBL_Sınav_TBL");
            });

            modelBuilder.Entity<SınavTbl>(entity =>
            {
                entity.ToTable("Sınav_TBL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SınavAcıklaması)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SınavAdı)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
