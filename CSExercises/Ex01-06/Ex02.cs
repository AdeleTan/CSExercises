using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
         System.Console.WriteLine ("Please enter an integer");
         string x = System.Console.ReadLine();
           int y = Int32.Parse(x);
           int z = y * y;
            System.Console.WriteLine("The square of {0} is {1}", y, z);
        }
    }
}

