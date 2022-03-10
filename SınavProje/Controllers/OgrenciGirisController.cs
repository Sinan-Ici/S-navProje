using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SınavProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SınavProje.Controllers
{
    public class OgrenciGirisController : Controller
    {
        SınavProjeContext db = new SınavProjeContext();
        [HttpGet]
        public IActionResult OgrenciGiris()
        {
            return View();
        }
        public async Task<IActionResult> OgrenciGiris(OgrenciGirisTbl t)
        {
            var bilgiler = db.OgrenciGirisTbls.FirstOrDefault(x => x.OgrenciMail == t.OgrenciMail && x.Sifre == t.Sifre);
            if (bilgiler!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email,t.OgrenciMail)
                };
                //var useridentity = new ClaimsIdentity(claims, "Login");
                
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Sınav");
            }
            return View();
        }
    }
}
