namespace StringCalculator
{
    public class Equation
    {
        private int[] operands = {};
        private Operator[] operators = {};

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
