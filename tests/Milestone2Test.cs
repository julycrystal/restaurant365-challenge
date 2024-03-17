using StringCalculator;

namespace tests
{
    [TestFixture]
    public class Milestone2Test
    {
        [TestCase("1,2,3,4,5,6,7,8,9,10,11,12", 78)]
        [TestCase("a,b,c,5,5,5,d,e,f", 15)]
        [TestCase(",,,,,,100,,,,10,,,,,1,,,,,", 111)]
        [TestCase("x,6,y,6,,e,,z,bow,,,owt,,7", 19)]
        public void Should_Not_Throw_Exception_For_More_Than_2_Numbers(string input, int expected)
        {
            // Act
            int result = Program.Calculate(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
