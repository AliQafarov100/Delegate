using System;

namespace DelegateTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = { 23.5, 53.2, 10.3, 2.9, 10.5, 1.5, 120.45 };

            Action<double[]> TotalandCount = SumTotal;
            TotalandCount(prices);
        }

        public static void SumTotal(double[] arr)
        {
            int count = default(int);
            double total = default(double);
            foreach(double general in arr)
            {
                count++;
                total += general;
            }
            Console.WriteLine($"Count products: {count}\n" +
                $"Total price: {total}");
        }

    }
}
