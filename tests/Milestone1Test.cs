using StringCalculator;

namespace tests
{
    [TestFixture]
    public class Milestone1Test
    {
        [TestCase("20", 20)]
        [TestCase("1,5000", 1)]
        [TestCase("4,83", 87)]
        public void Should_Return_Sum(string input, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("", 0)]
        [TestCase("7,", 7)]
        [TestCase(",105", 105)]
        [TestCase(",", 0)]
        public void Should_Return_0_For_Empty_Values(string input, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("5,tytyt", 5)]
        [TestCase("xiet,", 0)]
        [TestCase(",nnwwoop", 0)]
        [TestCase("bwxz,9995", 0)]
        [TestCase("ab,cd", 0)]
        public void Should_Return_0_For_Invalid_Numbers(string input, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
