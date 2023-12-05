using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleAuthentication.Services;
using Expense_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Expense_Tracker.Controllers
{
    public class LoginController : Controller
    {
        string clientId = "319109325007-e9n606vstjm265ss76ei9p4qdh4rushs.apps.googleusercontent.com";
        string url = "https://localhost:5018/Login/GoogleLoginCallBack";
        string clientSecret = "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";
        UserProfileModel profile = new UserProfileModel();
        public IActionResult Login()
        {
            var response = GoogleAuth.GetAuthUrl(clientId, url);
            ViewBag.response = response;
            return View();
        }
        public async Task<ActionResult> GoogleLoginCallBack(string code) 
        {
            var token = await GoogleAuth.GetAuthAccessToken(code, clientId, clientSecret, url);
            var userProfile = await GoogleAuth.GetProfileResponseAsync(token.AccessToken.ToString());
            JObject user = JObject.Parse(userProfile);
            
            ViewBag.UserName = profile.UserProfile(user)[3];
            ViewBag.UserEmail = profile.UserProfile(user)[1];
            ViewBag.UserPicture = profile.UserProfile(user)[6];
            if (userProfile != null){return RedirectToAction("Index", "Dashboard");}
            return View();
            
        }

    }
}

