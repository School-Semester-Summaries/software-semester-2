using NUnit.Framework;
using Schedules.UnitTest.Data;

// Test logic in logic class // Split name kan handig zijn maar niet op de manier hoe ik het nu doe, verplaats naar collection class?
namespace Schedules.UnitTest
{
    class SplitNameTest
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void SplitName(int i)
        {
            // Arrange
            TeacherData teacherMock = new TeacherData();
            string[] nameParts;
            string firstName;
            string lastName;

            // Act
            nameParts = teacherMock.TeacherList[i].Name.Split();
            firstName = nameParts[0];
            lastName = nameParts[1];

            // Assert
            Assert.IsTrue(teacherMock.TeacherList[i].Name.Contains(firstName));
            Assert.IsTrue(teacherMock.TeacherList[i].Name.Length > firstName.Length);
            Assert.IsTrue(teacherMock.TeacherList[i].Name.Contains(lastName));
            Assert.IsTrue(teacherMock.TeacherList[i].Name.Length > lastName.Length);
        }
    }
}
