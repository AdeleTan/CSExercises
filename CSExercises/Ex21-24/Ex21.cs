using System;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            int enterValue = Convert.ToInt32(Console.ReadLine());
            int secretValue = 88;

            while (enterValue != secretValue)
            {
                System.Console.Write("Enter another value: ");
                enterValue = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Lucky you...");

            Console.ReadLine();

        }
    }
}
