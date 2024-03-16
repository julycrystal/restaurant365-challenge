using StringCalculator;

namespace tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("20", 20)]
        [TestCase("1,5000", 5001)]
        [TestCase("4,-3", 1)]
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
        [TestCase("bwxz,9995", 9995)]
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

        [TestCase("1,2,3")]
        [TestCase("2,3,")]
        [TestCase(",,")]
        [TestCase(",,bwxz,9995,,")]
        [TestCase(",ab,cd")]
        [TestCase("a,b,c,d")]
        public void Should_Throw_Exception_For_More_Than_2_Numbers(string input)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act, Assert
            Assert.Throws<Exception>(() =>
            {
                calculator.Add(input);
            });
        }
    }
}
