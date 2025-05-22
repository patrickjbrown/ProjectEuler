namespace ProjectEuler.Problems
{
    public class Problem4 : Problem
    {
        public Problem4()
        {
            Id = 4;
            Name = "Largest Palindrome Product";
            Description =
                "    A palindromic number reads the same both ways. The largest palindrome made\n" +
                "    from the product of two 2-digit numbers is:\n" +
                "    9009 = 91 * 99\n\n" +
                "    Find the largest palindrome made from the product of two 3-digit numbers.";
        }

        /**
         * NOTES:
         * 
         * (1) We structure the for-loops to go in opposite directions, because it avoids duplicate
         *     calculations. If we calculate I * J, we do not need to calculate J * I. This takes
         *     the solution's time complexity from O(N^2) down to O(N*logN).
         *     
         * (2) We skip over multiples of 10, because any product of a number ending in 0 is incapable
         *     of being a palindrome, since it cannot also start with 0. It won't change the overall
         *     time complexity, but it feels wasteful to perform calculations that aren't needed.
         */

        public override string GetSolution()
        {
            int largestPalindrome = 0;

            for (int i = 100; i <= 999; i++)
            {
                if (i % 10 == 0)
                    continue;

                for (int j = 999; j >= i; j--)
                {
                    if (j % 10 == 0)
                        continue;

                    int product = i * j;
                    if (product > largestPalindrome && IsPalindrome(product.ToString()))
                        largestPalindrome = product;
                }
            }

            return largestPalindrome.ToString();
        }

        private bool IsPalindrome(string s)
        {
            return s.Equals(new string(s.Reverse().ToArray()));
        }
    }
}
