namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string input)
        {
            List<int> numbers = SplitNumbers(input);
            if (numbers.Count > 2) throw new Exception("Supports a maximum of 2 numbers");

            return numbers.Sum();
        }

        private List<int> SplitNumbers(string input)
        {
            List<int> numbers = input.Split(",")
                                     .Select(n => int.TryParse(n, out int parsed) ? parsed : 0)
                                     .ToList();

            return numbers;
        }
    }
}
