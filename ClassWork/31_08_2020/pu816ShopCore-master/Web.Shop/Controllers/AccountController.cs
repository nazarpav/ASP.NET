﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.Shop.Entities;
using Web.Shop.Models;

namespace Web.Shop.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<DbUser> _userManager;
        private readonly SignInManager<DbUser> _signInManager;
        private readonly RoleManager<DbRole> _roleManager;

        public AccountController(UserManager<DbUser> userManager,
            SignInManager<DbUser> signInManager,
            RoleManager<DbRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        //await AuthenticateAsync(user.Email);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ModelState.AddModelError("", "Дані вкажано не коректно");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationViewModel model)
        {
            bool isEmailExist = await _userManager.FindByEmailAsync(model.Email) == null;
            bool isEmailCorrect = model.Email != null && Regex.IsMatch(model.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            bool isPhoneCorrect = model.PhoneNumber != null && Regex.IsMatch(model.PhoneNumber, @"^[+]380\d{9}$");
            if (!isEmailCorrect || !isEmailExist)
            {
                ModelState.AddModelError("Email", "Invalid email or email exists");
            }
            if (!isPhoneCorrect)
            {
                ModelState.AddModelError("PhoneNumber", "Invalid phone or phone exists");
            }
            if (!isEmailCorrect || !isEmailExist || !isPhoneCorrect)
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                var user = new DbUser
                {
                    Email = model.Email,
                    UserName = model.UserName,
                    PhoneNumber = model.PhoneNumber
                };
                await _userManager.CreateAsync(user, model.Password);
                await _userManager.AddToRoleAsync(user, "User");
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}
