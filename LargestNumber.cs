using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LargestNumber
    {
        public static void FineLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the largest number");
            Console.WriteLine("Input the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("the 1st number is greater among three numbers");
                }
                else
                {
                    Console.WriteLine("the 3rd number is greater among three numbers");

                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("the 2nd number is greater among three numbers");
            }
            else
            {
                Console.WriteLine("the 3rd number is greater among three numbers");
            }

        }
    }
}
