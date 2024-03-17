namespace StringCalculator
{
    public class Program
    {
        public static int Calculate(string input)
        {
            Calculator calculator = new Calculator();
            AddEquationParser parser = new AddEquationParser();
            parser.SetEquation(input);
            Equation equation = parser.Parse();
            int result = calculator.Calculate(equation);

            return result;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (input == null) return;

                try
                {
                    int result = Calculate(input);
                    Console.WriteLine("Result: " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
