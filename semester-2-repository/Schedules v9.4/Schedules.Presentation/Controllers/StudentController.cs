using Microsoft.AspNetCore.Mvc;
using Schedules.DAL;
using Schedules.Logic.Classes;
using Schedules.Presentation.Models;

namespace Schedules.Presentation.Controllers
{
    public class StudentController : Controller
    {
        static public Student SelectedStudent { get; private set; }
        private readonly StudentCollection _studentCollection;
        private readonly GradeCollection _gradeCollection;
        private readonly TestCollection _testCollection;

        public StudentController()
        {
            _studentCollection = new StudentCollection(new StudentDAL());
            _gradeCollection = new GradeCollection(new GradeDAL());
            _testCollection = new TestCollection(new TestDAL());
        }

        public IActionResult Login()
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel.StudentList = _studentCollection.GetAllStudents();
            return View(studentViewModel);
        }
        public ActionResult ProcessLogin(StudentViewModel studentViewModel)
        {
            Student student = _studentCollection.GetStudentById(studentViewModel.StudentId);
            SelectedStudent = student;
            return RedirectToAction("Home");
        }

        public IActionResult Home()
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel.FirstName = SelectedStudent.Name.Split()[0]; // LOGICA
            return View(studentViewModel);
        }

        public IActionResult CheckMyGradesPage()
        {
            GradeViewModel gradeViewModel = new GradeViewModel();
            gradeViewModel.GradeList = _gradeCollection.GetAllGradesFromSpecifiedStudent(SelectedStudent.Id);
            gradeViewModel.TestList = _testCollection.GetAllTestsFromSpecifiedGrades(gradeViewModel.GradeList);
            return View(gradeViewModel);
        }
    }
}
