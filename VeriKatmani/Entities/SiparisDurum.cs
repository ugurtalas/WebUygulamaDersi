using System;
using System.Collections.Generic;

namespace VeriKatmani.Entities;

public partial class SiparisDurum
{
    public int No { get; set; }

    public string? Ad { get; set; }

    public virtual ICollection<Siparis> Siparis { get; set; } = new List<Siparis>();
}
