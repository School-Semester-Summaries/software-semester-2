using NUnit.Framework;
using System.Collections.Generic;

namespace Unit_Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            TestHelp();
        }
        public void TestHelp()
        {
            List<string> list = new List<string>();
            list[0] = "a";
            list[1] = "b";
            list[2] = "c";
            list[3] = "a";
            string findItem = list.Find(item => item.Equals("a"));
            Assert.AreEqual(findItem, "a");
        }
    }
}