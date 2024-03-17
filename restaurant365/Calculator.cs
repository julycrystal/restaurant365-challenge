namespace StringCalculator
{
    public class Calculator
    {
        public int Calculate(Equation equation)
        {
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
