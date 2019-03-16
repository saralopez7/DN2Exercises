using System;
using System.Collections.Generic;

namespace Exercise19
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Part 1

            const string helloString = "Hello, Extension Methods!";
            var wordCount = helloString.WordCount();
            Console.WriteLine(wordCount);
            #endregion

            #region Part 2

            List<int> numbers = new List<int>{1, 2, 3, 4, 5};
            numbers = numbers.IncreaseWith(5);
            Array.ForEach(numbers.ToArray(), Console.WriteLine);
            #endregion

            #region Part 3

            Console.WriteLine(numbers.ToString<int>());

            #endregion
            Console.ReadLine();

        }
    }


}
