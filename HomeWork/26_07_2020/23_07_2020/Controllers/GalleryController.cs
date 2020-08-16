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
            DBCTX im = new DBCTX();
            return View(im.Images.ToArray());
        }
    }
}