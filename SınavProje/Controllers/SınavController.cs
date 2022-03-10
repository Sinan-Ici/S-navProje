using Microsoft.AspNetCore.Mvc;
using SınavProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SınavProje.Controllers
{
    public class SınavController : Controller
    {
        SınavProjeContext db = new SınavProjeContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SınavEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SınavEkle(SınavTbl t)
        {
            db.SınavTbls.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
