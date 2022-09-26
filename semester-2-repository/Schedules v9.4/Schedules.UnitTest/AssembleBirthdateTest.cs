using NUnit.Framework;
using Schedules.Presentation.Models;

// Test logic in ViewModel
namespace Schedules.UnitTest
{
    public class AssembleBirthdateTest
    {
        [TestCase(25, 12, 2002, "2002-12-25")]
        [TestCase(23, 7, 2002, "2002-07-23")]
        public void AssembleBirthdate(int day, int month, int year, string expectedBirthdate)
        {
            // Arrange
            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel.Day = day;
            studentViewModel.Month = month;
            studentViewModel.Year = year;

            // Act
            string birthdate = studentViewModel.Birthdate;

            // Assert
            Assert.AreEqual(expectedBirthdate, birthdate);
        }
    }
}