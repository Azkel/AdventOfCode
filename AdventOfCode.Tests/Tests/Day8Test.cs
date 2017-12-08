using AdventOfCode.Days;
using NUnit.Framework;
using System;

namespace AdventOfCode.Tests.Tests
{
    [TestFixture]
    public class Day8Test
    {
        [Test]
        public void Day8_FirstTask()
        {
            // Arrange
            Day8 day = new Day8();
            day.FilePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\TestInputs\Day8FirstExample.txt";
            string expectedResult = "1";

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day8_SecondTask()
        {
            // Arrange
            Day8 day = new Day8();
            day.FilePath = AppDomain.CurrentDomain.BaseDirectory + @"../../TestInputs/Day8FirstExample.txt";
            string expectedResult = "10";

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
