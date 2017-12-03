using AdventOfCode.Days;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Tests.Tests
{
    [TestFixture]
    public class Day3Test
    {
        [Test]
        public void Day3_FirstTask_Example1()
        {
            // Arrange
            Day3 day = new Day3();
            day.Input = 1;
            int expectedResult = 0;

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day3_FirstTask_Example2()
        {
            // Arrange
            Day3 day = new Day3();
            day.Input = 12;
            int expectedResult = 3;

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day3_FirstTask_Example3()
        {
            // Arrange
            Day3 day = new Day3();
            day.Input = 23;
            int expectedResult = 2;

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day3_FirstTask_Example4()
        {
            // Arrange
            Day3 day = new Day3();
            day.Input = 1024;
            int expectedResult = 31;

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day3_SecondTask_Example1()
        {
            // Arrange
            Day3 day = new Day3();
            day.Input = 4;
            int expectedResult = 5;

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day3_SecondTask_Example2()
        {
            // Arrange
            Day3 day = new Day3();
            day.Input = 25;
            int expectedResult = 26;

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day3_SecondTask_Example3()
        {
            // Arrange
            Day3 day = new Day3();
            day.Input = 147;
            int expectedResult = 304;

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
