using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(1, 2, -3, 0)]
        [InlineData(55, 26, -1, 80)]
        [InlineData(-22, 11, 12, 1)]
        [InlineData(55, -55, 55, 55)]
        [InlineData(0 , 2, 4, 6)]

        public void Add(int a, int b, int c, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(a, b, c);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,2,3)]
        [InlineData(5, 0, 5)]
        [InlineData(0, 22, -22)]
        [InlineData(-5, -10, 5)]
        [InlineData(5, -5, 10)]
        [InlineData(5, -2, 7)]

        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,3,15)]
        [InlineData(9, 5, 45)]
        [InlineData(2, 3, 6)]
        [InlineData(6, 5, 30)]
        [InlineData(22, 3, 66)]
        [InlineData(-5, 3, -15)]
        public void Multiply(int a, int b, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(a, b);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 0, 0)]
        [InlineData(4, 2, 2)]
        [InlineData(10, -5, -2)]
        [InlineData(5, 2, 2)]
        [InlineData(0, 5, 0)]
        public void Divide(int a, int b, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(a, b);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void YourMethodNameTest()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            test.YourMethodName();
            //Assert
            Assert.Equal("It Works v1.", test.conf);
        }

        [Fact]
        public void YourMethodName2Test()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
             test.YourMethodName2();
            //Assert
            Assert.Equal("it doesn't not work!", test.conf);
        }
    }
}
