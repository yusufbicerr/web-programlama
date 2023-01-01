using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje2.Models.Siniflar;

namespace WebProje2.Controllers
{
    public class GaleriController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Uruns.ToList();          
            return View(degerler);
        }
    }
}
