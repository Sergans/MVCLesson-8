using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCLesson_8.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MVCLesson_8.Services;
using MVCLesson_8.ViewModels;
namespace MVCLesson_8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Manager _manager;

        public HomeController(ILogger<HomeController> logger, Manager manager)
        {
            _manager = manager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            var ls = _manager.GetAll();
            return View(ls);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            _manager.Add(model);
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Edit(Employee model)
        {
            return View();
        }
        public IActionResult Delete(ViewEmployee model)
        {
            var a = new ViewEmployee { Name = "xck", Age = 65, Famaly = "cdcc", Post = "cccc" };
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Employee model)
        {
            _manager.Delete(model);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
