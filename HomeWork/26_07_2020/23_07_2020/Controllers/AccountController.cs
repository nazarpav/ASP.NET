using _23_07_2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace _23_07_2020.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Registration()
        {
            return View(new UserVM());
        }
        [HttpPost]
        public ActionResult Registration(UserVM result)
        {
            DBCTX ctx = new DBCTX();
            bool isEmailExist = ctx.Users.FirstOrDefault(q => q.Email == result.Email) == null;
            bool isPhoneExist = ctx.Users.FirstOrDefault(q => q.PhoneNumber == result.PhoneNumber) == null;
            bool isEmailCorrect = result.Email!=null&&Regex.IsMatch(result.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            bool isPhoneCorrect = result.PhoneNumber != null && Regex.IsMatch(result.PhoneNumber, @"^[+]380\d{9}$");
            if (!isEmailCorrect || !isEmailExist)
            {
                ModelState.AddModelError("Email", "Invalid email or email exists");
            }
            if (!isPhoneCorrect || !isPhoneExist)
            {
                ModelState.AddModelError("PhoneNumber", "Invalid phone or phone exists");
            }
            if(!isEmailCorrect || !isEmailExist|| !isPhoneCorrect || !isPhoneExist)
            {
                return View(result);
            }
            if (ModelState.IsValid)
            {
                ctx.Users.Add(new DataBase.User()
                {
                    Name = result.Name,
                    Surname = result.Surname,
                    Email = result.Email,
                    PhoneNumber = result.PhoneNumber,
                    Password = result.Password,
                    Login = result.Login
                });
                ctx.SaveChanges();
                return View(new UserVM());
            }
            return View(result);
        }
        public ActionResult GetAllUsers()
        {
            DBCTX ctx = new DBCTX();
            return View(ctx.Users.ToArray());
        }
    }
}