using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a value for x1");
            double x1 = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Enter a value for y1");
            double y1 = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Enter a value for x2");
            double x2 = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Enter a value for y2");
            double y2 = Convert.ToDouble(System.Console.ReadLine());

            double Distance = System.Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)));

            System.Console.WriteLine("The distance betweent the two points is {0}", Distance);

        }
    }
}
