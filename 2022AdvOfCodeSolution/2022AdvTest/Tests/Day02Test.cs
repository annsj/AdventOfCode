using _2022AdvOfCode.Days;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2022AdvTest.Tests
{
    [TestClass]
    public class Day02Test
    {

        public Day02 Day { get; set; }

        [TestInitialize]
        public void Init()
        {
            Day = new Day02("../../../Tests/TestInput/Day02TestInput.txt");
        }

        [TestMethod]
        public void TestGetAnswerPart1()
        {
            Assert.AreEqual(15, Day.GetAnswerPart1());
        }

        [TestMethod]
        public void TestGetAnswerPart2()
        {
            Assert.AreEqual(12, Day.GetAnswerPart2());
        }

        [TestMethod]
        public void TestParseFileLine()
        {
            char[] moves = Day.ParseFileLine("A Y");

            Assert.AreEqual('A', moves[0]);
            Assert.AreEqual('Y',moves[1]);
        }


        [TestMethod]
        public void TestGetShapeScore()
        {
            Assert.AreEqual(1, Day02.GetShapeScore('X'));
            Assert.AreEqual(2, Day02.GetShapeScore('Y'));
            Assert.AreEqual(3, Day02.GetShapeScore('Z'));
            Assert.AreEqual(1, Day02.GetShapeScore('X'));
            Assert.AreEqual(2, Day02.GetShapeScore('Y'));
            Assert.AreEqual(3, Day02.GetShapeScore('Z'));
        }

        [TestMethod]
        public void TestGetOutcomscore()
        {
            Assert.AreEqual(3, Day02.GetOutcomscore('A', 'X'));
            Assert.AreEqual(3, Day02.GetOutcomscore('B', 'Y'));
            Assert.AreEqual(3, Day02.GetOutcomscore('C', 'Z'));
            Assert.AreEqual(0, Day02.GetOutcomscore('A', 'Z'));
            Assert.AreEqual(0, Day02.GetOutcomscore('B', 'X'));
            Assert.AreEqual(0, Day02.GetOutcomscore('C', 'Y'));
            Assert.AreEqual(6, Day02.GetOutcomscore('A', 'Y'));
            Assert.AreEqual(6, Day02.GetOutcomscore('B', 'Z'));
            Assert.AreEqual(6, Day02.GetOutcomscore('C', 'X'));
        }

        [TestMethod]
        public void TestSelectMove()
        {
            Assert.AreEqual('C', Day02.SelectMove('A', 'X'));
            Assert.AreEqual('A', Day02.SelectMove('A', 'Y'));
            Assert.AreEqual('B', Day02.SelectMove('A', 'Z'));
            Assert.AreEqual('A', Day02.SelectMove('B', 'X'));
            Assert.AreEqual('B', Day02.SelectMove('B', 'Y'));
            Assert.AreEqual('C', Day02.SelectMove('B', 'Z'));
            Assert.AreEqual('B', Day02.SelectMove('C', 'X'));
            Assert.AreEqual('C', Day02.SelectMove('C', 'Y'));
            Assert.AreEqual('A', Day02.SelectMove('C', 'Z'));
        }

    }
}
