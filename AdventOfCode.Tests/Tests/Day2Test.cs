using AdventOfCode.Days;
using NUnit.Framework;
using System;

namespace AdventOfCode.Tests.Tests
{
    [TestFixture]
    public class Day2Test
    {
        [Test]
        public void Day2_FirstTask()
        {
            // Arrange
            Day2 day = new Day2();
            day.FilePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\TestInputs\Day2FirstExample.txt";
            int expectedResult = 18;

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day2_SecondTask()
        {
            // Arrange
            Day2 day = new Day2();
            day.FilePath = AppDomain.CurrentDomain.BaseDirectory + @"../../TestInputs/Day2SecondExample.txt";
            int expectedResult = 9;

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
