
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter side 1 of triangle");
            double a = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Please enter side 2 of triangle");
            double b = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Please enter side 3 of triangle");
            double c = Convert.ToDouble(System.Console.ReadLine());

            {


                double s = (a + b + c) / 2;


                double area = Math.Sqrt((s) * (s - a) * (s - b) * (s - c));

                System.Console.WriteLine("The area of the triangle will be {0}", area);
            }


        }
    }
} 