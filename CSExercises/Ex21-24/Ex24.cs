
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
            double G = r.Next(1, 1000);
            int NsqtNum = Convert.ToInt32 (sqtNum);
            double Gestimate = Math.Round(G, 6);


            while (Gestimate!= NsqtNum)
            {
                G = (G + NsqtNum / G) / 2;
                Gestimate = Math.Round ((G*G),6);
            }
            G = Math.Round(G, 5);

                      Console.WriteLine ("The square root of {0} is {1:0.00000}", sqtNum, G);
            }
    }// Need to debug on how to writeline as long as G = N upto 5 decimal points/ check notes on Day 4 Demo (review Ex 40)
}