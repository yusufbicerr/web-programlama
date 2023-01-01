using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProje2.Models.Siniflar;
using X.PagedList;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    [Authorize(Roles = "A,B")]
    public class KategoriController : Controller
    {
        // GET: Kategori
        Context c = new Context();
        
        public ActionResult Index(int sayfa = 1)
        {
            var degerler = c.Kategoris.ToList().ToPagedList(sayfa, 5);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(Kategori yeniKategori)
        {
            if (!ModelState.IsValid)
            {
                return View("KategoriEkle");
            }
            try
            {
                c.Kategoris.Add(yeniKategori);
                c.SaveChanges();
                TempData["added"] = "Kategori Başarıyla Eklendi.";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
 

        }
        public ActionResult KategoriSil(int id)
        {
            try
            {
                var ktg = c.Kategoris.Find(id);
                c.Kategoris.Remove(ktg);
                c.SaveChanges();
                TempData["deleted"] = "Kategori Başarıyla Silindi.";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.Kategoris.Find(id);
            return View("KategoriGetir", kategori);
        }
        public ActionResult KategoriGuncelle(Kategori k)
        {
            if (!ModelState.IsValid)
            {
                return View("KategoriGetir");
            }
            try
            {
                var ktgr = c.Kategoris.Find(k.KategoriID);
                ktgr.KategoriAd = k.KategoriAd;
                c.SaveChanges();
                TempData["updated"] = "Kategori Başarıyla Güncellendi.";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}