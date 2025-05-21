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
