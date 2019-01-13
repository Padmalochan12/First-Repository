using Nasa.MarsRover;
using System;
using Xunit;

namespace CSharpTestProject
{
    public class SampleUnitTest
    {
        [Theory]
        [InlineData("5 5\n1 2 N\nMMMMMMMMMM", "1 3 N")]
        public void Throw_Exception_For_Invalid_Coordinate(string input, string expectedDirection)
        {
            var rovers = InputParser.GetRover(input);
            Assert.Throws<RoverException>(() => rovers.Navigate());
        }

        [InlineData("5 5\n1 2 N\nLMLMLMLMM", "1 3 N")]
        [Theory]
        public void Pass_For_All_ValidInput(string input, string expectedDirection)
        {
            var rovers = InputParser.GetRover(input);
            var actualResult = rovers.Navigate();
            Assert.True(actualResult == expectedDirection);
        }
    }
}
