using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientAndReminder
    {
        public static void FindQuontientAndReminder()
        {
            int divident, divisor;
            Console.WriteLine("Enter divident");
            divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor");
            divisor = Convert.ToInt32(Console.ReadLine());

            int reminder = divident % divisor;
            int qoustient = divident / divisor;

            Console.WriteLine("the divident is: {0} and the divisor is: {1}", divident, divisor);
            Console.WriteLine("the Qoustient is: {0} and the reminder is: {1}", qoustient, reminder);


        }
    }
}
