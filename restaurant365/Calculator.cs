namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string input)
        {
            string[] delimiters;
            string numbersString;

            (delimiters, numbersString) = GetDelimiters(input);
            List<int> numbers = SplitNumbers(numbersString, delimiters);
            CheckNegativeNumbes(numbers);

            return numbers.FindAll(IsValidNumber).Sum();
        }

        private (string[], string) GetDelimiters(string input)
        {
            string[] delimiters = { ",", "\n" };
            string numbersString = input;

            if (input.StartsWith("//"))
            {
                int newLineIndex = input.IndexOf('\n');
                string newDelimiter = input.Substring(2, newLineIndex - 2);
                numbersString = input.Substring(newLineIndex + 1);
                delimiters = delimiters.Append(newDelimiter).ToArray();
            }
            return (delimiters, numbersString);
        }

        private bool IsValidNumber(int number)
        {
            if (number > 1000)
                return false;
            return true;
        }

        private List<int> SplitNumbers(string input, string[] delimiters)
        {
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
