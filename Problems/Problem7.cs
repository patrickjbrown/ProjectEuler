namespace ProjectEuler.Problems
{
    public class Problem7 : Problem
    {
        public Problem7()
        {
            Id = 7;
            Name = "10,001st Prime";
            Description =
                "    By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see\n" +
                "    that the 6th prime is 13.\n\n" +
                "    What is the 10,001st prime number?";
        }

        /**
         * NOTES:
         * 
         * (1) We start with base knowledge of just two primes: 2 and 3. To find the next prime,
         *     we increment the candidate by 2 (since all primes must be odd).
         *     
         * (2) If a number is non-prime, then it must have prime factors. So we check to see if
         *     the candidate is divisible by any of our known primes. If not, it must be prime,
         *     and can be added to the list.
         *     
         * (3) However, we do not need to check against ALL of our known primes. We only need to
         *     evaluate those that are less than or equal to the square root of the candidate,
         *     since if a number has a prime factor > sqrt(N), then the corresponding factor must
         *     have been less than sqrt(N).
         */

        public override string GetSolution()
        {
            return GetNthPrimeNumber(10001).ToString();
        }

        private long GetNthPrimeNumber(int n)
        {
            List<long> primes = new List<long> { 2, 3 };
            long candidate = 3;

            while(primes.Count < n)
            {
                candidate += 2;
                long sqrt = (long)Math.Floor(Math.Sqrt(candidate));

                bool isPrime = true;
                foreach (long prime in primes)
                {
                    if (prime > sqrt)
                        break;

                    if (candidate % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    primes.Add(candidate);
            }

            return primes.Last();
        }
    }
}