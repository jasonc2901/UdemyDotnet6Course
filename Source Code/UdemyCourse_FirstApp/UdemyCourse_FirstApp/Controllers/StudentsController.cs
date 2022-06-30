using Microsoft.AspNetCore.Mvc;
using UdemyCourse_FirstApp.Models;

namespace UdemyCourse_FirstApp.Controllers
{
    public class StudentsController : Controller
    {
        private static List<StudentsViewModel> _students = new List<StudentsViewModel>();
        public IActionResult Index()
        {
            return View(_students);
        }

        public IActionResult Create()
        {
            var studentModel = new StudentsViewModel();
            return View(studentModel);
        } 

        public IActionResult AddStudent(StudentsViewModel student)
        {
            _students.Add(student);
            return RedirectToAction(nameof(Index));
        }
    }
}
