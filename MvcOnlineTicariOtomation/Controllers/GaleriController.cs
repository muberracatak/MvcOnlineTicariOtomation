using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomation.Models.Siniflar;

namespace MvcOnlineTicariOtomation.Controllers
{
    public class GaleriController : Controller
    {
        // GET: Galeri
        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.Uruns.ToList();
            return View(degerler);
        }
    }
}