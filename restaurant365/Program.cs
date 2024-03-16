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

namespace StringCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Calculator calculator = new Calculator();

      while (true)
      {
        string? input = Console.ReadLine();
        if (input == null) return;

        try
        {
          int result = calculator.Add(input);
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
