using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _23_07_2020.DataBase
{
    public class GalleryDBInitializer : DropCreateDatabaseAlways<DBGalleryContext>
    {
        protected override void Seed(DBGalleryContext ctx)
        {
            ctx.Images.Add(new Image()
            {
                Name = "Name-1",
                Path = "Content/Images/_1.jpeg"
            });
            ctx.Images.Add(new Image()
            {
                Name = "Name-2",
                Path = "Content/Images/_2.jpg"
            });
            ctx.Images.Add(new Image()
            {
                Name = "Name-3",
                Path = "Content/Images/_3.png"
            });
            ctx.Images.Add(new Image()
            {
                Name = "Name-4",
                Path = "Content/Images/_4.png"
            });
            ctx.Images.Add(new Image()
            {
                Name = "Name-5",
                Path = "Content/Images/_5.png"
            });
            ctx.Images.Add(new Image()
            {
                Name = "Name-6",
                Path = "Content/Images/_6.jpg"
            });
            ctx.SaveChanges();
            base.Seed(ctx);
        }
    }
}