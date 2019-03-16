using System;
using System.Linq;

namespace Exercise16_17
{
    class Program
    {
        private static readonly string[] Names = { "Kim", "Jesper", "Mads", "Morten", "Rasmus" };

        static void Main(string[] args)
        {
            var result = (from name in FindNamesWithMoreThanThreeLettersAnonymous() orderby name.Length select name).ToArray();
            Array.ForEach(FindNamesWithMoreThanThreeLettersLambda() , Console.WriteLine);
            var ordeneredNames = OrderNames();
            Array.ForEach(ordeneredNames, Console.WriteLine);

            Console.WriteLine("Using orderby LINQ");
            Array.ForEach(result, Console.WriteLine);

            Console.ReadKey();
        }

        #region Exercise16_Question3 

        //Lambda expression is also an anonymous method -> Prefer way 

        static string[] FindNamesWithMoreThanThreeLettersLambda()
        {
            return Array.FindAll(Names, s => s.Length > 3);
        }
        #endregion

        #region Exercise16_Question2

        static string[] FindNamesWithMoreThanThreeLettersAnonymous()
        {
            return Array.FindAll(Names, delegate(string name) { return name.Length > 3; });
        }

        #endregion

        #region Exercise16_Question1

        static string[] FindNamesWithMoreThanThreeLettersPredicate()
        {
            Predicate<string> predicate = FindName;
            return Array.FindAll(Names, predicate);
        }

        private static bool FindName(string name)
        {
            return name.Length > 3;
        }
        #endregion

        #region Exercise17

        private static string[] OrderNames()
        {
            return Names.OrderBy(s => s).ToArray();
        }

        #endregion

    }
}
    