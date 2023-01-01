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
    public class UrunController : Controller
    {
        // GET: Urun
        Context c = new Context();
        public ActionResult Index(string search)
        {
            var urunlerr = from x in c.Uruns.Include(x=>x.Kategori).Where(x=>x.Durum==true) select x;
            if (!string.IsNullOrEmpty(search))
            {
                urunlerr = urunlerr.Where(y => y.UrunAd.Contains(search));
            }
            return View(urunlerr.ToList());
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {  
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()
                                           }).ToList();
            ViewBag.ktg1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(Urun p)
        {

            if (!ModelState.IsValid)
            {
                return View("YeniUrun");
            }
            p.Durum = true;
            try
            {
                c.Uruns.Add(p);
                c.SaveChanges();
                TempData["added"] = "Ürün Başarıyla Eklendi.";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public ActionResult UrunSil(int id)
        {
            try
            {
                var deger = c.Uruns.Find(id);
                deger.Durum = false;
                c.SaveChanges();
                TempData["deleted"] = "Ürün Pasif hale getirildi!";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public ActionResult UrunGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()
                                           }).ToList();
            ViewBag.ktg1 = deger1;
            var urunDeger = c.Uruns.Find(id);
            return View("UrunGetir", urunDeger);
        }
        public ActionResult UrunGuncelle(Urun p)
        {
            if (!ModelState.IsValid)
            {
                return View("UrunGetir");
            }
            try
            {
                var urn = c.Uruns.Find(p.UrunID);
                urn.AlisFiyat = p.AlisFiyat;
                urn.Durum =true;
                urn.Kategoriid = p.Kategoriid;
                urn.Marka = p.Marka;
                urn.SatisFiyat = p.SatisFiyat;
                urn.Stok = p.Stok;
                urn.UrunAd = p.UrunAd;
                urn.UrunGorsel = p.UrunGorsel;
                c.SaveChanges();
                TempData["updated"] = "Ürün bilgileri başarıyla güncellendi.";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public ActionResult UrunListesi()
        {
            var degerler = c.Uruns
                .Include(x=>x.Kategori)
                .ToList();
            return View(degerler);
        }
    }
}