﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Emulair.BusinessLogic.Implementation.Account;
using Emulair.Common.DTOs;
using Emulair.WebApp.Code.Base;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Emulair.Code.Base;
using Microsoft.AspNetCore.Authorization;

namespace Emulair.Controllers
{
    public class UserAccountController : BaseController
    {
        private readonly UserAccountService Service;

        public UserAccountController(ControllerDependencies dependencies, UserAccountService service)
           : base(dependencies)
        {
            this.Service = service;
        }

        [HttpGet]
        public IActionResult Register()
        {
            var model = new RegisterModel();

            return View("Register", model);
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (model == null)
            {
                return View("Error_NotFound");
            }

            Service.RegisterNewUser(model);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            var model = new LoginModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = Service.Login(model.Email, model.Password);

            if (!user.IsAuthenticated)
            {
                model.AreCredentialsInvalid = true;
                return View(model);
            }

            await LogIn(user);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await LogOut();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult ProfilePage()
        {
            var CurrentUserDetails = Service.DisplayProfile();
            return View(CurrentUserDetails);
        }


        private async Task LogIn(CurrentUserDto user)
        {
            var claims = new List<Claim>
            {
                new Claim("Id", user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim("Name", user.FirstName.ToString())
            };


            var identity = new ClaimsIdentity(claims, "Cookies");
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(
                    scheme: "EmulairCookies",
                    principal: principal);
        }


        private async Task LogOut()
        {
            await HttpContext.SignOutAsync(scheme: "EmulairCookies");
        }
    }
}
