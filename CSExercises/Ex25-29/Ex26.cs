using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double Num, invNum, sqrtNum, sqNum;
            Num = 1;
        

            Console.WriteLine("No \t Inv \t Square Root \t Square");

            for (Num = 1; Num <= 10; Num++)
            {
                invNum = 1 / Num;
                sqrtNum = Math.Sqrt(Num);
                sqNum = Num * Num;

                Console.WriteLine("{0:0.0} \t {1:0.00} \t{2:0.00} \t {3:0.00}", Num, invNum, sqrtNum, sqNum);
            }
            string exit = Console.ReadLine();
        }
    }
}
