﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            {
                System.Console.WriteLine("Please enter an integer");
                string x = System.Console.ReadLine();
                double y = Convert.ToDouble(x);
                System.Console.WriteLine("The square root of {0} is {1:#.###}", y, System.Math.Sqrt(y));
            }          
        }
    }
}
