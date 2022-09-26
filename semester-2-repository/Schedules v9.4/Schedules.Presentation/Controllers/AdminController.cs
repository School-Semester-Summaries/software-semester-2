using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Schedules.DAL;
using Schedules.Logic.Classes;
using Schedules.Presentation.Models;
using System.Diagnostics;

namespace Schedules.Presentation.Controllers
{
    public class AdminController : Controller
    {
        private readonly SchoolClassCollection _schoolClassCollection;
        private readonly StudentCollection _studentCollection;
        private readonly TeacherCollection _teacherCollection;

        public AdminController()
        {
            _schoolClassCollection = new SchoolClassCollection(new SchoolClassDAL());
            _studentCollection = new StudentCollection(new StudentDAL());
            _teacherCollection = new TeacherCollection(new TeacherDAL());
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult CreateStudentPage()
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel.SchoolClassList = _schoolClassCollection.GetAllSchoolClasses();
            return View(studentViewModel);
        }
        [HttpPost]
        public ActionResult CreateStudent(StudentViewModel studentViewModel)
        {
            _studentCollection.CreateStudent(studentViewModel.SchoolClassId, studentViewModel.Name, studentViewModel.Birthdate, studentViewModel.Mail, studentViewModel.Phone);
            return View("Home");
        }

        public IActionResult CreateTeacherPage()
        {
            TeacherViewModel teacherViewModel = new TeacherViewModel();
            teacherViewModel.SchoolClassList = _schoolClassCollection.GetAllSchoolClasses();
            return View(teacherViewModel);
        }
        [HttpPost]
        public ActionResult CreateTeacher(TeacherViewModel teacherViewModel)
        {
            _teacherCollection.CreateTeacher(teacherViewModel.SchoolClassId, teacherViewModel.Name, teacherViewModel.Birthdate, teacherViewModel.Mail, teacherViewModel.Phone);
            return View("Home");
        }

        public IActionResult CreateSchoolClassPage()
        {
            SchoolClassViewModel schoolClassViewModel = new SchoolClassViewModel();
            schoolClassViewModel.SchoolClassList = _schoolClassCollection.GetAllSchoolClasses();
            return View(schoolClassViewModel);
        }
        [HttpPost]
        public ActionResult CreateSchoolClass(SchoolClassViewModel schoolClassViewModel)
        {
            _schoolClassCollection.CreateSchoolClass(schoolClassViewModel.Name, schoolClassViewModel.Year, schoolClassViewModel.Suffix);
            return View("Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
