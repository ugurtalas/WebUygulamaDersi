using VeriKatmani.Contexts;
using VeriKatmani.Entities;

namespace Islem
{
    public class Ornek
    {
        public static void KategoriEkle()
        {
            EticaretWudContext Model = new EticaretWudContext();
            Kategori Nesne = new Kategori();
            Nesne.Ad = "Tablet";
            Model.Kategori.Add(Nesne);
            Model.SaveChanges();
        }

        public static List<Kategori> KategoriGetirTumu()
        {
            EticaretWudContext Model = new EticaretWudContext();

            var denem = Model.Urun.Max(m => m.Fiyat);
            var denem2 = Model.Urun.Select(s => new { s.Baslik, s.KategoriNoNavigation.Ad }).ToList(); 
            var denem3 = from u in Model.Urun
                         join k in Model.Kategori on u.KategoriNo equals k.No

                         where k.No== 2
                         select new {  u.Baslik , k.Ad } ;


            var denem4 = (from u in Model.Urun
                         join k in Model.Kategori on u.KategoriNo equals k.No

                         where k.No == 2
                         select new { u.Baslik, k.Ad }).ToList();


            List< Kategori > Liste = Model.Kategori.ToList();
            return Liste;
        }

        public static Kategori KategoriGetir(int No)
        {
            EticaretWudContext Model = new EticaretWudContext();
            Kategori Nesne = Model.Kategori.Where(q => q.No == No).FirstOrDefault();
            return Nesne;
        }


        public static Kategori KategoriGuncelle(int No)
        {
            EticaretWudContext Model = new EticaretWudContext();
            Kategori Nesne = Model.Kategori.Where(q => q.No == No).FirstOrDefault();
            Nesne.Ad = Nesne.Ad + " Guncellendi";
            Model.SaveChanges();
            return Nesne;
        }


        public static void KategoriSil(int No)
        {
            EticaretWudContext Model = new EticaretWudContext();
            Kategori Nesne = Model.Kategori.Where(q => q.No == No).FirstOrDefault();
            Model.Kategori.Remove(Nesne);
            Model.SaveChanges();
        }


    }
}


