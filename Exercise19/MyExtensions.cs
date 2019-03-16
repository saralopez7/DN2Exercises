using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercise19
{
    public static class MyExtensions
    {
        /**
         * Extension methods are defined as static methods but are called by using instance method syntax.
         * Their first parameter specifies which type the method operates on, and the parameter is preceded
         * by the this modifier. Extension methods are only in scope when you explicitly import the namespace
         * into your source code with a using directive.
         *
         * The this keyword refers to the current instance of the class and is also used as a modifier of
         * the first parameter of an extension method.
         */
        public static int WordCount(this string str)
        {
            return str.Split(new[] { ' ', '.', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }


        public static List<int> IncreaseWith(this IList<int> numbers, int increaseBy)
        {
            return numbers.Select(n =>
            {
                n = n + increaseBy;
                return n;
            }).ToList();
        }

        public static string ToString<T>(this IEnumerable<T>  list)
        {
            var listString = "[";
            foreach (var item in list)
            {
                listString += item;
                if (!Equals(item, list.Last()))
                {
                    listString += ", ";
                }
            }

            listString += "]";
            return listString;
        }
    }
}
