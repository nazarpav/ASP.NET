using _23_07_2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23_07_2020.Controllers
{
    public class PostController : Controller
    {
        private PostModel[] _posts = null;
        private const int IMG_COUNT = 6;
        public PostController()
        {
            _posts = new PostModel[IMG_COUNT]
            {
                   new PostModel()
                   {
                           ImgPath=@"Content/Images/_1.jpeg",
                           Name="Number 1",
                           Description="Bla lba adf dsafdfja sgdkfyuawegfhlkasdlyf snfahsdglvb kxcnvgxcb lvzuxg vlksvgksdbuv gysbru ykefukhfszvlucv hxzjvxcu vhzukxlvhuerhfj zvchx uzvhcx uivxhc viuzxc v"
                   },
                    new PostModel()
                   {
                           ImgPath=@"Content/Images/_2.jpg",
                           Name="Number 2",
                           Description="Bla lba adf dsafdfja sgdkfyuawegfhlkasdlyf snfahsdglvb kxcnvgxcb lvzuxg vlksvgksdbuv gysbru ykefukhfszvlucv hxzjvxcu vhzukxlvhuerhfj zvchx uzvhcx uivxhc viuzxc v"
                   },
                    new PostModel()
                   {
                           ImgPath=@"Content/Images/_3.png",
                           Name="Number 3",
                           Description="Bla lba adf dsafdfja sgdkfyuawegfhlkasdlyf snfahsdglvb kxcnvgxcb lvzuxg vlksvgksdbuv gysbru ykefukhfszvlucv hxzjvxcu vhzukxlvhuerhfj zvchx uzvhcx uivxhc viuzxc v"
                   },
                    new PostModel()
                   {
                           ImgPath=@"Content/Images/_4.png",
                           Name="Number 4",
                           Description="Bla lba adf dsafdfja sgdkfyuawegfhlkasdlyf snfahsdglvb kxcnvgxcb lvzuxg vlksvgksdbuv gysbru ykefukhfszvlucv hxzjvxcu vhzukxlvhuerhfj zvchx uzvhcx uivxhc viuzxc v"
                   },
                    new PostModel()
                   {
                           ImgPath=@"Content/Images/_5.png",
                           Name="Number 5",
                           Description="Bla lba adf dsafdfja sgdkfyuawegfhlkasdlyf snfahsdglvb kxcnvgxcb lvzuxg vlksvgksdbuv gysbru ykefukhfszvlucv hxzjvxcu vhzukxlvhuerhfj zvchx uzvhcx uivxhc viuzxc v"
                   },
                    new PostModel()
                   {
                           ImgPath=@"Content/Images/_6.jpg",
                           Name="Number 6",
                           Description="Bla lba adf dsafdfja sgdkfyuawegfhlkasdlyf snfahsdglvb kxcnvgxcb lvzuxg vlksvgksdbuv gysbru ykefukhfszvlucv hxzjvxcu vhzukxlvhuerhfj zvchx uzvhcx uivxhc viuzxc v"
                   }
            };
        }
        public ActionResult Programming()
        {
            return View(_posts);
        }
        public ActionResult ProgrammingReversed()
        {
            return View(_posts.Reverse().ToArray());
        }
    }
}