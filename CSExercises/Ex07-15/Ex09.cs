using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a value for x");
            double x = Convert.ToDouble(System.Console.ReadLine());
            double y = 2 * x * x - 4 * x + 3;
            System.Console.WriteLine("Value of y is {0}", y);

            
        }
    }
}
