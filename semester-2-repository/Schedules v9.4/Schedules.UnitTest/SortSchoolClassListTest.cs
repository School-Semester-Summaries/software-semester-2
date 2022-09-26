using NUnit.Framework;
using Schedules.Logic.Classes;
using Schedules.UnitTest.Data;
using System.Collections.Generic;
// Test logic in Logic Class
namespace Schedules.UnitTest
{
    class SortSchoolClassListTest
    {
        [TestCase(0)]
        [TestCase(1)]
        public void SortSchoolClassList(int i)
        {
            // Arrange
            List<SchoolClass> schoolClassList = new SchoolClassData().ListWithSchoolClassLists[i];
            SchoolClassCollection schoolClassCollection = new SchoolClassCollection(new SchoolClassMockDAL());
            List<SchoolClass> sortedSchoolClassList;
            int previousYear = int.MinValue;

            // Act
            sortedSchoolClassList = schoolClassCollection.SortListOnYear(schoolClassList);

            // Assert
            for (int ii = 0; ii < sortedSchoolClassList.Count; ii++)
            {
                Assert.IsTrue(sortedSchoolClassList[ii].Year >= previousYear);
                previousYear = sortedSchoolClassList[ii].Year;
            }
        }
    }
}
// Requirements asserting
// 4. current number is higher or same as previous number

// goeie volgorde lijst 1
//expectedList.Add(new SchoolClass("Groep 3a", 3, "a"));
//expectedList.Add(new SchoolClass("Groep 3b", 3, "b"));
//expectedList.Add(new SchoolClass("Groep 4a", 4, "a"));
//expectedList.Add(new SchoolClass("Groep 6b", 6, "b"));
//expectedList.Add(new SchoolClass("Groep 7a", 7, "a"));
//expectedList.Add(new SchoolClass("Groep 8a", 8, "a"));