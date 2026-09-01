using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace EmployeeManagement.Controllers
{
    public class HomeController: Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        private IConfiguration _config;
        public HomeController(IEmployeeRepository employeeRepository, IConfiguration config)
        { 
            _employeeRepository = employeeRepository;
            _config = config;
        }

        public ViewResult Error()
        {
            throw new Exception("Error message: This is The Developer Exception Page with +- 5 rows!");
        }



        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }

        public string GetEmail()
        {
            return _employeeRepository.GetEmployee(25).Email;
        }

        public JsonResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(25);
            return Json(model);
        }

        public string MyKey()
        {
            return _config["MyKey"];
        }

        public string ProcessName()
        {
            return System.Diagnostics.Process.GetCurrentProcess().ProcessName;
        }

        public ViewResult DetailsPage()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewData["PageTitle"] = "Employee Details";
            ViewData["Employee"] = model;
            return View(model);
        }

        public ViewResult DetailsPageTable()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewData["PageTitle"] = "Employee Details";
            ViewData["Employee"] = model;
            return View(model);
        }

        public ViewResult DetailsView()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(1),
                PageTitle = "Employee Details View"
            };
            return View(homeDetailsViewModel);
        }
        public ViewResult TestPage()
        {
            return View();
        }

        public ViewResult TestDifferent()
        {
            return View("Different");
        }

        public ViewResult TestUp()
        {
            return View("../Up.cshtml");
        }

        public string PrintText()
        {
            return "This is text.";
        }

        public int PrintValue()
        {
            return 3;
        }

        public string MVC()
        {
           return "Hello from MVC!";
        }

        public JsonResult Data()
        {
           return Json (new {id=1, name="XII class!"});
        }
    }
}

