using StringCalculator;

namespace tests
{
    [TestFixture]
    class Milestone6Test
    {
        [TestCase("//#\n2#5", 7)]
        [TestCase("//,\n2,ff,100", 102)]
        public void Should_Support_Custom_Delimiter(string input, int expected)
        {
            // Act
            int result = Program.Calculate(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
