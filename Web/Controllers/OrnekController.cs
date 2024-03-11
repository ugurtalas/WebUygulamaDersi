using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class OrnekController : Controller
    {

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

        public IActionResult ViewBagOrnegi()
        {
            ViewBag.Mesaj = " ViewBag Mesajı !";
            return View("Ornek2");
        }

        public IActionResult ModelDondurmeOrnegi()
        {
            Kategori Nesne = new Kategori();
            Nesne.No = 11;
            Nesne.Ad = "Bilecik";
            ViewBag.Mesaj = " ViewBag Mesajı !";
            return View("ModelleCalisanView", Nesne);
        }

        public IActionResult ListDondurmeOrnegi()
        {

            List<Kategori> Liste = new List<Kategori>();

            Liste.Add(new Kategori { No =11, Ad="Bilecik" });
            Liste.Add(new Kategori { No =34, Ad="İstanbul" });
            Liste.Add(new Kategori { No =78, Ad="Karabük" });

            return View("ListIleCalisanView", Liste);
        }

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

        //3. Hafta
        //1- Birden fazla model dönebiliyor muyuz.
        //2- Generic model oluşturalım
        //3- Jquery ile  selector.
            // class, Id, Attr, Value, Click, Change,
            // Ajax post form 
            // Ajax post class
            // JS içersinde break point koyma
        //4- Route işlemleri
        //5- 
        


    }
}
