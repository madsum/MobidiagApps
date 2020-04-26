using System;

namespace LargestPrime.ViewModel
{
    public class LargestPrimeViewModel
    {
        public LargestPrimeViewModel()
        {

        }

        public ulong GetLargestPrime(ulong input)
        {
            while (input % 2 == 0)
            {
                input /= 2;
            }

            // n must be odd at this point.  So we can skip one element (Note i = i +2)
            for (ulong i = 3; i <= Math.Sqrt(input); i += 2)
            {
                while ((input % i) == 0)
                {
                    input /= i;
                }
            }
            return input;
        }
    }
}
