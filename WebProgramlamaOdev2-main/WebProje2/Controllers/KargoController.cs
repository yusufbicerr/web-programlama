using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje2.Models.Siniflar;

namespace WebProje2.Controllers
{
    public class KargoController : Controller
    {
        Context c = new Context();
        public IActionResult Index(string search)
        {
            var k = from x in c.KargoDetays select x;
            if (!string.IsNullOrEmpty(search))
            {
                k = k.Where(y => y.TakipKodu.Contains(search));
            }
            return View(k.ToList());
        }
        [HttpGet]
        public ActionResult KargoEkle()
        {
            Random rnd = new Random();
            string[] karakterler = { "A", "B", "C", "D", "X", "H", "Y", "Z", "C" };
            int k1, k2, k3;
            k1 = rnd.Next(0, 9);
            k2 = rnd.Next(0, 9);
            k3 = rnd.Next(0, 9);
            int s1, s2, s3;
            s1 = rnd.Next(100, 1000);
            s2 = rnd.Next(10, 99);
            s3 = rnd.Next(10, 99);
            string kod = s1.ToString() + karakterler[k1] + s2 + karakterler[k2] + s3 + karakterler[k3];
            ViewBag.takipkod = kod;
            return View();
        }
        [HttpPost]
        public ActionResult KargoEkle(KargoDetay d)
        {
            if (!ModelState.IsValid)
            {
                return View("KargoEkle");
            }
            c.KargoDetays.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KargoDetay(string id)
        {
            var degerler = c.KargoDetays.Where(x => x.TakipKodu == id).ToList();
            return View(degerler);
        }
    }
}
