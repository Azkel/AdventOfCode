using AdventOfCode.Days;
using NUnit.Framework;

namespace AdventOfCode.Tests.Tests
{
    [TestFixture]
    public class Day6Test
    {
        [Test]
        public void Day6_FirstTask()
        {
            // Arrange
            Day6 day = new Day6();
            day.InputString = "0	2	7	0";
            string expectedResult = "5";

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day6_SecondTask()
        {
            // Arrange
            Day6 day = new Day6();
            day.InputString = "0	2	7	0";
            string expectedResult = "4";

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        }
    }

