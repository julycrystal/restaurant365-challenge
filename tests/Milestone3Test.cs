using StringCalculator;

namespace tests
{
    [TestFixture]
    public class Milestone3Test
    {
        [TestCase("1\n2,3", 6)]
        [TestCase("\n\n\n62\n\n\n", 62)]
        [TestCase("34,635\n,\n23\n5", 697)]
        public void Should_Use_Newline_By_Alternative_Delimeter(string input, int expected)
        {
            // Act
            int result = Program.Calculate(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
