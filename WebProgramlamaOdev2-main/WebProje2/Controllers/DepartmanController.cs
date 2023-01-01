using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProje2.Models.Siniflar;

namespace WebProje2.Controllers
{
    [Authorize(Roles = "A,B")]
    public class DepartmanController : Controller
    {
        // GET: Departman
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Departmans.Where(x => x.Durum == true).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult DepartmanEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DepartmanEkle(Departman d)
        {
            if (!ModelState.IsValid)
            {
                return View("DepartmanEkle");
            }
            try
            {
                c.Departmans.Add(d);
                d.Durum = true;
                c.SaveChanges();
                TempData["added"] = "Departman Başarıyla eklendi.";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }

        }
        public ActionResult DepartmanSil(int id)
        {
            try
            {
                var dep = c.Departmans.Find(id);
                dep.Durum = false;
                c.SaveChanges();
                TempData["deleted"] = "Departman Başarıyla Silindi.";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }


        }
        public ActionResult DepartmanGetir(int id)
        {
            var dpt = c.Departmans.Find(id);
            return View("DepartmanGetir",dpt);
        }
        public ActionResult DepartmanGuncelle(Departman p)
        {
            if (!ModelState.IsValid)
            {
                return View("DepartmanGetir");
            }
            try
            {
                var dpt = c.Departmans.Find(p.Departmanid);
                dpt.DepartmanAd = p.DepartmanAd;
                c.SaveChanges();
                TempData["updated"] = "Departman Başarıyla Güncellendi.";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
         
        }
        public ActionResult DepartmanDetay(int id)
        {
            var degerler = c.Personels.Include(x=>x.Departman).Where(x => x.Departmanid == id).ToList();
            var dpt = c.Departmans.Where(x => x.Departmanid == id).Select(y => y.DepartmanAd).FirstOrDefault();
            ViewBag.depAdi = dpt;
            return View(degerler);
        }
        public ActionResult DepartmanPersonelSatis(int id)
        {
            var degerler = c.SatisHarekets
                .Include(x=>x.Urun)
                .Include(x=>x.Cariler)
                .Where(x => x.Personelid == id).ToList();
            var ilgiliPersonel = c.Personels.Where(x => x.PersonelID == id).Select(y => y.PersonelAd+" "+y.PersonelSoyad).FirstOrDefault();
            ViewBag.dPer = ilgiliPersonel;
            return View(degerler);
        }
    }
}