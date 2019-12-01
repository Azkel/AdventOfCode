using AdventOfCode.Days;
using NUnit.Framework;
using System;

namespace AdventOfCode.Tests.Tests
{
    [TestFixture]
    public class Day4Test
    {
        [Test]
        public void Day4_FirstTask()
        {
            // Arrange
            Day4 day = new Day4();
            day.FilePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\TestInputs\Day4FirstExample.txt";
            string expectedResult = "2";

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day4_SecondTask()
        {
            // Arrange
            Day4 day = new Day4();
            day.FilePath = AppDomain.CurrentDomain.BaseDirectory + @"../../TestInputs/Day4SecondExample.txt";
            string expectedResult = "3";

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
