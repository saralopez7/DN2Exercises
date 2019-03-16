using System;
using System.Linq;

namespace Exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,13, 14, 15, 16 };

            var (average, sum) = GetAverageAndSum(numbers);

            Console.WriteLine($"Average: {average}, Sum: {sum}");
            Console.ReadKey();
        }

        private static (int, int) GetAverageAndSum(int[] numbers)
        {
            var average = Convert.ToInt32(numbers.Average());
            var sum = numbers.Sum();

            return (average, sum);
        }
    }
}
