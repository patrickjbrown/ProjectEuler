namespace ProjectEuler.Problems
{
    public class Problem1 : Problem
    {
        public Problem1()
        {
            Id = 1;
            Name = "Multiples of 3 or 5";
            Description = 
                "    If we list all the natural numbers below 10 that are multiples of 3 or 5,\n" +
                "    we get 3, 5, 6, and 9. The sum of these multiples is 23.\n\n" +
                "    Find the sum of all the multiples of 3 or 5 below 1000.";
        }

        /**
         * NOTES:
         * 
         * (1) This is the simplest way of solving this problem, but it isn't the fastest. We waste
         *     CPU cycles on numbers that aren't multiples of 3 or 5. A more optimal solution would
         *     be to sum the multiples of 3, sum the multiples of 5, and the subtract the multiples
         *     of 15 to remove duplicates. Or put the multiples of 3 and 5 in a HashSet, and then
         *     take the sum of the values in the set.
         * 
         * (2) Sometimes, there's beauty in solutions that are easily grok'd, but not 100% ideal.
         */

        public override string GetSolution()
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;

            return sum.ToString();
        }
    }
}
