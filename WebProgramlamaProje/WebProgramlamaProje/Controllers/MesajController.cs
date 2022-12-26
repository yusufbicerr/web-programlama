using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaProje.Controllers
{
    public class MesajController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
