using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class SwapTwoNumbers
    {
        public static void DisplaySwapTwoNumbers()
        {
            int a = 85, b = 60;
            Console.WriteLine("Before swap a=" + a + " b=" + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swap a=" + a + " b=" + b);

        }
    }
}
