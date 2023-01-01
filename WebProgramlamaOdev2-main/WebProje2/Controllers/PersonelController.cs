using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebProje2.Models.Siniflar;

namespace WebProje2.Controllers
{
    [Authorize(Roles = "A")]
    public class PersonelController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Personels.Include(x=>x.Departman).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult PersonelEkle()
        {
            List<SelectListItem> deger1 = (from x in c.Departmans.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmanAd,
                                               Value = x.Departmanid.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult PersonelEkle(AddProfileImage t)
        {
            if (!ModelState.IsValid)
            {
                return View("PersonelEkle");
            }
            Personel p = new Personel();
            if (t.PersonelGorsel !=null)
            {
                var extension = Path.GetExtension(t.PersonelGorsel.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Image/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                t.PersonelGorsel.CopyTo(stream);
                p.PersonelGorsel = "/wwwroot/Image/"+newImageName;
            }
            p.PersonelAd = t.PersonelAd;
            p.PersonelSoyad = t.PersonelSoyad;
            p.Departmanid = t.Departmanid;
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PersonelGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Departmans.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmanAd,
                                               Value = x.Departmanid.ToString()
                                           }).ToList();
            ViewBag.dgr2 = deger1;
            var prs = c.Personels.Find(id);
            return View("PersonelGetir",prs);
        }
        public ActionResult PersonelGuncelle(AddProfileImage t)
        {

            if (!ModelState.IsValid)
            {
                return View("PersonelGetir");
            }
            Personel p = new Personel();
            if (t.PersonelGorsel != null)
            {
                var extension = Path.GetExtension(t.PersonelGorsel.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Image/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                t.PersonelGorsel.CopyTo(stream);
                p.PersonelGorsel = "/wwwroot/Image/" + newImageName;
            }          
            var personel = c.Personels.Find(t.PersonelID);
            personel.PersonelAd = t.PersonelAd;
            personel.PersonelSoyad = t.PersonelSoyad;
            personel.PersonelGorsel = p.PersonelGorsel;
            personel.Departmanid = t.Departmanid;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult PersonelListe()
        {
            var sorgu = c.Personels
                .Include(x=>x.Departman)
                .ToList();
            return View(sorgu);
        }
    }
}

/*
        */



/*
 GUNCELLE ESKİ KOD
  public ActionResult PersonelGuncelle(Personel p)
        {
       
            var personel = c.Personels.Find(p.PersonelID);
            personel.PersonelAd = p.PersonelAd;
            personel.PersonelSoyad = p.PersonelSoyad;
            personel.PersonelGorsel = p.PersonelGorsel;
            personel.Departmanid = p.Departmanid;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
 
 
 
 */