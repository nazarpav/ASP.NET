using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _23_07_2020.DataBase
{
    public class DBInitializer : DropCreateDatabaseAlways<DBCTX>
    {
        protected override void Seed(DBCTX ctx)
        {
            #region Image_Initializer
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
            #endregion
            #region User_Initializer
            ctx.Users.Add(new User(){
                Name="Admin",
                Surname="Adminovich",
                Login="Admin",
                Email="Admin@WVRCorp.com",
                Password="Admin",
                PhoneNumber="+380000000000"
            });
            ctx.Users.Add(new User()
            {
                Name = "Moderator",
                Surname = "Moderatorovich",
                Login = "Moderator",
                Email = "Moderator@WVRCorp.com",
                Password = "Moderator",
                PhoneNumber = "+380000000001"
            });
            ctx.Users.Add(new User()
            {
                Name = "Ovner",
                Surname = "Ovnerovich",
                Login = "Ovner",
                Email = "Ovner@WVRCorp.com",
                Password = "Ovner",
                PhoneNumber = "+380999999999"
            });
            ctx.SaveChanges();
            #endregion
            base.Seed(ctx);
        }
    }
}