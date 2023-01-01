using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace WebProje2.Controllers
{
    [Authorize(Roles = "A,B")]
    public class QEController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string kod)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                //QRCodeGenerator kodUret = new QRCodeGenerator();
                //QRCodeGenerator.QRCode kareKod = kodUret.CreateQrCode(kod, QRCodeGenerator.ECCLevel.Q);
                //using (Bitmap resim = kareKod.GetGraphic(10))
                //{
                //    resim.Save(ms, ImageFormat.Png);
                //    ViewBag.kareKodImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                //}
            }
                return View();
        }
    }
}
