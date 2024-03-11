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

        //TempData Örneği

        //Action içinden Farklı bir Action'a Talepte bulunma 
            //ViewBag, ViewData, TempData farkını gösteren bir örnek

        // Model Döndürme Örneği
        public IActionResult ModelDondurmeOrnegi()
        {
            Kategori Nesne = new Kategori();
            Nesne.No = 11;
            Nesne.Ad = "Bilecik";
            ViewBag.Mesaj = " ViewBag Mesajı !";
            return View("ModelleCalisanView", Nesne);
        }


        // List Dondurme Ornegi
        public IActionResult ListDondurmeOrnegi()
        {
            List<Kategori> Liste = new List<Kategori>();
            Liste.Add(new Kategori { No =11, Ad="Bilecik" });
            Liste.Add(new Kategori { No =34, Ad="İstanbul" });
            Liste.Add(new Kategori { No =78, Ad="Karabük" });
            return View("ListIleCalisanView", Liste);
        }
        // Ikı Nesneyi birlestirerek dondurme ornegi

        // Ikınesneyi birlestirme ornegi var lı 


        #endregion

        #region Veri Alma Ornekleri
        // Parametre alma / veri alma örnekleri

        // Form Örnekleri


        // Binding  İşlemi

        //query String Örnekleri

        //Routing örnekleri

        // JS- Ajax Ornekleri
        public IActionResult ParametreIleCalisanMetot(string Id)
        {
            ViewBag.Mesaj = "Gelen Id  : " + Id;
            return View("Ornek2");
        }



        [HttpPost]
        public IActionResult PostParametreIleCalisanMetot(int No , string Ad)
        {
            ViewBag.Mesaj = No.ToString() +"  "+  Ad;
            return View("Ornek2");
        }


        [HttpPost]
        public IActionResult PostModelIleCalisanMetot(Kategori  Nesne)
        {
            ViewBag.Mesaj = Nesne.No.ToString() + "  " + Nesne.Ad;
            return View("Ornek2");
        }

        #endregion


    }
}
