using NUnit.Framework;
using Schedules.Logic.Classes;
using Schedules.UnitTest.Data;

// int i beetje slordig jatoch is maar test

namespace Schedules.UnitTest
{
    class CreateSchoolClassTest
    {
        [TestCase("Groep 6b", 6, "b", 0)]
        [TestCase("Groep 8a", 8, "a", 1)]
        [TestCase("Groep 1c", 1, "c", 2)]
        public void CreateSchoolClass(string name, int year, string suffix, int i)
        {
            // Arrange
            SchoolClassCollection schoolClassCollection = new SchoolClassCollection(new SchoolClassMockDAL());
            SchoolClassData schoolClassData = new SchoolClassData();
            string _name = name;
            int _year = year;
            string _suffix = suffix;

            // Act
            schoolClassCollection.CreateSchoolClass(_name, _year, _suffix);

            // Assert
            Assert.IsTrue(SchoolClassData.SchoolClassList[i].Name == _name);
            Assert.IsTrue(SchoolClassData.SchoolClassList[i].Year == _year);
            Assert.IsTrue(SchoolClassData.SchoolClassList[i].Suffix == _suffix);
        }
    }
}
