﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebProgramlamaProje.Models.Siniflar;

namespace WebProgramlamaProje.Controllers
{
    [Authorize(Roles = "A,B")]
    public class YapilacakController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var deger1 = c.Carilers.Count().ToString();
            ViewBag.d1 = deger1;
            var deger2 = c.Uruns.Count().ToString();
            ViewBag.d2 = deger2;
            var deger3 = c.Kategoris.Count().ToString();
            ViewBag.d3 = deger3;
            var yapilacaklar = c.Yapilacaklars.ToList();
            return View(yapilacaklar);
        }

    }
}
