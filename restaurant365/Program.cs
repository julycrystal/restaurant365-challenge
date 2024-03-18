namespace StringCalculator
{
    public class Program
    {
        public static int Calculate(string input)
        {
            Calculator calculator = new Calculator();
            calculator.SetEquationString(input);
            calculator.SetParser(new AddEquationParser());
            int result = calculator.Calculate();

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
