using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23_07_2020.Controllers
{
    public class GalleryController : Controller
    {
        public ActionResult Main()
        {
            Images im = new Images();
            return View(im.Images_.ToArray());
        }
    }
}