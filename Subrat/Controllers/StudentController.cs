using Microsoft.AspNetCore.Mvc;
using Subrat.Models;
using Subrat.DataAccessLayer;


namespace Subrat.Controllers
{
    public class StudentController : Controller
    {
        Details Db = new Details();

        [HttpGet]
        public IActionResult GetAll()
        {
            var output = Db.getAllStudentDetails();
            return View(output);
        }

        public IActionResult AddDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDetails(StudentDetail studentDetail)
        {
            Db.AddStudentDetails(studentDetail);
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult GetAllMarksheet()
        {
            var output = Db.getAllMarkSheet();
            return View(output);
        }

        public IActionResult AddMarksheet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMarksheet(Marksheet marksheet)
        {
            Db.AddMarkSheet(marksheet);
            return RedirectToAction("GetAllMarksheet");
        }

        [HttpGet]
        public IActionResult GetAllPassed()
        {
            var output = Db.PassStudent();
            return View(output);
        }
    }
}
