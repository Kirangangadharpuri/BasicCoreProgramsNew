using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenOrOdd
    {
        public static void FindEvenOrOdd()
        {
            int num;
            Console.WriteLine("Enter the Number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The {0} is Even number", num);
            }
            else
            {
                Console.WriteLine("The {0} is Odd number", num);
            }
        }
    }
}
