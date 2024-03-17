using StringCalculator;

namespace tests
{
    [TestFixture]
    class Milestone4Test
    {
        [TestCase("\n,-1,\n\n-2,,,,-3\n,\n-4,,,")]
        [TestCase("1,5,15,,63,,\n,,-1")]
        [TestCase("-1,-2,-3,-4,5,6,7,8,9")]
        [TestCase("-3987")]
        public void Should_Throw_Exception_For_Negative_Numbers(string input)
        {
            // Act, Assert
            Assert.Throws<Exception>(() =>
            {
                Program.Calculate(input);
            });
        }
    }
}
