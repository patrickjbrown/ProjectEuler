namespace ProjectEuler.Problems
{
    public class Problem10 : Problem
    {
        public Problem10()
        {
            Id = 10;
            Name = "Summation of Primes";
            Description =
                "    The sum of the primes below is 10 is 2 + 3 + 5 + 7 = 17.\n\n" +
                "    Find the sum of all the primes below two million.";
        }

        /**
         * NOTES:
         * 
         * (1) This is largely a retread of Problem 7, except instead of finding the Nth
         *     prime number, we're finding all primes below a target, and then taking
         *     their sum.
         */

        public override string GetSolution()
        {
            var primes = GetPrimeNumbersBelowTarget(2000000);
            return primes.Sum().ToString();
        }

        private List<long> GetPrimeNumbersBelowTarget(int target)
        {
            List<long> primes = new List<long> { 2, 3 };
            long candidate = 3;

            while (candidate < target)
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

            return primes;
        }
    }
}