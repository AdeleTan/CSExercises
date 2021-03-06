
using System;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine("Square Root of {0} up to 5 dpt is {1}", i, SQT(i));
            }
        }
        public static double SQT(int y)
        {
            // fnding a sqt root of a number y but generating a random number based out of y to start the iteration process
            double N, G, Nestimate, Gestimate;
            Random r = new Random();
            N = Convert.ToDouble(y);// N is the input from y
            if (N >= 0)
            {
                Nestimate = Math.Round(Convert.ToDouble(N), 6);
                int E = Convert.ToInt16(N);
                G = r.Next(1, E); // G is the generated random number from N (formatted via E) to kickstart interation
                Gestimate = Math.Round(G, 6);

                while (Gestimate != Nestimate)
                {
                    G = (G + N / G) / 2;
                    Gestimate = Math.Round((G * G), 6);
                }
                G = Math.Round(G, 5);
                return G;
            }
            else
            {
                G = 0;
                return G;
            }
        }
    }
}
