using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class FinalExamController: Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public FinalExamController(IEmployeeRepository employeeRepository)
        { 
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(25).Name;
        }

        public JsonResult Student()
        {
            Employee model = _employeeRepository.GetEmployee(25);
            return Json(model);
        }

        public ViewResult DetailsPage()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return View(model);
        }

        public ViewResult Information()
        {
            return View();
        }

        public ViewResult Mathematics()
        {
            return View("Exams");
        }

        public JsonResult OMG()
        {
           return Json (new {modul="4", subject="InformationSystems"});
        }
    }
}

