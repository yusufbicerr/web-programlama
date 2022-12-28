using Microsoft.AspNetCore.Mvc;
using WebProgramlamaProje.Models.Siniflar;

namespace WebProgramlamaProje.Controllers
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
