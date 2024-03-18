namespace StringCalculator
{
    public class Calculator
    {
        private string? input;
        private IEquationParser? parser;

        public void SetEquationString(string input)
        {
            this.input = input;
        }

        public void SetParser(IEquationParser parser)
        {
            this.parser = parser;
        }

        public int Calculate()
        {
            if (input == null)
                throw new Exception("Need equation string before calculation");
            if (parser == null)
                throw new Exception("Need equation parser before calculation");

            parser.SetEquationString(input);
            Equation equation = parser.Parse();
            var (operands, operators) = equation.GetEquation();
            CheckNegativeNumbes(operands);

            return operands.Where(IsValidNumber).Sum();
        }

        private bool IsValidNumber(int number)
        {
            if (number > 1000)
                return false;
            return true;
        }

        private void CheckNegativeNumbes(int[] numbers)
        {
            int[] negativeNumbers = numbers.Where(x => x < 0).ToArray();

            if (negativeNumbers.Length > 0)
            {
                string errorMessage = string.Join(", ", negativeNumbers);
                throw new Exception(errorMessage);
            }
        }
    }
}
