using System;
using System.Collections.Generic;

namespace VeriKatmani.Entities;

public partial class Sepet
{
    public int No { get; set; }

    public int? UrunNo { get; set; }

    public int? KullaniciNo { get; set; }

    public DateTime? EklemeTarih { get; set; }

    public virtual Kullanici? KullaniciNoNavigation { get; set; }

    public virtual Urun? UrunNoNavigation { get; set; }
}
