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




        // Linq örnekler

        public static void TolistOrnek()
        {
            EticaretWudContext Model = new EticaretWudContext();
            var Liste = Model.Kategori.Where(q=> q.No>1 ).Select(s=> new { KategoriAd = s.Ad  }).ToList();
            var Liste2 = Model.Kategori.Where(q=> q.No>1 ).ToList();


        }
        public static void FirsOrDefaultOrnek()
        {
            EticaretWudContext Model = new EticaretWudContext();

            var Nesne = Model.Kategori.FirstOrDefault();

            var Nesne2 = Model.Kategori.FirstOrDefault(f=> f.No == 2);


            var Nesne3 = Model.Kategori.FirstOrDefault(f=> f.No == 2).Ad;


        


       

        }
        public static void OrderByOrnek()
        {
            EticaretWudContext Model = new EticaretWudContext();
            var Liste = Model.Kategori.ToList().OrderBy(o=> o.Ad);
            var Liste2 = Model.Kategori.ToList().OrderByDescending(o=> o.Ad);
        }
        public static void JoinOrnek()
        {
            EticaretWudContext Model = new EticaretWudContext();


            // Linq Metot
            var UrunList = Model.Urun.Select(s=> new { UrunBaslik = s.Baslik , KategoriAd = s.KategoriNoNavigation.Ad  }).ToList();


            // Linq Query
            var UrunList2 = from u in Model.Urun
                            join k in Model.Kategori on u.KategoriNo equals k.No
                            where k.No == 2
                            select new
                            {
                                u.Baslik,
                                k.Ad
                            };


            // Mixed 
            var UrunList3 = (from u in Model.Urun
                             join k in Model.Kategori on u.KategoriNo equals k.No
                             select new
                             {
                                 u.Baslik,
                                 k.Ad
                             }).ToList();

        }
        public static void GroupByOrnek()
        {
            EticaretWudContext Model = new EticaretWudContext();

            var UrunList = Model.Urun.Select(s => new { UrunBaslik = s.Baslik, KategoriAd = s.KategoriNoNavigation.Ad }).
                ToList().GroupBy(g => g.KategoriAd).ToList();

        }
        public static void CountOrnek()
        {
            EticaretWudContext Model = new EticaretWudContext();
            var Liste = Model.Kategori.ToList().Count(); 
        }

        public static void MinMaxOrnek()
        {
            EticaretWudContext Model = new EticaretWudContext();
            var Listemin = Model.Urun.ToList().Max(m=> m.Fiyat);
            var Listemax = Model.Urun.ToList().Min(m => m.Fiyat);
        }
        public static void TakeOrnek()
        {
            EticaretWudContext Model = new EticaretWudContext();
            var Listemin = Model.Urun.ToList().Take(2);
        }

        public static void OrnekSorgu()
        {
            //
        }



    }
}


