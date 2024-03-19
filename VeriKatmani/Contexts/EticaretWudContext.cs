using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VeriKatmani.Entities;

namespace VeriKatmani.Contexts;

public partial class EticaretWudContext : DbContext
{
    public EticaretWudContext()
    {
    }

    public EticaretWudContext(DbContextOptions<EticaretWudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kategori> Kategori { get; set; }

    public virtual DbSet<Kullanici> Kullanici { get; set; }

    public virtual DbSet<Rol> Rol { get; set; }

    public virtual DbSet<Sepet> Sepet { get; set; }

    public virtual DbSet<Siparis> Siparis { get; set; }

    public virtual DbSet<SiparisDurum> SiparisDurum { get; set; }

    public virtual DbSet<Urun> Urun { get; set; }

    public virtual DbSet<UrunYorum> UrunYorum { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=EticaretWUD;Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kategori>(entity =>
        {
            entity.HasKey(e => e.No).HasName("PK__Kategori__3214D4A88A898B3D");

            entity.Property(e => e.Ad)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Kullanici>(entity =>
        {
            entity.HasKey(e => e.No).HasName("PK__Kullanic__3214D4A8E4527C23");

            entity.Property(e => e.Ad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Eposta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KullaniciAd)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sifre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Soyad)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.RolNoNavigation).WithMany(p => p.Kullanici)
                .HasForeignKey(d => d.RolNo)
                .HasConstraintName("FK__Kullanici__RolNo__398D8EEE");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.No).HasName("PK__Rol__3214D4A8FEDAF8BD");

            entity.Property(e => e.Ad)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sepet>(entity =>
        {
            entity.HasKey(e => e.No).HasName("PK__Sepet__3214D4A8AFC0450E");

            entity.Property(e => e.EklemeTarih).HasColumnType("datetime");

            entity.HasOne(d => d.KullaniciNoNavigation).WithMany(p => p.Sepet)
                .HasForeignKey(d => d.KullaniciNo)
                .HasConstraintName("FK__Sepet__Kullanici__4D94879B");

            entity.HasOne(d => d.UrunNoNavigation).WithMany(p => p.Sepet)
                .HasForeignKey(d => d.UrunNo)
                .HasConstraintName("FK__Sepet__UrunNo__4CA06362");
        });

        modelBuilder.Entity<Siparis>(entity =>
        {
            entity.HasKey(e => e.No).HasName("PK__Siparis__3214D4A8E1CA3226");

            entity.Property(e => e.EklemeTarih).HasColumnType("datetime");

            entity.HasOne(d => d.KullaniciNoNavigation).WithMany(p => p.Siparis)
                .HasForeignKey(d => d.KullaniciNo)
                .HasConstraintName("FK__Siparis__Kullani__48CFD27E");

            entity.HasOne(d => d.SiparisDurumNoNavigation).WithMany(p => p.Siparis)
                .HasForeignKey(d => d.SiparisDurumNo)
                .HasConstraintName("FK__Siparis__Siparis__49C3F6B7");

            entity.HasOne(d => d.UrunNoNavigation).WithMany(p => p.Siparis)
                .HasForeignKey(d => d.UrunNo)
                .HasConstraintName("FK__Siparis__UrunNo__47DBAE45");
        });

        modelBuilder.Entity<SiparisDurum>(entity =>
        {
            entity.HasKey(e => e.No).HasName("PK__SiparisD__3214D4A82879B831");

            entity.Property(e => e.Ad)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Urun>(entity =>
        {
            entity.HasKey(e => e.No).HasName("PK__Urun__3214D4A8D39137A4");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Baslik)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResimYol)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.KategoriNoNavigation).WithMany(p => p.Urun)
                .HasForeignKey(d => d.KategoriNo)
                .HasConstraintName("FK__Urun__KategoriNo__3E52440B");

            entity.HasOne(d => d.KullaniciNoNavigation).WithMany(p => p.Urun)
                .HasForeignKey(d => d.KullaniciNo)
                .HasConstraintName("FK__Urun__KullaniciN__3F466844");
        });

        modelBuilder.Entity<UrunYorum>(entity =>
        {
            entity.HasKey(e => e.No).HasName("PK__UrunYoru__3214D4A8BB69E003");

            entity.Property(e => e.Baslik)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EklemeTarih).HasColumnType("datetime");
            entity.Property(e => e.Yorum)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.KullaniciNoNavigation).WithMany(p => p.UrunYorum)
                .HasForeignKey(d => d.KullaniciNo)
                .HasConstraintName("FK__UrunYorum__Kulla__4316F928");

            entity.HasOne(d => d.UrunNoNavigation).WithMany(p => p.UrunYorum)
                .HasForeignKey(d => d.UrunNo)
                .HasConstraintName("FK__UrunYorum__UrunN__4222D4EF");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
