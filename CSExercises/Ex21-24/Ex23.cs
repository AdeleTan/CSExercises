using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int compNum = r.Next(0, 10);
            int i = 1;// i = 1 cos start counting upon entry of first number
            
            Console.WriteLine("Feeling lucky, pick a number from 0 to 9?");
            int yourNum = Convert.ToInt32(Console.ReadLine());
            
            while (yourNum != compNum)
            
            {
                Console.WriteLine("Please try again!");
                yourNum = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            
                if (i <= 2) 
                {
                    Console.WriteLine("You are a wizard! you got it after {0} attempts!", i);
                }
                if ( i > 2 && i <= 5) 
                {
                    Console.WriteLine ("You made a good guess in {0} attempts", i);
                }   
                if (i > 5)
                { 
                    Console.WriteLine ("You are lousy");
                }         

                  
            
            
           
                             
            Console.ReadLine();


        }
    }
}
