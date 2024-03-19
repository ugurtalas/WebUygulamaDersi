using System;
using System.Collections.Generic;

namespace VeriKatmani.Entities;

public partial class Kategori
{
    public int No { get; set; }

    public string? Ad { get; set; }


    public virtual ICollection<Urun> Urun { get; set; } = new List<Urun>();
}
