using System;
using System.Collections.Generic;

namespace VeriKatmani.Entities;

public partial class Kullanici
{
    public int No { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? KullaniciAd { get; set; }

    public string? Sifre { get; set; }

    public string? Eposta { get; set; }

    public string? Adres { get; set; }

    public int? RolNo { get; set; }

    public virtual Rol? RolNoNavigation { get; set; }

    public virtual ICollection<Sepet> Sepet { get; set; } = new List<Sepet>();

    public virtual ICollection<Siparis> Siparis { get; set; } = new List<Siparis>();

    public virtual ICollection<Urun> Urun { get; set; } = new List<Urun>();

    public virtual ICollection<UrunYorum> UrunYorum { get; set; } = new List<UrunYorum>();
}
