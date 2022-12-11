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
        private static List<List<int>> _expectedinventories = new List<List<int>>
        {
            new List<int> { 1000, 2000, 3000 },
            new List<int> { 4000 },
            new List<int> { 5000, 6000 },
            new List<int> { 7000, 8000, 9000 },
            new List<int> { 10000 }
        };


        public Day01 Day { get; set; }

        [TestInitialize]
        public void Init()
        {
            Day = new Day01("../../../Tests/TestInput/Day01TestInput.txt");
        }

        [TestMethod]
        public void TestGetAnswerPart1()
        {
            Assert.AreEqual(24000, Day.GetAnswerPart1());
        }

        [TestMethod]
        public void TestGetAnswerPart2()
        {
            Assert.AreEqual(45000, Day.GetAnswerPart2());
        }

        [TestMethod]
        public void TestGetInventoriesEqualLengthOfLists()
        {
            Assert.AreEqual(_expectedinventories.Count, Day.Inventories.Count);
        }

        [TestMethod]
        public void TestGetInventoriesEqualContent()
        {
            for (int i = 0; i < Day.Inventories.Count; i++)
            {
                CollectionAssert.AreEqual(_expectedinventories[i], Day.Inventories[i]);
            }

        }
    }
}
