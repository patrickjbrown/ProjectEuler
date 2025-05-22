namespace ProjectEuler.Problems
{
    public class Problem5 : Problem
    {
        public Problem5()
        {
            Id = 5;
            Name = "Smallest Multiple";
            Description =
                "    2520 is the smallest number that can be divided by each of the numbers\n" +
                "    from 1 to 10 without any remainder.\n\n" +
                "    What is the smallest positive number that is evenly divisible by all of\n" +
                "    the numbers from 1 to 20?";
        }

        /**
         * NOTES:
         * 
         * (1) Two solutions are displayed here: My original attempt that was clever, but flawed, 
         *     and a naive solution that functions properly. I included both to discuss my 
         *     problem-solving process.
         *     
         * (2) The naive solution is simple. It increments a counter by N, and then checks to see
         *     that it is divisible by every value up to N. If so, that must be the smallest
         *     multiple. It's not particularly elegant, but it's a step above checking *every*
         *     number for divisiblity.
         *     
         * (3) In my original attempt (GetSmallestMultipleOfFirstNDigits_Flawed), I tried to get
         *     clever. My line of thinking was:
         *       "If a number is divisible by 20, it is also divisible by all factors of 20.
         *       Starting with i=20 and working down, compute all factors of i. If one of these 
         *       factors is a number we haven't seen yet, multiply the solution by i. The result 
         *       should be the smallest multiple."
         *     While this did yield a result that was divisible by all numbers from 1-N, it was
         *     not the smallest multiple. I'm not entirely certain why this doesn't hold true,
         *     but at a certain point I needed to set the problem down and move on.
         */

        public override string GetSolution()
        {
            return GetSmallestMultipleOfFirstNDigits_Simple(20).ToString();
        }

        public long GetSmallestMultipleOfFirstNDigits_Simple(long n)
        {
            bool solved = false;
            long solution = 0;

            while (!solved)
            {
                solution += n;
                for (long i = 2; i < n; i++)
                {
                    solved = true;
                    if (solution % i != 0)
                    {
                        solved = false;
                        break;
                    }
                }
            }

            return solution;
        }

        private string GetSmallestMultipleOfFirstNDigits_Flawed(long n)
        {
            HashSet<long> coveredFactors = new HashSet<long>();
            long product = 1;

            for (long i = n; i >= 2; i--)
            {
                bool include = false;
                foreach(var factor in GetFactors(i))
                    include |= coveredFactors.Add(factor);

                if (include)
                    product *= i;
            }

            return product.ToString();
        }

        private List<long> GetFactors(long num)
        {
            List<long> factors = new List<long> { num };

            for(long i = 2; i <= num / 2; i++)
                if(num % i == 0)
                    factors.Add(i);

            return factors;
        }
    }
}
