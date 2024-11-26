using Microsoft.AspNetCore.Mvc;
using OgrenciDersYonetimSistemiMVC.Models;
using System.Collections.Generic;

namespace OgrenciDersYonetimSistemiMVC.Controllers
{
    public class HomeController : Controller
    {
        private static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        private static List<OgretimGorevlisi> ogretimGorevlileri = new List<OgretimGorevlisi>();
        private static List<Ders> dersler = new List<Ders>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OgrenciEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci ogrenci)
        {
            ogrenciler.Add(ogrenci);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult OgretimGorevlisiEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OgretimGorevlisiEkle(OgretimGorevlisi ogretimGorevlisi)
        {
            ogretimGorevlileri.Add(ogretimGorevlisi);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DersEkle()
        {
            ViewBag.OgretimGorevlileri = ogretimGorevlileri;
            return View();
        }

        [HttpPost]
        public IActionResult DersEkle(Ders ders, int ogretimGorevlisiId)
        {
            ders.OgretimGorevlisi = ogretimGorevlileri.Find(og => og.Id == ogretimGorevlisiId);
            dersler.Add(ders);
            return RedirectToAction("Index");
        }

        public IActionResult OgrencileriListele()
        {
            return View(ogrenciler);
        }

        public IActionResult OgretimGorevlileriniListele()
        {
            return View(ogretimGorevlileri);
        }

        public IActionResult DersleriListele()
        {
            return View(dersler);
        }
    }
}