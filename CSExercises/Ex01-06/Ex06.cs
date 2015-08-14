using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter an integer");
            string x = System.Console.ReadLine();
           int y = Convert.ToInt32(x);
            System.Console.WriteLine("The square root of {0} is {1:#.###}", y, System.Math.Sqrt(y));       
        }
    }
}
