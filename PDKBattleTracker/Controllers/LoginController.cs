using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PDKBattleTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PDKBattleTracker.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PerformLogin([Bind] User userdetails)
        {
            if ((!string.IsNullOrEmpty(userdetails.UserId)) && (!string.IsNullOrEmpty(userdetails.Password)))
            {
                if((userdetails.UserId.Equals("pocketsdk42") && userdetails.Password.Equals("pocketsdk42")))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, userdetails.UserId),
                        new Claim(ClaimTypes.Role, "Pockets"),
                    };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.Now.AddMinutes(10),
                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    return RedirectToAction("Index", "Game");
                }
            }
            return View("Index");
        }
    }
}
