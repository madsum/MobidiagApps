namespace Multiples.ViewModel
{
    public class MultiplesViewModel
    {
        public MultiplesViewModel()
        {

        }

        public long GetMultiples(long input)
        {
            long total = 0;
            for (long i = 0; i < input + 1; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            };
            return total;
        }
    }
}
