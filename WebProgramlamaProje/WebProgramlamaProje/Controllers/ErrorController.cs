using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaProje.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult PageError(int code)
        {
            return View();
        }
    }
}
