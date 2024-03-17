using System.Reflection.Metadata.Ecma335;
using StringCalculator;

namespace tests
{
    [TestFixture]
  class Milestone5Test
  {
    [TestCase("2,1001,6", 8)]
    [TestCase("\n\n,,,141,641,1000,1000,,,,0,2000,5124,6\n\n,", 2788)]
    public void Should_Not_Add_Numbers_Greater_Than_1000(string input, int expected)
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