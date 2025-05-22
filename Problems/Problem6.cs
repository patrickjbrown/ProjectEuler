namespace ProjectEuler.Problems
{
    public class Problem6 : Problem
    {
        public Problem6()
        {
            Id = 6;
            Name = "Sum Square Difference";
            Description =
                "    The sum of the squares of the first ten natural numbers is,\n" +
                "      (1^2) + (2^2) + ... + (10^2) = 385\n" +
                "    The square of the sum of the first ten natural numbers is,\n" +
                "      (1 + 2 + ... + 10) = 3025\n" +
                "    Hence the difference between the sum of the squares of the first ten natural\n" +
                "    numbers and the square of the sum is: 3025 - 385 = 2640\n\n" +
                "    Find the difference between the sum of the squares of the first one hundred\n" +
                "    natural numbers and the square of the sum.";
        }

        /**
         * NOTES:
         * 
         * (1) I'm sure there is some very fancy math that involves calculations on series that
         *     would solve this problem faster, but my calculus days are long behind me.
         */

        public override string GetSolution()
        {
            return (SquareOfSum(100) - SumOfSquares(100)).ToString();
        }

        private long SumOfSquares(int n)
        {
            return Enumerable.Range(1, n).Sum(x => x * x);
        }

        private long SquareOfSum(int n)
        {
            long sum = Enumerable.Range(1, n).Sum();
            return sum * sum;
        }
    }
}
