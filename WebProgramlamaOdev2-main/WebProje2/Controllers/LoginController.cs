using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebProje2.Models.Siniflar;

namespace WebProje2.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        Context c = new Context();
        //[AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult KayitOl()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KayitOl(Cariler p)
        {
            p.Dil = "Türkçe";
            c.Carilers.Add(p);
            c.SaveChanges();
            TempData["SignUpSuccesfully"] ="Başarılı bir şekilde kaydoldunuz !";
            return RedirectToAction("CariGiris","Login");
        }
        [HttpGet]
        public IActionResult CariGiris()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CariGiris(Cariler ca)
        {
            var datavalue = c.Carilers.FirstOrDefault(x => x.CariMail == ca.CariMail && x.Sifre == ca.Sifre);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,ca.CariMail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                if (datavalue.Dil == "Türkçe") 
                {
                    return RedirectToAction("Index", "CariPanel");
                }
                else
                {
                    return RedirectToAction("IndexEN", "CariPanel");
                }
            }
            else
            {
                TempData["LoginError"] = "Mail adresi veya şifre hatalı ! ";
                return View();
            }
        }
        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> AdminLogin(Admin p)
        {
            var datavalue = c.Admins.FirstOrDefault(x => x.KullaniciAd == p.KullaniciAd && x.Sifre == p.Sifre);
            
            if (datavalue != null)
            {             
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.KullaniciAd),
                    new Claim(ClaimTypes.Role,datavalue.Yetki)
                };
                var userIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Kategori");
            }
            else
            {
                TempData["LoginError"] = "Kullanıcı adı veya şifre hatalı ! ";
                return View();
            }
        }
    }
}
