using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SınavProje.Controllers
{
    public class EgitmenGirisController : Controller
    {
        public IActionResult EgitmenGiris()
        {
            return View();
        }
    }
}
