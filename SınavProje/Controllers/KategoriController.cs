using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SınavProje.Models;

namespace SınavProje.Controllers
{
    public class KategoriController : Controller
    {
        SınavProjeContext db = new SınavProjeContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult KategoriEkle()
        {
             return View();
        }
        [HttpPost]
        public IActionResult KategoriEkle(KategoriTbl t)
        {
            db.KategoriTbls.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
