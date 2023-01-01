using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebProje2.Models.Siniflar;

namespace WebProje2.Controllers
{
    
    public class CariPanelController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {        
            var degerler = c.Mesajlars.Where(x => x.Alici == User.Identity.Name).ToList();
            var mailid = c.Carilers.Where(x => x.CariMail == User.Identity.Name).Select(y => y.CarilerID).FirstOrDefault();          
            var toplamsatis = c.SatisHarekets.Where(x => x.CarilerID == mailid).Count();
            ViewBag.d1 = toplamsatis;
            var toplamtutar = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.ToplamTutar);
            ViewBag.d2 = toplamtutar;
            var urunsayisi = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.Adet);
            ViewBag.d3 = urunsayisi;
            var adsoyad = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariAd + " " + y.CariSoyad).FirstOrDefault();
            ViewBag.d4 = adsoyad;
            var sehir = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariSehir).FirstOrDefault();
            ViewBag.d5 = sehir;
            try
            {
                string api = "9d3320c73686303f5299eae51ad9435f";
                string connection = "http://api.openweathermap.org/data/2.5/weather?q=" + sehir + "&mode=xml&lang=tr&units=metric&appid=" + api;
                XDocument document = XDocument.Load(connection);
                ViewBag.d6 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                ViewBag.d7 = document.Descendants("weather").ElementAt(0).Attribute("value").Value;
                ViewBag.d8 = document.Descendants("lastupdate").ElementAt(0).Attribute("value").Value;
            }
            catch (Exception ex)
            {

              
            }

            return View(degerler);
        }
        [Authorize]
        public IActionResult IndexEN()
        {
            var degerler = c.Mesajlars.Where(x => x.Alici == User.Identity.Name).ToList();
            var mailid = c.Carilers.Where(x => x.CariMail == User.Identity.Name).Select(y => y.CarilerID).FirstOrDefault();
            var toplamsatis = c.SatisHarekets.Where(x => x.CarilerID == mailid).Count();
            ViewBag.d1 = toplamsatis;
            var toplamtutar = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.ToplamTutar);
            ViewBag.d2 = toplamtutar;
            var urunsayisi = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.Adet);
            ViewBag.d3 = urunsayisi;
            var adsoyad = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariAd + " " + y.CariSoyad).FirstOrDefault();
            ViewBag.d4 = adsoyad;
            var sehir = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariSehir).FirstOrDefault();
            ViewBag.d5 = sehir;
            string api = "9d3320c73686303f5299eae51ad9435f";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=" + sehir + "&mode=xml&lang=en&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.d6 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.d7 = document.Descendants("weather").ElementAt(0).Attribute("value").Value;
            ViewBag.d8 = document.Descendants("lastupdate").ElementAt(0).Attribute("value").Value;
            return View(degerler);
        }
        [Authorize]
        public IActionResult Siparislerim()
        {
            var user = User.Identity.Name;
            var id = c.Carilers.Where(x => x.CariMail == user).Select(y => y.CarilerID).FirstOrDefault();
            var degerler = c.SatisHarekets
                .Include(x=>x.Urun)
                .Include(x=>x.Personel)
                .Where(x => x.CarilerID == id).ToList();
            return View(degerler);
        }
        [Authorize]
        public IActionResult SiparislerimEN()
        {
            var user = User.Identity.Name;
            var id = c.Carilers.Where(x => x.CariMail == user).Select(y => y.CarilerID).FirstOrDefault();
            var degerler = c.SatisHarekets
                .Include(x => x.Urun)
                .Include(x => x.Personel)
                .Where(x => x.CarilerID == id).ToList();
            return View(degerler);
        }
        [Authorize]
        public IActionResult GelenMesajlar()
        {
            var mail = User.Identity.Name;
            var mesajlar = c.Mesajlars.Where(x=>x.Alici==mail).OrderByDescending(x=>x.MesajlarID).ToList();
            var gelenSayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
            ViewBag.gelenSayisi = gelenSayisi;
            var gidenSayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
            ViewBag.gidenSayisi = gidenSayisi;
            return View(mesajlar);
        }
        [Authorize]
        public IActionResult GelenMesajlarEN()
        {
            var mail = User.Identity.Name;
            var mesajlar = c.Mesajlars.Where(x => x.Alici == mail).OrderByDescending(x => x.MesajlarID).ToList();
            var gelenSayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
            ViewBag.gelenSayisi = gelenSayisi;
            var gidenSayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
            ViewBag.gidenSayisi = gidenSayisi;
            return View(mesajlar);
        }
        [Authorize]
        public IActionResult GidenMesajlar()
        {
            var mail = User.Identity.Name;
            var mesajlar = c.Mesajlars.Where(x => x.Gonderici == mail).OrderByDescending(x => x.MesajlarID).ToList();
            var gelenSayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
            ViewBag.gelenSayisi = gelenSayisi;
            var gidenSayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
            ViewBag.gidenSayisi = gidenSayisi;
            return View(mesajlar);
        }
        [Authorize]
        public IActionResult GidenMesajlarEN()
        {
            var mail = User.Identity.Name;
            var mesajlar = c.Mesajlars.Where(x => x.Gonderici == mail).OrderByDescending(x => x.MesajlarID).ToList();
            var gelenSayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
            ViewBag.gelenSayisi = gelenSayisi;
            var gidenSayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
            ViewBag.gidenSayisi = gidenSayisi;
            return View(mesajlar);
        }
        [Authorize]
        [HttpGet]
        public IActionResult YeniMesaj()
        {
            var mail = User.Identity.Name;
            var gelenSayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
            ViewBag.gelenSayisi = gelenSayisi;
            var gidenSayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
            ViewBag.gidenSayisi = gidenSayisi;
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult YeniMesaj(Mesajlar d)
        {
            try
            {
                d.Gonderici = User.Identity.Name;
                d.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
                c.Mesajlars.Add(d);
                c.SaveChanges();
                TempData["sended"] = "Mail başarıyla gönderildi.";
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult YeniMesajEN()
        {
         
            var mail = User.Identity.Name;
            var gelenSayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
            ViewBag.gelenSayisi = gelenSayisi;
            var gidenSayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
            ViewBag.gidenSayisi = gidenSayisi;
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult YeniMesajEN(Mesajlar d)
        {
            try
            {
                d.Gonderici = User.Identity.Name;
                d.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
                c.Mesajlars.Add(d);
                c.SaveChanges();
                TempData["sended"] = "Mail has been sent successfully.";
                return View();
            }
            catch (Exception)
            {

                throw;
            }

        }
        [Authorize]
        public IActionResult MesajDetay(int id)
        {
            var degerler = c.Mesajlars.Where(x => x.MesajlarID == id).ToList();
            var mail = User.Identity.Name;
            var gelenSayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
            ViewBag.gelenSayisi = gelenSayisi;
            var gidenSayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
            ViewBag.gidenSayisi = gidenSayisi;
            return View(degerler);
        }
        [Authorize]
        public IActionResult MesajDetayEN(int id)
        {
            var degerler = c.Mesajlars.Where(x => x.MesajlarID == id).ToList();
            var mail = User.Identity.Name;
            var gelenSayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
            ViewBag.gelenSayisi = gelenSayisi;
            var gidenSayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
            ViewBag.gidenSayisi = gidenSayisi;
            return View(degerler);
        }
        [Authorize]
        public IActionResult KargoTakip()
        {
            var degerler = c.KargoDetays.Where(x => x.Alici==User.Identity.Name).ToList();
            return View(degerler);
        }
        [Authorize]
        public IActionResult KargoTakipEN()
        {
            var degerler = c.KargoDetays.Where(x => x.Alici == User.Identity.Name).ToList();
            return View(degerler);
        }
        [Authorize]
        public ActionResult KargoDetay(string id)
        {
            var degerler = c.KargoDetays.Where(x => x.TakipKodu == id).ToList();
            ViewBag.takipkodu = id;
            return View(degerler);
        }
        [Authorize]
        public ActionResult KargoDetayEN(string id)
        {
            var degerler = c.KargoDetays.Where(x => x.TakipKodu == id).ToList();
            ViewBag.takipkodu = id;
            return View(degerler);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> LogOutEN()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
        public IActionResult CariBilgilerim()
        {
            var mailid = c.Carilers.Where(x => x.CariMail == User.Identity.Name).Select(y => y.CarilerID).FirstOrDefault();
            var toplamsatis = c.SatisHarekets.Where(x => x.CarilerID == mailid).Count();
            ViewBag.d1 = toplamsatis;
            var toplamtutar = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.ToplamTutar);
            ViewBag.d2 = toplamtutar;
            var urunsayisi = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.Adet);
            ViewBag.d3 = urunsayisi;
            var adsoyad = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariAd + " " + y.CariSoyad).FirstOrDefault();
            ViewBag.d4 = adsoyad;
            var sehir = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariSehir).FirstOrDefault();
            ViewBag.d5 = sehir;
            var id = c.Carilers.Where(x => x.CariMail == User.Identity.Name).Select(y => y.CarilerID).FirstOrDefault();
            var caribul = c.Carilers.Find(id);
            return View("CariBilgilerim",caribul);
        }
        public IActionResult CariBilgilerimEN()
        {
            var mailid = c.Carilers.Where(x => x.CariMail == User.Identity.Name).Select(y => y.CarilerID).FirstOrDefault();
            var toplamsatis = c.SatisHarekets.Where(x => x.CarilerID == mailid).Count();
            ViewBag.d1 = toplamsatis;
            var toplamtutar = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.ToplamTutar);
            ViewBag.d2 = toplamtutar;
            var urunsayisi = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.Adet);
            ViewBag.d3 = urunsayisi;
            var adsoyad = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariAd + " " + y.CariSoyad).FirstOrDefault();
            ViewBag.d4 = adsoyad;
            var sehir = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariSehir).FirstOrDefault();
            ViewBag.d5 = sehir;
            var id = c.Carilers.Where(x => x.CariMail == User.Identity.Name).Select(y => y.CarilerID).FirstOrDefault();
            var caribul = c.Carilers.Find(id);
            return View("CariBilgilerimEN", caribul);
        }
        public IActionResult Duyurular()
        {
            var mailid = c.Carilers.Where(x => x.CariMail == User.Identity.Name).Select(y => y.CarilerID).FirstOrDefault();
            var toplamsatis = c.SatisHarekets.Where(x => x.CarilerID == mailid).Count();
            ViewBag.d1 = toplamsatis;
            var toplamtutar = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.ToplamTutar);
            ViewBag.d2 = toplamtutar;
            var urunsayisi = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.Adet);
            ViewBag.d3 = urunsayisi;
            var adsoyad = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariAd + " " + y.CariSoyad).FirstOrDefault();
            ViewBag.d4 = adsoyad;
            var sehir = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariSehir).FirstOrDefault();
            ViewBag.d5 = sehir;
            var veriler = c.Mesajlars.Where(x => x.Gonderici == "admin").ToList();
            return View(veriler);
        }
        public IActionResult DuyurularEN()
        {
            var mailid = c.Carilers.Where(x => x.CariMail == User.Identity.Name).Select(y => y.CarilerID).FirstOrDefault();
            var toplamsatis = c.SatisHarekets.Where(x => x.CarilerID == mailid).Count();
            ViewBag.d1 = toplamsatis;
            var toplamtutar = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.ToplamTutar);
            ViewBag.d2 = toplamtutar;
            var urunsayisi = c.SatisHarekets.Where(x => x.CarilerID == mailid).Sum(y => y.Adet);
            ViewBag.d3 = urunsayisi;
            var adsoyad = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariAd + " " + y.CariSoyad).FirstOrDefault();
            ViewBag.d4 = adsoyad;
            var sehir = c.Carilers.Where(x => x.CarilerID == mailid).Select(y => y.CariSehir).FirstOrDefault();
            ViewBag.d5 = sehir;
            var veriler = c.Mesajlars.Where(x => x.Gonderici == "admin").ToList();
            return View(veriler);
        }
        public IActionResult BilgilerimiGuncelle(Cariler cr)
        {
            var cari = c.Carilers.Find(cr.CarilerID);
            cari.CariAd = cr.CariAd;
            cari.CariSoyad = cr.CariSoyad;
            cari.Sifre = cr.Sifre;
            cari.CariSehir = cr.CariSehir;
            cari.Dil = cr.Dil;
            c.SaveChanges();
            if (cr.Dil == "Türkçe")
            {
                return RedirectToAction("Index");
            }
            {
                return RedirectToAction("IndexEN");
            }
        }
        public IActionResult BilgilerimiGuncelleEN(Cariler cr)
        {
            var cari = c.Carilers.Find(cr.CarilerID);
            cari.CariAd = cr.CariAd;
            cari.CariSoyad = cr.CariSoyad;
            cari.Sifre = cr.Sifre;
            cari.CariSehir = cr.CariSehir;
            cari.Dil = cr.Dil;
            c.SaveChanges();
            if (cr.Dil == "Türkçe") 
            {
                return RedirectToAction("Index");
            }
            {
                return RedirectToAction("IndexEN");
            }
            
        }
    }
}
