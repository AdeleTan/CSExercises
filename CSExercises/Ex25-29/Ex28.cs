using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            int TestP = Convert.ToInt32(Console.ReadLine());
            int i;

            for (i = 2; i <= TestP - 1; i++) // reason why i < TestP - 1 cos i = 2, count of when i reaches TestP will be reached will be TestP-1 time
            {
                if (TestP % i == 0)
                {
                    Console.WriteLine("{0} is a not Prime number.", TestP);
                    break;
                }
            }

            if (i == TestP)
            {
                Console.WriteLine("{0} is a Prime number.", TestP);
            }


        }
    }
}