namespace StringCalculator
{
    interface IEquationParser
    {
        public abstract void SetEquation(string input);
        public abstract Equation Parse();
    }
}
