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
            var employees = _manager.GetAll();
            return View(employees);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                _manager.Add(model);
                return View();
                
            }
            else
            {
                return View(model);
            }
           
        }
        public IActionResult Edit(int id)
        {
            var employee = _manager.GetById(id);
            if (employee is null)
                return NotFound();

            var model = new ViewEmployee()
            {
                Id = employee.Id,
                Name = employee.Name,
                Famaly = employee.Famaly,
                Age = employee.Age,
                Post = employee.Post
            };
            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            
            if (ModelState.IsValid)
            {
                _manager.Update(model);
                return RedirectToAction("GetAll");
            }
            else
            {
                return View();
            }
           
        }
        public IActionResult Delete(int id)
        {
            var employee=_manager.GetById(id);
            if(employee is null)
             return NotFound();

            var model = new ViewEmployee()
            {
                Id = employee.Id,
                Name = employee.Name,
                Famaly = employee.Famaly,
                Age = employee.Age,
                Post = employee.Post
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult DeleteConf(int id)
        {
            _manager.Delete(id);
            return RedirectToAction("GetAll");
        }
        public IActionResult Details(int id)
        {
            var employee = _manager.GetById(id);
            return View(employee);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
