using AdventOfCode.Days;
using NUnit.Framework;
using System;

namespace AdventOfCode.Tests.Tests
{
    [TestFixture]
    public class Day7Test
    {
        [Test]
        public void Day7_FirstTask()
        {
            // Arrange
            Day7 day = new Day7();
            day.FilePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\TestInputs\Day7FirstExample.txt";
            string expectedResult = "tknk";

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day7_SecondTask()
        {
            // Arrange
            Day7 day = new Day7();
            day.FilePath = AppDomain.CurrentDomain.BaseDirectory + @"../../TestInputs/Day7FirstExample.txt";
            string expectedResult = "60";

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
