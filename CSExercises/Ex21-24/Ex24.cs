
using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine ("Enter a Number you would like to calculate square root of");
            double sqtNum = Convert.ToDouble(Console.ReadLine());

            Random r = new Random();
            int G = r.Next(1, 1000);
            int NsqtNum = Convert.ToInt32 (sqtNum);

            do
            {
                G = (G + NsqtNum / G) / 2;
            } 
            while (G * G != NsqtNum);
            
            Console.WriteLine ("The square root of {0} is {1:0.00000}", sqtNum, G);
            }
    }// Need to debug on how to writeline as long as G = N upto 5 decimal points/ check notes on Day 4 Demo
}