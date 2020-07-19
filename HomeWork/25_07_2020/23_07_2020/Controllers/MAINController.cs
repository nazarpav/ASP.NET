
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23_07_2020.Controllers
{
    public class MAINController : Controller
    {
        public ActionResult Index()
        {
            //Images images = new Images();
            //images.Images_.Add(new Image()
            //{
            //    Name="Name-1",
            //    Path= "Content/Images/_1.jpeg"
            //});
            //images.Images_.Add(new Image()
            //{
            //    Name="Name-2",
            //    Path= "Content/Images/_2.jpg"
            //});
            //images.Images_.Add(new Image()
            //{
            //    Name="Name-3",
            //    Path= "Content/Images/_3.png"
            //});
            //images.Images_.Add(new Image()
            //{
            //    Name="Name-4",
            //    Path= "Content/Images/_4.png"
            //});
            //images.Images_.Add(new Image()
            //{
            //    Name="Name-5",
            //    Path= "Content/Images/_5.png"
            //});
            //images.Images_.Add(new Image()
            //{
            //    Name="Name-6",
            //    Path= "Content/Images/_6.jpg"
            //});
            //images.SaveChanges();
            return View();
        }
    }
}