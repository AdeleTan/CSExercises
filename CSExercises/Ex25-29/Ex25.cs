using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            int F = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int Ans = 1;

            for (i = 1; i <= F; i++)
            {
                Ans = Ans * i;
                Console.WriteLine(Ans);
            }
            Console.WriteLine("The factorial of {0} using incremental method is {1}", F, Ans);

            Ans = 1;// resetting so that 2nd block can be executed from F = entered value rather than the Ans from the prior block
            for (i = F; i > 0; i--)
            {
                Ans = Ans * i;
                Console.WriteLine(Ans);
            }
                Console.WriteLine("The factorial of {0} using decremental method is {1}", F, Ans);
        }
    
    }
}
