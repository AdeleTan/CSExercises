
using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
           int x, y;

            Console.WriteLine(" X \t Y");

            for (x=-5; x< 5; x++)
            {
                y = (2 * x * x) - (4 * x) + 3;
               Console.WriteLine("{0:#.#} \t {1:0.#}", x, y);
            }
          }      
        }
    }

