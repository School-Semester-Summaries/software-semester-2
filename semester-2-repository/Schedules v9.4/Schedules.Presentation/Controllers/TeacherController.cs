using Microsoft.AspNetCore.Mvc;
using Schedules.DAL;
using Schedules.Logic.Classes;
using Schedules.Presentation.Models;

namespace Schedules.Presentation.Controllers
{
    public class TeacherController : Controller
    {
        static private Teacher SelectedTeacher;
        private readonly StudentCollection _studentCollection;
        private readonly TeacherCollection _teacherCollection;
        private readonly TestCollection _testCollection;
        private readonly GradeCollection _gradeCollection;

        public TeacherController()
        {
            _studentCollection = new StudentCollection(new StudentDAL());
            _teacherCollection = new TeacherCollection(new TeacherDAL());
            _testCollection = new TestCollection(new TestDAL());
            _gradeCollection = new GradeCollection(new GradeDAL());
        }

        public IActionResult Login()
        {
            TeacherViewModel teacherViewModel = new TeacherViewModel();
            teacherViewModel.TeacherList = _teacherCollection.GetAllTeachers();
            return View(teacherViewModel);
        }
        public ActionResult ProcessLogin(TeacherViewModel teacherViewModel)
        {
            SelectedTeacher = _teacherCollection.GetTeacherById(teacherViewModel.TeacherId);
            return RedirectToAction("Home");
        }

        public IActionResult Home()
        {
            TeacherViewModel teacherViewModel = new TeacherViewModel();
            teacherViewModel.FirstName = SelectedTeacher.Name.Split()[0]; // LOGICA
            return View(teacherViewModel);
        }

        public IActionResult CreateTestPage()
        {
            TestViewModel testViewModel = new TestViewModel();
            return View(testViewModel);
        }
        [HttpPost]
        public ActionResult CreateTest(TestViewModel testViewModel)
        {
            _testCollection.CreateTest(testViewModel.Subject, testViewModel.Name, testViewModel.Weight);
            return RedirectToAction("Home");
        }

        public IActionResult GradeStudentPage()
        {
            GradeViewModel gradeViewModel = new GradeViewModel();
            gradeViewModel.TestList = _testCollection.GetAllTests();
            gradeViewModel.StudentList = _studentCollection.GetAllStudents();
            return View(gradeViewModel);
        }
        [HttpPost]
        public ActionResult GradeStudent(GradeViewModel gradeViewModel)
        {
            _gradeCollection.CreateGrade(gradeViewModel.Student_ID, gradeViewModel.Test_ID, gradeViewModel.Grade);
            return RedirectToAction("Home");
        }
    }
}
