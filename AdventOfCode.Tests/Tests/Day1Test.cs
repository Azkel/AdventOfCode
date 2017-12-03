using AdventOfCode.Days;
using NUnit.Framework;

namespace AdventOfCode.Tests
{
    [TestFixture]
    public class Day1Test
    {

        [Test]
        public void Day1_FirstTask_1()
        {
            // Arrange
            Day1 day = new Day1();
            day.InputString = "1122";
            int expectedResult = 3;

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day1_FirstTask_2()
        {
            // Arrange
            Day1 day = new Day1();
            day.InputString = "1111";
            int expectedResult = 4;

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day1_FirstTask_3()
        {
            // Arrange
            Day1 day = new Day1();
            day.InputString = "1234";
            int expectedResult = 0;

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void Day1_FirstTask_4()
        {
            // Arrange
            Day1 day = new Day1();
            day.InputString = "91212129";
            int expectedResult = 9;

            // Act
            var result = day.GetResult(Enums.TaskNumber.First);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day1_SecondTask_1()
        {
            // Arrange
            Day1 day = new Day1();
            day.InputString = "1212";
            int expectedResult = 6;

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day1_SecondTask_2()
        {
            // Arrange
            Day1 day = new Day1();
            day.InputString = "1221";
            int expectedResult = 0;

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day1_SecondTask_3()
        {
            // Arrange
            Day1 day = new Day1();
            day.InputString = "123425";
            int expectedResult = 4;

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day1_SecondTask_4()
        {
            // Arrange
            Day1 day = new Day1();
            day.InputString = "123123";
            int expectedResult = 12;

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day1_SecondTask_5()
        {
            // Arrange
            Day1 day = new Day1();
            day.InputString = "12131415";
            int expectedResult = 4;

            // Act
            var result = day.GetResult(Enums.TaskNumber.Second);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
