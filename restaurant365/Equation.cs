namespace StringCalculator
{
    public class Equation
    {
        private int[] operands = Array.Empty<int>();
        private Operator[] operators = Array.Empty<Operator>();

        public void SetEquation(int[] operands, Operator[] operators)
        {
            this.operands = operands;
            this.operators = operators;
        }

        public (int[], Operator[]) GetEquation()
        {
            return (operands, operators);
        }
    }
}
