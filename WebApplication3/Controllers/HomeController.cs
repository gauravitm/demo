﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        //code added on 27/feb/2018
        //code created by: Gaurav
        //Pourpouse of this is to render register view in webbrowser
        public IActionResult Login()
        {
            ViewData["Message"] = "Your Login Page";

            //code for returning view
            return View();
        }

        
        



        //code added on 27/feb/2018
        //code created by: Gaurav
        //Pourpouse of this is to render Register view in webbrowser
        public IActionResult Register()
        {
            ViewData["Message"] = "Your Register Page";

            //code for returning view
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
