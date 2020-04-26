using System;

namespace MobidiagApp2.ViewModel
{
    public class MobidiagAppViewModel
    {
        public MobidiagAppViewModel()
        {

        }

        public ulong GetTotalMutiple(string inputStr)
        {
            ulong input = GetTotalMutipleInput(inputStr);

            ulong total = 0;
            for (ulong i = 0; i < input + 1; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            };
            return total;
        }

        public ulong GetSumOfFibEvenNumber(string inputStr)
        {
            ulong fib2 = 0, fib3 = 1;
            ulong sum = 0;
            ulong range = GetFibSumIput(inputStr);
            for (ulong i = 1; i <= range; i++)
            {
                ulong finb1 = fib2;
                fib2 = fib3;
                fib3 = finb1 + fib2;
                if (fib3 % 2 == 0)
                {
                    sum += fib3;
                }
            }
            return sum;
        }

        public ulong GetLargestPrime(string inputStr)
        {
            ulong input = GetPrimeInput(inputStr);
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

        public ulong GetTotalMutipleInput(string inputStr)
        {
            if (!ulong.TryParse(inputStr, out ulong input))
            {
                if (input == 0)
                {
                    input = 1000;
                }
            }

            return input;
        }

        public ulong GetFibSumIput(string inputStr)
        {
            if (!ulong.TryParse(inputStr, out ulong input))
            {
                if (input == 0)
                {
                    input = 4_000_000;
                }
            }
            return input;
        }

        public ulong GetPrimeInput(string inputStr)
        {
            if (!ulong.TryParse(inputStr, out ulong input))
            {
                if (input == 0)
                {
                    input = 6_008_514_751_43;
                }
            }
            return input;
        }

    }
}
