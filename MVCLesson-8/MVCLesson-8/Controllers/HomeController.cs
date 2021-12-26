using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCLesson_8.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MVCLesson_8.Services;
namespace MVCLesson_8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Manager _manager;

        public HomeController(ILogger<HomeController> logger,Manager manager)
        {
            _manager = manager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //public IActionResult Create(Employee employee)
        //{
        //    _manager.Add(employee);
        //    return View(employee);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
