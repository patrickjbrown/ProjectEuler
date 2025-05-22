namespace ProjectEuler.Problems
{
    public class Problem9 : Problem
    {
        public Problem9()
        {
            Id = 9;
            Name = "Special Pythagorean Triplet";
            Description =
                "    A Pythagorean triplet is a set of three natural numbers, a < b < c, for which\n" +
                "        (a^2) + (b^2) = (c^2)\n" +
                "    For example, (3^2) + (4^2) = 9 + 16 = 25 = (5^2)\n\n" +
                "    There exists exactly one Pythagorean triplet for which a + b + c = 1000.\n" +
                "    Find the product a * b * c.";
        }

        /**
         * NOTES:
         * 
         * (1) If A<B<C, and A+B+C=TARGET, then we know that A cannot exceed one third of TARGET,
         *     so that's the upper bound we put on the outer for-loop.
         * 
         * (2) Once A has been taken into account, B can not be more than half of the difference
         *     between TARGET and A, and thus that informs the upper bound of the inner for-loop.
         * 
         * (3) If A+B+C=TARGET, then C can be expressed as TARGET-A-B. With all 3 values, we
         *     can now test if the set is a Pythagorean Triplet: (a^2) + (b^2) = (c^2). If so,
         *     we have our winner.
         *     
         * (4) There is absolutely math that can do this faster, but like with Problem 6, that
         *     level of math sits beyond what I can recall from my college days.
         */

        public override string GetSolution()
        {
            var triplet = GetPythagoreanTripletWithTargetSum(1000);

            return triplet == null
                ? string.Empty
                : (triplet.Item1 * triplet.Item2 * triplet.Item3).ToString();
        }

        private Tuple<int, int, int> GetPythagoreanTripletWithTargetSum(int target)
        {
            for (int a = 1; a <= (int)Math.Floor(target / 3d); a++)
            {
                for (int b = a + 1; b <= (int)Math.Floor((target - a) / 2d); b++)
                {
                    int c = target - a - b;

                    if ((a * a) + (b * b) == (c * c))
                        return new Tuple<int, int, int>(a, b, c);
                }
            }

            return null;
        }
    }
}