using CloneProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;
using Tweetinvi;
using Tweetinvi.Models;
using EntityLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Abstract;

using System;

namespace CloneProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TwitterHome()
        {
            return View("./Views/Home/TwitterHome.cshtml");
        }

        public IActionResult Privacy()
        {
            return View("TwitterHome");
        }



        public IActionResult Welcome()
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