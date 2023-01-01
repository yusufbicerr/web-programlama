using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebProje2.Models;

namespace WebProje2.Controllers
{
    public class MesajController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
