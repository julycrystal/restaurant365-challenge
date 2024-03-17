using StringCalculator;

namespace tests
{
    [TestFixture]
    class Milestone7Test
    {
        [TestCase("//[***]\n11***22***33", 66)]
        [TestCase("//[x,,,y]\n66,,,x,,,y,,,8", 74)]
        [TestCase("//[abc_def]\nabc_def\n\n6abc_def7abc_def", 13)]
        public void Should_Support_1_Custom_Delimiter_Of_Any_Length(string input, int expected)
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
