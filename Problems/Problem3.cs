namespace ProjectEuler.Problems
{
    public class Problem3 : Problem
    {
        public Problem3()
        {
            Id = 3;
            Name = "Largest Prime Factor";
            Description =
                "    The prime factors of 13195 are 5, 7, 13, and 29.\n" +
                "    What is the largest prime factor of the number 600851475143?";
        }

        public override string GetSolution()
        {
            return GetLargestPrimeFactor(600851475143L).ToString();
        }

        private long GetLargestPrimeFactor(long n)
        {
            n = Math.Abs(n);

            while (n % 2 == 0)
                n /= 2;

            long divisor = 3;
            long sqrtN = (long)Math.Floor(Math.Sqrt(n));
            while (divisor <= sqrtN)
            {
                if (n % divisor == 0)
                {
                    n /= divisor;
                    sqrtN = (long)Math.Floor(Math.Sqrt(n));
                }
                else
                {
                    divisor += 2;
                }
            }

            return n;
        }
    }
}
