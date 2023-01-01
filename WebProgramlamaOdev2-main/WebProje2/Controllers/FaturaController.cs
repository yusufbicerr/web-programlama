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
    public class FaturaController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var liste=c.Faturalars.ToList();
            return View(liste);
        }
        [HttpGet]
        public ActionResult FaturaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FaturaEkle(Faturalar f)
        {
            c.Faturalars.Add(f);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FaturaGetir(int id)
        {
            var fatura = c.Faturalars.Find(id);
            TempData["Date"] = fatura.Tarih;
            return View("FaturaGetir", fatura);
        }
        public ActionResult FaturaGuncelle (Faturalar f)
        {
            var fatura = c.Faturalars.Find(f.Faturalarid);
            fatura.FaturaSeriNo = f.FaturaSeriNo;
            fatura.FaturaSiraNo = f.FaturaSiraNo;
            fatura.Saat = f.Saat;
            fatura.Tarih = f.Tarih;
            fatura.TeslimAlan = f.TeslimAlan;
            fatura.TeslimEden = f.TeslimEden;
            fatura.VergiDairesi = f.VergiDairesi;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FaturaDetay(int id)
        {
            var degerler = c.FaturaKalems.Where(x => x.Faturalarid == id).ToList();
            var dpt = c.FaturaKalems.Where(x => x.Faturalarid == id).Select(y => y.Faturalarid).FirstOrDefault();
            ViewBag.fNo = dpt;
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniKalem(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKalem(FaturaKalem p)
        {
            c.FaturaKalems.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}