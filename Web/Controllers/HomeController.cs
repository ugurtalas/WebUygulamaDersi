using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View("Index",Islem.UrunListe.AnaSayfaUrunListele());
        }


        public IActionResult IlkController()
        {
            return View("Privacy");
        }


        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        // IactionResult Nedir

        // Bir controllera Talepte Bulunma 
        // Farklı bir view açma
        // bir viewvi partial olarak döndürme

        // View bag döndürme
        // View bag i ekrana yazma

        // Model döndürme
        // Modeli ekrana yazdırdık

        // List tipinde bir model döndürme
        // Listi ekrana yazdırma 

        // Bi değişken alan  Id
        // Birden fazla değişken alan
        // Model alan
    }
}