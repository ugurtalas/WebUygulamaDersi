using System;
using System.Collections.Generic;

namespace VeriKatmani.Entities;

public partial class Urun
{
    public int No { get; set; }

    public string? Baslik { get; set; }

    public string? Aciklama { get; set; }

    public string? ResimYol { get; set; }

    public int? Fiyat { get; set; }

    public int? Stok { get; set; }

    public int? KategoriNo { get; set; }

    public int? KullaniciNo { get; set; }

    public virtual Kategori? KategoriNoNavigation { get; set; }

    public virtual Kullanici? KullaniciNoNavigation { get; set; }

    public virtual ICollection<Sepet> Sepet { get; set; } = new List<Sepet>();

    public virtual ICollection<Siparis> Siparis { get; set; } = new List<Siparis>();

    public virtual ICollection<UrunYorum> UrunYorum { get; set; } = new List<UrunYorum>();
}
