using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje2.Controllers
{
    public class YetkisizIslem : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
