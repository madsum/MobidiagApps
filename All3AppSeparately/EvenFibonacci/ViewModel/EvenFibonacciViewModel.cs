namespace EvenFibonacci.ViewModel
{
    public class EvenFibonacciViewModel
    {
        public EvenFibonacciViewModel()
        {

        }

        public ulong SumOfFibEvenNumber(ulong range)
        {
            ulong fib2 = 0, fib3 = 1;
            ulong sum = 0;
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
    }
}
