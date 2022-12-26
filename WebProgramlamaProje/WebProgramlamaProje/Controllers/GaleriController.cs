using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaProje.Controllers
{
    public class GaleriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
