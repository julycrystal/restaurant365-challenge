using StringCalculator;

namespace tests
{
    [TestFixture]
    class Milestone8Test
    {
        [TestCase("//[*][!!][r9r]\n11r9r22*hh*33!!44", 110)]
        [TestCase("//[*][*][,][a()][*][()]\n()()a()1***a(),,,,2()()a()3()a(),,()4,,", 10)]
        public void Should_Support_Multiple_Delimiters(string input, int expected)
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
