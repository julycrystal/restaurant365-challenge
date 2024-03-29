namespace StringCalculator
{
    class AddEquationParser : IEquationParser
    {
        private string? input;

        public void SetEquationString(string input)
        {
            this.input = input;
        }

        public Equation Parse()
        {
            if (input == null)
                throw new Exception("Need equation string before parsing");

            Equation equation = new Equation();
            var (delimiters, numbersPart) = GetDelimiters(input);
            int[] operands = SplitNumbers(delimiters, numbersPart);
            int operatorCount = operands.Length - 1;
            Operator[] operators = Array.ConvertAll(new int[operatorCount], i => Operator.Add);

            equation.SetEquation(operands, operators);
            return equation;
        }

        private static (string[], string) GetDelimiters(string input)
        {
            string[] delimiters = { ",", "\n" };
            string numbersString = input;

            if (input.StartsWith("//"))
            {
                int newLineIndex = input.IndexOf('\n');
                string delimitersString = input.Substring(2, newLineIndex - 2);
                numbersString = input.Substring(newLineIndex + 1);

                if (delimitersString.StartsWith("[") && delimitersString.EndsWith("]"))
                    delimitersString = delimitersString.Substring(1, delimitersString.Length - 2);

                string[] newDelimiters = delimitersString.Split("][");
                delimiters = delimiters.Concat(newDelimiters).ToArray();
            }

            return (delimiters, numbersString);
        }

        private static int[] SplitNumbers(string[] delimiters, string input)
        {
            int[] numbers = input.Split(delimiters, new StringSplitOptions())
                                 .Select(n => int.TryParse(n, out int parsed) ? parsed : 0)
                                 .ToArray();

            return numbers;
        }
    }
}
