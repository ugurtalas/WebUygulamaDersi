using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriKatmani.Contexts;

namespace Islem
{
    public class UrunListe
    {
        public static List<DTO.Reponse.UrunBilgileri> AnaSayfaUrunListele()
        {
            EticaretWudContext Model = new EticaretWudContext ();
            List<DTO.Reponse.UrunBilgileri>  Liste = Model.Urun.Select(s=> new DTO.Reponse.UrunBilgileri { 
                        No=s.No,
                        Baslik= s.Baslik,
                        Fiyat= s.Fiyat.Value,
                        ResimYol=s.ResimYol
                    
                    }).ToList();
            return Liste;
        }
    }
}
