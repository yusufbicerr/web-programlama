using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaProje.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
