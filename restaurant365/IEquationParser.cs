namespace StringCalculator
{
    public interface IEquationParser
    {
        public abstract void SetEquationString(string input);
        public abstract Equation Parse();
    }
}
