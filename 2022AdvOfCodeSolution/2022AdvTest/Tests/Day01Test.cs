using _2022AdvOfCode.Days;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _2022AdvTest.Tests
{
    [TestClass]
    public class Day01Test
    {
        public Day01 Day { get; set; }

        [TestInitialize]
        public void Init()
        {
            Day = new Day01();
        }

        [TestMethod]
        public void TestGetAnswer()
        {
            int calories = Day.GetAnswer();
            Assert.AreEqual(24000, calories);
        }
    }
}
