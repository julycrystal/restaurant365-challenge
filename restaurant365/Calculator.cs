namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string input)
        {
            List<int> numbers = SplitNumbers(input);

            return numbers.Sum();
        }

        private List<int> SplitNumbers(string input)
        {
            string[] delimiters = { ",", "\n" };
            List<int> numbers = input.Split(delimiters, new StringSplitOptions())
                                     .Select(n => int.TryParse(n, out int parsed) ? parsed : 0)
                                     .ToList();

            return numbers;
        }
    }
}
