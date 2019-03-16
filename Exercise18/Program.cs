using System;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part1

            var c = new C();
            var b = new B();

            B.SM();
            b.NIM();
            b.VIM();

            C.SM();
            c.NIM();
            c.VIM();

            #endregion

            #region Part2

            Console.WriteLine("Assigning C to B");
            b = c;
            Console.WriteLine($"Type of B: {b.GetType()}");

            /**
             * Using the override keyword in the derived class (C) VIM method, the VIM method in the base class
             * (B) is overwritten. However method NIM does not overrite the VIM method in the base class so the
             * method in the base class is called instead of the method in the derived class. 
             */
            b.VIM();
            b.NIM();

            c.VIM();
            c.NIM();

            #endregion

            Console.ReadLine();
        }
    }
}
