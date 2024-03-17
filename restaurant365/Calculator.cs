namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string input)
        {
            List<int> numbers = SplitNumbers(input);

            CheckNegativeNumbes(numbers);

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

        private void CheckNegativeNumbes(List<int> numbers)
        {
            List<int> negativeNumbers = numbers.FindAll(x => x < 0);

            if (negativeNumbers.Count > 0)
            {
                string errorMessage = string.Join(", ", negativeNumbers);
                throw new Exception(errorMessage);
            }
        }
    }
}
