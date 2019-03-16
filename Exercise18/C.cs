using System;

namespace Exercise18
{
    public class C : B
    {
        public static void SM()
        {
            Console.WriteLine("Hello from C.SM()");
        }

        public override void VIM()
        {
            Console.WriteLine("Hello from C.VIM()");
        }

        public new void NIM()
        {
            Console.WriteLine("Hello from C.NIM()");
        }
    }
}
