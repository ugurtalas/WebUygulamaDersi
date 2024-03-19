using System;
using System.Collections.Generic;

namespace VeriKatmani.Entities;

public partial class Siparis
{
    public int No { get; set; }

    public int? UrunNo { get; set; }

    public int? KullaniciNo { get; set; }

    public int? SiparisDurumNo { get; set; }

    public int? Fiyat { get; set; }

    public DateTime? EklemeTarih { get; set; }

    public virtual Kullanici? KullaniciNoNavigation { get; set; }

    public virtual SiparisDurum? SiparisDurumNoNavigation { get; set; }

    public virtual Urun? UrunNoNavigation { get; set; }
}
