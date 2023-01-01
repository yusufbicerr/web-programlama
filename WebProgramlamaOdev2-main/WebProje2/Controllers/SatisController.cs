using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProje2.Models.Siniflar;

namespace WebProje2.Controllers
{
    [Authorize(Roles = "A,B")]
    public class SatisController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.SatisHarekets
                .Include(x => x.Personel)
                .Include(x=>x.Urun)
                .Include(x => x.Cariler)
                .ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            List<SelectListItem> deger1 = (from x in c.Uruns.Where(x => x.Durum == true).ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.UrunAd,
                                               Value = x.UrunID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            List<SelectListItem> deger2 = (from x in c.Carilers.Where(x=>x.Durum==true).ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CariAd+ " "+x.CariSoyad,
                                               Value = x.CarilerID.ToString()
                                           }).ToList();
            ViewBag.dgr2 = deger2;
            List<SelectListItem> deger3 = (from x in c.Personels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAd+ " "+x.PersonelSoyad,
                                               Value = x.PersonelID.ToString()
                                           }).ToList();
            ViewBag.dgr3 = deger3;

            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(SatisHareket s)
        {
            var urun = c.Uruns.Include(x => x.Kategori).Where(x => x.Durum == true && x.UrunID==s.Urunid).ToList();
            if(urun[0].Stok<s.Adet)
            {
                TempData["SaleError"] = "Ürünün yeterli stoğu bulunmamaktadır. Satış işlemi yapılmamıştır.";
                return RedirectToAction("Index");
            }
            else
            {
                urun[0].Stok -= Convert.ToInt16(s.Adet);
                Urun yeniUrun = new Urun();
                yeniUrun = urun[0];
                c.Uruns.Update(yeniUrun);
                c.SatisHarekets.Add(s);
                s.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
                c.SaveChanges();
                return RedirectToAction("Index");
            }
            
        }
        public ActionResult SatisGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Uruns.Where(x => x.Durum == true).ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.UrunAd,
                                               Value = x.UrunID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            List<SelectListItem> deger2 = (from x in c.Carilers.Where(x => x.Durum == true).ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CariAd + " " + x.CariSoyad,
                                               Value = x.CarilerID.ToString()
                                           }).ToList();
            ViewBag.dgr2 = deger2;
            List<SelectListItem> deger3 = (from x in c.Personels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAd + " " + x.PersonelSoyad,
                                               Value = x.PersonelID.ToString()
                                           }).ToList();
            ViewBag.dgr3 = deger3;
            var deger = c.SatisHarekets.Find(id);
            return View("SatisGetir",deger);
        }
        public ActionResult SatisGuncelle(SatisHareket satis)
        {
            var deger = c.SatisHarekets.Find(satis.Satisid);
            deger.CarilerID = satis.CarilerID;
            deger.Adet = satis.Adet;
            deger.Fiyat = satis.Fiyat;
            deger.Personelid = satis.Personelid;
            deger.Tarih = satis.Tarih;
            deger.ToplamTutar = satis.ToplamTutar;
            deger.Urunid = satis.Urunid;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SatisDetay(int id)
        {
            var degerler = c.SatisHarekets
                .Include(x=>x.Urun)
                .Include(x=>x.Cariler)
                .Include(x=>x.Personel)
                .Where(x => x.Satisid == id).ToList();
            return View(degerler);
        }
    }
}