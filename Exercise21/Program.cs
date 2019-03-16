using System;

namespace Exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10000; i++)
            {
                if (PrimeTool.IsPrime(i))
                {
                    Console.Write($"Prime: {i}");
                }
            }

            Console.ReadLine();
        }
    }
}

public static class PrimeTool
{
    public static bool IsPrime(int candidate)
    {
        // Test whether the parameter is a prime number.
        if ((candidate & 1) == 0)
        {
            return candidate == 2;
        }

        for (var i = 3; (i * i) <= candidate; i += 2)
        {
            if ((candidate % i) == 0)
            {
                return false;
            }
        }
        return candidate != 1;
    }
}
