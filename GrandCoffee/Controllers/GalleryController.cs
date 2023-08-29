using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrandCoffee.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult gallery()
        {
            return View();
        }
    }
}