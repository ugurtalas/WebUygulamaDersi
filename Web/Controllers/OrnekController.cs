using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class OrnekController : Controller
    {
        #region View Ornekleri
        //View Ornekleri
        public IActionResult Index()
        {
            return View();
        }
        [NonAction]
        public IActionResult MailGonder()
        {
            return View("Ornek2");
        }


        public IActionResult FarkliKlasordenVievAc()
        {
            return View("/Views/Home/Privacy.cshtml");
        }

        public IActionResult PartialViewAc()
        {
            return PartialView("Ornek2");
        }
        #endregion

        #region View'e Veri Gonderme Ornekleri
        //View'e veri gönderme örnekleri
        //View Örneği
        public IActionResult ViewBagOrnegi()
        {
            ViewBag.Mesaj = " ViewBag Mesajı !";
            return View("Ornek2");

        }

        //ViewData Örneği

        public IActionResult ViewDataOrnegi()
        {
            OrnekModel Nesne = new OrnekModel();
            Nesne.Ad = "Osman";
            Nesne.No = 6;
            ViewData["OrnekModel"] = Nesne; 
            return View("Ornek2");
        }


        //TempData Örneği
        public IActionResult TempDataOrnegi()
        {
            OrnekModel Nesne = new OrnekModel();
            Nesne.Ad = "Hasan";
            Nesne.No = 6;
            TempData["OrnekModel"] = Nesne;
            return View("Ornek2");
        }

        public IActionResult FarkliActionaYonlenme()
        {
            ViewBag.Ad = "Hasan";
            ViewData["Ad"] = "Osman";
            TempData["Ad"] = "Hüseyin";
            return RedirectToAction("ViewDataTempDataFarki");
        }
        public IActionResult ViewDataTempDataFarki()
        {
            var A1 = ViewBag.Ad;
            var A3 = TempData["Ad"].ToString();
            var A2 = ViewData["Ad"].ToString();
           
            return View("Ornek2");
        }



        //Action içinden Farklı bir Action'a Talepte bulunma 
        //ViewBag, ViewData, TempData farkını gösteren bir örnek

        // Model Döndürme Örneği
        public IActionResult ModelDondurmeOrnegi()
        {
            OrnekModel Nesne = new OrnekModel();
            Nesne.No = 11;
            Nesne.Ad = "Bilecik";
            ViewBag.Mesaj = " ViewBag Mesajı !";
            return View("ModelleCalisanView", Nesne);
        }
        // List Dondurme Ornegi
        public IActionResult ListDondurmeOrnegi()
        {
            List<OrnekModel> Liste = new List<OrnekModel>();
            Liste.Add(new OrnekModel { No =11, Ad="Bilecik" });
            Liste.Add(new OrnekModel { No =34, Ad="İstanbul" });
            Liste.Add(new OrnekModel { No =78, Ad="Karabük" });
            return View("ListIleCalisanView", Liste);
        }
        // Ikı Nesneyi birlestirerek dondurme ornegi

        // Ikınesneyi birlestirme ornegi var lı 
        public IActionResult BirdenFazlaModelDondurme()
        {
            OrnekModel Nesne = new OrnekModel();
            Nesne.No = 11;
            Nesne.Ad = "Bilecik";

            Ornek2Model Nesne2 = new Ornek2Model { No = 11, Aciklama = "BŞEÜ" };

            ViewBag.Nesne1  = Nesne;
            ViewBag.Nesne2  = Nesne2;

            var Cevap = (Nesne, Nesne2);
            return View("IkiModelleCalisanView",Cevap);
        }

        #endregion

        #region Veri Alma Ornekleri

        // Request 
        //query String Örnekleri

        public IActionResult QyeryStringOrnegi(string Ad)
        {
            ViewBag.Mesaj = "Gelen Data : " + Ad;
            return View("Ornek2");
        }

        public IActionResult QyeryStringCoklu(string Ad, string Soyad)
        {
            ViewBag.Mesaj = "Gelen Data : " + Ad + "  "+ Soyad;
            return View("Ornek2");
        }


        public IActionResult QyeryStringModel(OrnekModel Veri)
        {
            ViewBag.Mesaj = "Gelen Data : " + Veri.Ad + "  " + Veri.No;
            return View("Ornek2");
        }

        public IActionResult QyeryStringYakalama()
        {
            ViewBag.Mesaj = Request.Query["Ad"].ToString();
            return View("Ornek2");
        }


        //Routing örnekleri
        public IActionResult DefaultRoutingOrnegi(string Id)
        {
            ViewBag.Mesaj = Id;
            return View("Ornek2");
        }


        [HttpGet]
        [Route("kendirota/{ad?}/{soyad?}")]
        public IActionResult RotingOrnegi(string Ad,string Soyad)
        {
            ViewBag.Mesaj = Ad +"  " + Soyad;
            return View("Ornek2");
        }



        // Form Örnekleri
        [HttpPost]
        public IActionResult PostParametreIleCalisanMetot(int No, string Ad)
        {
            ViewBag.Mesaj = No.ToString() + "  " + Ad;
            return View("Ornek2");
        }



        [HttpPost]
        public IActionResult PostModelIleCalisanMetot(OrnekModel Nesne)
        {
            ViewBag.Mesaj = Nesne.No.ToString() + "  " + Nesne.Ad;
            return View("Ornek2");
        }

        // Binding  İşlemi
        public IActionResult FormaNesneGonder()
        {
            OrnekModel Nesne = new OrnekModel { No = 11, Ad = "BŞEÜ" };
            return View("form",Nesne);
        }

        public IActionResult FormdanNesneAl(OrnekModel Veri)
        {
            ViewBag.Mesaj = Veri.No.ToString() + " " + Veri.Ad;
            return View("Ornek2");
        }

        public IActionResult IformOrnegi(IFormCollection Veri)
        {
            ViewBag.Mesaj = Veri["Ad"].ToString() ;
            return View("Ornek2");
        }

        // JS- Ajax Ornekleri
        public IActionResult AjaxViewAc(IFormCollection Veri)
        {

            return View("Ajax");
        }

        public IActionResult AjaxDeneme()
        {
            return Json("");
        }

        public IActionResult AjaxNesne(OrnekModel Veri)
        {
            return Json("Burdanda veri dondur");
        }
        public IActionResult AjaxNesneDondurme(OrnekModel Veri)
        {
            OrnekModel Nesne = new OrnekModel();
            Nesne.No = 99;
            Nesne.Ad = "dsfdsfsdf";
            return Json(Nesne);
        }


        public IActionResult AjaxViewDondurme(OrnekModel Veri)
        {

            ViewBag.Mesaj = Veri.No.ToString() + "  " + Veri.Ad;
            return PartialView("Ornek2");
        }



        #endregion


        public IActionResult KotegoriListele(OrnekModel Veri)
        {
            return View("Kategori" ,   Islem.Ornek.KategoriGetirTumu());
        }



        // Lİnq  Sorguları 
        public IActionResult TolistOrnek(OrnekModel Veri)
        {

            Islem.Ornek.TolistOrnek();

            return View("Index");
        }
        public IActionResult FirsOrDefaultOrnek(OrnekModel Veri)
        {
            Islem.Ornek.FirsOrDefaultOrnek();
            return View("Index");
        }
        public IActionResult OrderByOrnek (OrnekModel Veri)
        {
            Islem.Ornek.OrderByOrnek();
            return View("Index");
        }
        public IActionResult JoinOrnek(OrnekModel Veri)
        {
            Islem.Ornek.JoinOrnek();
            return View("Index");
        }
        public IActionResult GroupByOrnek(OrnekModel Veri)
        {
            Islem.Ornek.GroupByOrnek();
            return View("Index");
        }
        public IActionResult CountOrnek(OrnekModel Veri)
        {
            Islem.Ornek.CountOrnek();
            return View("Index");
        }

        public IActionResult MinMaxOrnek(OrnekModel Veri)
        {
            Islem.Ornek.MinMaxOrnek();
            return View("Index");
        }
        public IActionResult TakeOrnek(OrnekModel Veri)
        {
            Islem.Ornek.TakeOrnek();
            return View("Index");
        }

        public IActionResult OrnekSorgu(OrnekModel Veri)
        {
            return View("Index");
        }

    }
}
