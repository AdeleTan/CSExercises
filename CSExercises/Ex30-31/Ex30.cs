using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {

           /* int count;
            for (int i = 5; i <= 1000; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) { count = count + 1; }

                }
                if (count == 2)
                {
                    Console.Write(i); Console.Write(" is a Prime Number "); Console.WriteLine("");
                }
             }
        }
    }
}         */
            int count;
            
            for (int i = 5; i <= 1000; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        {
                            count = count + 1;
                        }
                }
                    if (count == 2)
                    {
                        Console.WriteLine(i);
                        
                    }
                 }
            }
        }
    }


